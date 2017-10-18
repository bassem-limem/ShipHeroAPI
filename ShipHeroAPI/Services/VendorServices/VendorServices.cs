using Newtonsoft.Json;
using ShipHeroAPI.Entities.Settings;
using ShipHeroAPI.Entities.Vendor;
using ShipHeroAPI.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ShipHeroAPI.Services.VendorServices
{
    public class VendorServices : ShipHeroService
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_ApiUrl"></param>
        /// <param name="_AccessToken"></param>
        public VendorServices(string _ApiUrl, string _AccessToken) : base(_ApiUrl, _AccessToken) { }

        /// <summary>
        /// Create new Vendor async
        /// </summary>
        /// <param name="vendor">Vendor</param>
        /// <returns>Response Message</returns>
        public async Task<ResponseMessage> CreateVendorAsync(Vendor vendor)
        {
            try
            {
                string responseData = "";
                using (var httpClient = new HttpClient { BaseAddress = this._ShipHeroUri })
                {

                    vendor.Token = this._AccessToken;
                    string vendorOutput = JsonConvert.SerializeObject(vendor);

                    using (var content = new StringContent(vendorOutput, Encoding.Default, "application/json"))
                    {
                        using (var response = await httpClient.PostAsync("v1/general-api/vendor-create/", content))
                        {
                            responseData = await response.Content.ReadAsStringAsync();
                        }
                    }

                    var responseApi = JsonConvert.DeserializeObject<ResponseMessage>(responseData);
                    return responseApi;
                }
            }
            catch (Exception e)
            {
                throw new ShipHeroException("CreateVendorAsync", e.Message);
            }
        }

        /// <summary>
        /// Add product or collection of products to a Vendor async 
        /// </summary>
        /// <param name="productToVendor">Products</param>
        /// <returns>Response Message</returns>
        public async Task<ResponseMessage> AddProductToVendorAsync(ProductInVendor productToVendor)
        {
            try
            {
                string responseData = "";
                using (var httpClient = new HttpClient { BaseAddress = this._ShipHeroUri })
                {

                    productToVendor.Token = this._AccessToken;
                    string productInVendorOutput = JsonConvert.SerializeObject(productToVendor);

                    using (var content = new StringContent(productInVendorOutput, Encoding.Default, "application/json"))
                    {
                        using (var response = await httpClient.PostAsync("v1/general-api/add-products-to-vendor/", content))
                        {
                            responseData = await response.Content.ReadAsStringAsync();
                        }
                    }

                    var responseApi = JsonConvert.DeserializeObject<ResponseMessage>(responseData);
                    return responseApi;
                }
            }
            catch (Exception e)
            {
                throw new ShipHeroException("AddProductToVendorAsync", e.Message);
            }
        }

        public async Task<ResponseMessage> AddProductsToVendorAsync(ICollection<ProductInVendor> products)
        {
            try
            {
                string responseData = "";
                using (var httpClient = new HttpClient { BaseAddress = this._ShipHeroUri })
                {
                    foreach(var item in products)
                    {
                        item.Token = this._AccessToken;
                    }
                    string productInVendorOutput = JsonConvert.SerializeObject(products);

                    using (var content = new StringContent(productInVendorOutput, Encoding.Default, "application/json"))
                    {
                        using (var response = await httpClient.PostAsync("v1/general-api/add-products-to-vendor/", content))
                        {
                            responseData = await response.Content.ReadAsStringAsync();
                        }
                    }

                    var responseApi = JsonConvert.DeserializeObject<ResponseMessage>(responseData);
                    return responseApi;
                }
            }
            catch (Exception e)
            {
                throw new ShipHeroException("AddProductsToVendorAsync", e.Message);
            }
        }

        /// <summary>
        /// Remove product from vendor
        /// </summary>
        /// <param name="sku">Product SKU</param>
        /// <param name="vendorId">Vendor Id</param>
        /// <returns>Response Message</returns>
        public async Task<ResponseMessage> RemoveProductFromVendorAsync(string sku, int vendorId)
        {
            try
            {
                string responseData = "";
                string parameters = "v1/general-api/remove-product-from-vendor/?token=" + this._AccessToken + "&sku=" + sku + "&vendor_id=" + vendorId;
                using (var httpClient = new HttpClient { BaseAddress = this._ShipHeroUri })
                {

                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = httpClient.GetAsync(parameters).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        responseData = await response.Content.ReadAsStringAsync();
                    }

                    var responseApi = JsonConvert.DeserializeObject<ResponseMessage>(responseData);
                    return responseApi;
                }
            }
            catch (Exception e)
            {
                throw new ShipHeroException("AddProductsToVendorAsync", e.Message);
            }
        }

        /// <summary>
        /// Get Collection of Vendors
        /// </summary>
        /// <returns>Collection of Vendors returned</returns>
        public async Task<VendorsOutput> GetVendorsAsync()
        {
            try
            {
                string responseData = "";
                string parameters = "v1/general-api/list-vendors/?token=" + this._AccessToken;
                using (var httpClient = new HttpClient { BaseAddress = this._ShipHeroUri })
                {

                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = httpClient.GetAsync(parameters).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        responseData = await response.Content.ReadAsStringAsync();
                    }

                    return JsonConvert.DeserializeObject<VendorsOutput>(responseData);
                }
            }
            catch (Exception e)
            {
                throw new ShipHeroException("GetVendorsAsync", e.Message);
            }
        }
    }
}
