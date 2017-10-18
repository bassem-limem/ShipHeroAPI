using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShipHeroAPI.Entities.Settings;
using ShipHeroAPI.Entities.Shipment;
using ShipHeroAPI.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ShipHeroAPI.Services.ShipmentServices
{
    public class ShipmentServices : ShipHeroService
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_ApiUrl"></param>
        /// <param name="_AccessToken"></param>
        public ShipmentServices(string _ApiUrl, string _AccessToken) : base(_ApiUrl, _AccessToken) { }

        /// <summary>
        /// Create new shipment async 
        /// </summary>
        /// <param name="shipment">Shipment</param>
        /// <returns>Response Message</returns>
        public async Task<ResponseMessage> CreatePurchaseOrdersAsync(Shipment shipment)
        {
            try
            {
                string responseData = "";
                using (var httpClient = new HttpClient { BaseAddress = this._ShipHeroUri })
                {

                    shipment.Token = this._AccessToken;
                    string shipmentOutput = JsonConvert.SerializeObject(shipment);

                    using (var content = new StringContent(shipmentOutput, Encoding.Default, "application/json"))
                    {
                        using (var response = await httpClient.PostAsync("v1/general-api/create-shipment/", content))
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
        /// Get Collection of Shipments
        /// </summary>
        /// <param name="startDate">filter start date - Format YYYY-MM-DD</param>
        /// <param name="endDate">filter end date - Format YYYY-MM-DD</param>
        /// <param name="page">filter page number</param>
        /// <param name="filterOn"> filter on (order || shipment)</param>
        /// <returns>Collection of Shipments returned</returns>
        public async Task<ShipmentOutput> GetShipmentsAsync(string startDate, string endDate, string page = "0" ,  string filterOn = "shipment")
        {
            try
            {
                string responseData = "";
                string parameters = "v1/general-api/get-shipments/?token=" + this._AccessToken + "&page="+ "&from=" + startDate + "&to=" + endDate + "&filter_on=" + filterOn;
                using (var httpClient = new HttpClient { BaseAddress = this._ShipHeroUri })
                {

                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = httpClient.GetAsync(parameters).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        responseData = await response.Content.ReadAsStringAsync();
                    }


                    var ship = new ShipmentOutput();
                    ship.Orders = new OrdersOutput();
                    ship.Orders.Results = new List<Results>();

                    dynamic data = JValue.Parse(responseData);
                    var content = data.GetType().GetProperty("Last").GetValue(data, null);
                    var orders = content.GetType().GetProperty("First").GetValue(content, null);
                    var ordersList = orders.GetType().GetProperty("Last").GetValue(orders, null);
                    var firstITem = ordersList.GetType().GetProperty("First").GetValue(ordersList, null);
                    var startList = firstITem.GetType().GetProperty("First").GetValue(firstITem, null);
                   
                    var next = "";
                    while(next != null)
                    {
                        var result = new Results();
                        var firstItem = startList.GetType().GetProperty("First").GetValue(startList, null);
                        var baseItem = firstItem.GetType().GetProperty("First").GetValue(firstItem, null); 
                        var tmpnext = "";
                        while(tmpnext != null)
                        {
                            
                            var status = baseItem.GetType().GetProperty("Value").GetValue(baseItem, null);
                            var statusValue = status.Value;
                           
                                baseItem = baseItem.GetType().GetProperty("Next").GetValue(baseItem, null);

                            var method = baseItem.GetType().GetProperty("Value").GetValue(baseItem, null);
                            var methodValue = method.Value;

                                baseItem = baseItem.GetType().GetProperty("Next").GetValue(baseItem, null);
                           
                            var orderId = baseItem.GetType().GetProperty("Value").GetValue(baseItem, null);
                            var orderValue = orderId.Value;

                                baseItem = baseItem.GetType().GetProperty("Next").GetValue(baseItem, null);
                                baseItem = baseItem.GetType().GetProperty("Next").GetValue(baseItem, null);

                            var date = baseItem.GetType().GetProperty("Value").GetValue(baseItem, null);
                            var dateValue = date.Value;

                                baseItem = baseItem.GetType().GetProperty("Next").GetValue(baseItem, null);
                                baseItem = baseItem.GetType().GetProperty("Next").GetValue(baseItem, null);

                            var trackingNumber = baseItem.GetType().GetProperty("Value").GetValue(baseItem, null);
                            var trackingNumberValue = trackingNumber.Value;

                                baseItem = baseItem.GetType().GetProperty("Next").GetValue(baseItem, null);
                                baseItem = baseItem.GetType().GetProperty("Next").GetValue(baseItem, null);
                                baseItem = baseItem.GetType().GetProperty("Next").GetValue(baseItem, null);

                            var customerEmail = baseItem.GetType().GetProperty("Value").GetValue(baseItem, null);
                            var customerEmailValue = customerEmail.Value;

                                baseItem = baseItem.GetType().GetProperty("Next").GetValue(baseItem, null);
                                baseItem = baseItem.GetType().GetProperty("Next").GetValue(baseItem, null);

                            var orderReference = baseItem.GetType().GetProperty("Value").GetValue(baseItem, null);
                            var orderReferenceValue = orderReference.Value;

                            tmpnext = null;

                            ship.Orders.Results.Add(new Results
                            {
                                OrderId = orderValue,
                                OrderNumber = orderReferenceValue,
                                CustomerMail = customerEmailValue,
                                Status = statusValue,
                                CreatedAt = dateValue,
                                TrackingNumber = trackingNumberValue
                            });
                        }
                        startList = startList.GetType().GetProperty("Next").GetValue(startList, null);
                        if(startList == null)
                        {
                            next = null;
                        }
                    }

                    return ship;
                }
            }
            catch (Exception e)
            {
                throw new ShipHeroException("GetShipmentsAsync", e.Message);
            }
        }

    }
}
