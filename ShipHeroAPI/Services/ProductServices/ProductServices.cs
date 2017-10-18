using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using ShipHeroAPI.Entities.Product;
using Newtonsoft.Json;
using ShipHeroAPI.Entities.Settings;
using ShipHeroAPI.Settings;
using System.Configuration;
using ShipHeroAPI.Converters;

namespace ShipHeroAPI.Services.ProductServices
{
    public class ProductServices : ShipHeroService
    {
                
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_ApiUrl"></param>
        /// <param name="_AccessToken"></param>
        public ProductServices(string _ApiUrl, string _AccessToken) : base(_ApiUrl, _AccessToken) { }
        
        

        /// <summary>
        /// Create new Product async
        /// </summary>
        /// <param name="product">Product</param>
        /// <returns>Response Message</returns>
        public async Task<ResponseMessage> CreateProductAsync(Product product)
        {
            try
            {
                string responseData = "";
                using (var httpClient = new HttpClient { BaseAddress = this._ShipHeroUri })
                {

                    product.Token = this._AccessToken;
                    string productOutput = JsonConvert.SerializeObject(product);

                    using (var content = new StringContent(productOutput, Encoding.Default, "application/json"))
                    {
                        using (var response = await httpClient.PostAsync("v1/general-api/product-creation/", content))
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
                throw new ShipHeroException("CreateProductAsync", e.Message);
            }
        }

        /// <summary>
        /// Create new Products async 
        /// </summary>
        /// <param name="products">Products</param>
        /// <returns>Response Message</returns>
        public async Task<ResponseMessage> CreateProductsAsync(ICollection<Product> products)
        {
            try
            {
                string responseData = "";
                using (var httpClient = new HttpClient { BaseAddress = this._ShipHeroUri })
                {
                    foreach (var item in products)
                    {
                        item.Token = this._AccessToken;
                    }
                    string productsOutput = JsonConvert.SerializeObject(products);

                    using (var content = new StringContent(productsOutput, Encoding.Default, "application/json"))
                    {
                        using (var response = await httpClient.PostAsync("v1/general-api/product-creation/", content))
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
                throw new ShipHeroException("CreateProductsAsync", e.Message);
            }
        }

        /// <summary>
        /// Update product in inventory async
        /// </summary>
        /// <param name="product">Product In Inventory</param>
        /// <returns>Response Message</returns>
        public async Task<ResponseMessage> UpdateProductInInventoryAsync(ProductInInventory product)
        {
            try
            {
                string responseData = "";
                using (var httpClient = new HttpClient { BaseAddress = this._ShipHeroUri })
                {
                    product.Token = this._AccessToken;
                    string productOutput = JsonConvert.SerializeObject(product);

                    using (var content = new StringContent(productOutput, Encoding.Default, "application/json"))
                    {
                        using (var response = await httpClient.PostAsync("v1/general-api/update-inventory/", content))
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
                throw new ShipHeroException("UpdateProductInInventoryAsync", e.Message);
            }
        }

        /// <summary>
        /// Get Collection of Products async
        /// </summary>
        /// <param name="page">filter page number</param>
        /// <param name="count">filter number of products returned</param>
        /// <returns>collection of products returned</returns>
        public async Task<ProductOutput> GetProductsAsync(string page = "", string count = "")
        {
            try
            {
                string responseData = "";
                string parameters = "v1/general-api/get-product/?token=" + this._AccessToken + "&page=" + page + "&count=" + count;
                using (var httpClient = new HttpClient { BaseAddress = this._ShipHeroUri })
                {

                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = httpClient.GetAsync(parameters).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        responseData = await response.Content.ReadAsStringAsync();
                    }

                    var responseApi = JsonConvert.DeserializeObject<ProductOutput>(responseData);
                    return responseApi;
                }
            }
            catch (Exception e)
            {
                throw new ShipHeroException("GetProductAsync", e.Message);
            }
        }


        // public async Task<ICollection<Variant>> GetProductVariants(string productId) { }

        /// <summary>
        /// Get existing Product by SKU
        /// </summary>
        /// <param name="sku">SKU of product</param>
        /// <returns>product returned</returns>
        public async Task<Product> GetProductBySKUAsync(string sku)
        {
            try
            {
                string responseData = "";
                string parameters = "v1/general-api/get-product/?token=" + this._AccessToken + "&sku=" + sku;
                using (var httpClient = new HttpClient { BaseAddress = this._ShipHeroUri })
                {

                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = httpClient.GetAsync(parameters).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        responseData = await response.Content.ReadAsStringAsync();
                    }

                    var responseApi = JsonConvert.DeserializeObject<Product>(responseData);
                    return responseApi;
                }
            }
            catch (Exception e)
            {
                throw new ShipHeroException("GetProductBySKUAsync", e.Message);
            }
        }
        //public async Task<ICollection<Product>> GetProductsByVendorAsync() { }
        //public async Task<ICollection<Product>> GetProductsByWarehouseAsync() { }
        //public async Task<ICollection<Product>> ImportProductsAsync() { }

    }
}
