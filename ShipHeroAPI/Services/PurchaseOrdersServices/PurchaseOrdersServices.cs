using Newtonsoft.Json;
using ShipHeroAPI.Entities.PurchaseOrders;
using ShipHeroAPI.Entities.Settings;
using ShipHeroAPI.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ShipHeroAPI.Services.PurchaseOrdersServices
{
    public class PurchaseOrdersServices : ShipHeroService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_ApiUrl"></param>
        /// <param name="_AccessToken"></param>
        public PurchaseOrdersServices(string _ApiUrl, string _AccessToken) : base(_ApiUrl, _AccessToken) { }


        /// <summary>
        /// Create new Purchase Orders async
        /// </summary>
        /// <param name="purchaseOrders">Purchase Orders</param>
        /// <returns>Response Message</returns>
        public async Task<ResponseMessage> CreatePurchaseOrdersAsync(PurchaseOrders purchaseOrders)
        {
            try
            {
                string responseData = "";
                using (var httpClient = new HttpClient { BaseAddress = this._ShipHeroUri })
                {

                    purchaseOrders.Token = this._AccessToken;
                    string purchaseOrdersOutput = JsonConvert.SerializeObject(purchaseOrders);

                    using (var content = new StringContent(purchaseOrdersOutput, Encoding.Default, "application/json"))
                    {
                        using (var response = await httpClient.PostAsync("v1/general-api/po-creation/", content))
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
                throw new ShipHeroException("CreatePurchaseOrdersAsync", e.Message);
            }
        }

        /// <summary>
        /// Get existing Purchase Orders by Id
        /// </summary>
        /// <param name="purchaseOrdersId">Purchase Orders Id</param>
        /// <returns>Purchase Orders returned</returns>
        public async Task<PurchaseOrders> GetPurchaseOrdersByIdAsync(int purchaseOrdersId)
        {
            try
            {
                string responseData = "";
                string parameters = "v1/general-api/get-po/?token=" + this._AccessToken + "&po_id=" + purchaseOrdersId;
                using (var httpClient = new HttpClient { BaseAddress = this._ShipHeroUri })
                {

                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = httpClient.GetAsync(parameters).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        responseData = await response.Content.ReadAsStringAsync();
                    }

                    var responseApi = JsonConvert.DeserializeObject<PurchaseOrders>(responseData);
                    return responseApi;
                }
            }
            catch (Exception e)
            {
                throw new ShipHeroException("GetPurchaseOrdersByIdAsync", e.Message);
            }
        }

        /// <summary>
        /// Get existing Purchase Orders by Id
        /// </summary>
        /// <param name="purchaseOrdersNumber">Purchase Orders Id</param>
        /// <returns>Purchase Orders returned</returns>
        public async Task<PurchaseOrders> GetPurchaseOrdersByNumberAsync(string purchaseOrdersNumber)
        {
            try
            {
                string responseData = "";
                string parameters = "v1/general-api/get-po/?token=" + this._AccessToken + "&po_number=" + purchaseOrdersNumber;
                using (var httpClient = new HttpClient { BaseAddress = this._ShipHeroUri })
                {

                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = httpClient.GetAsync(parameters).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        responseData = await response.Content.ReadAsStringAsync();
                    }

                    var responseApi = JsonConvert.DeserializeObject<PurchaseOrders>(responseData);
                    return responseApi;
                }
            }
            catch (Exception e)
            {
                throw new ShipHeroException("GetPurchaseOrdersByNumberAsync", e.Message);
            }
        }

    }
}
