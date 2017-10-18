using Newtonsoft.Json;
using ShipHeroAPI.Entities.Order;
using ShipHeroAPI.Entities.Settings;
using ShipHeroAPI.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ShipHeroAPI.Services.OrderServices
{
    public class OrderServices : ShipHeroService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_ApiUrl"></param>
        /// <param name="_AccessToken"></param>
        public OrderServices(string _ApiUrl, string _AccessToken) : base(_ApiUrl, _AccessToken) { }

        /// <summary>
        /// Create new Order async
        /// </summary>
        /// <param name="order">Order</param>
        /// <returns>Response Message</returns>
        public async Task<ResponseMessage> CreateOrderAsync(Order order)
        {
            try
            {
                string responseData = "";
                using (var httpClient = new HttpClient { BaseAddress = this._ShipHeroUri })
                {

                    order.Token = this._AccessToken;
                    string orderOutput = JsonConvert.SerializeObject(order);

                    using (var content = new StringContent(orderOutput, Encoding.Default, "application/json"))
                    {
                        using (var response = await httpClient.PostAsync("v1/general-api/order-creation/", content))
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
                throw new ShipHeroException("CreateOrderAsync", e.Message);
            }
        }

        /// <summary>
        /// Create new Orders async
        /// </summary>
        /// <param name="orders">Orders</param>
        /// <returns>Response Message</returns>
        public async Task<ResponseMessage> CreateOrdersAsync(ICollection<Order> orders)
        {
            try
            {
                string responseData = "";
                using (var httpClient = new HttpClient { BaseAddress = this._ShipHeroUri })
                {
                    foreach (var item in orders)
                    {
                        item.Token = this._AccessToken;
                    }
                    string ordersOutput = JsonConvert.SerializeObject(orders);

                    using (var content = new StringContent(ordersOutput, Encoding.Default, "application/json"))
                    {
                        using (var response = await httpClient.PostAsync("v1/general-api/order-creation/", content))
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
                throw new ShipHeroException("CreateOrdersAsync", e.Message);
            }
        }

        /// <summary>
        /// Update Order async 
        /// </summary>
        /// <param name="order">Order</param>
        /// <returns>Response Message</returns>
        public async Task<ResponseMessage> UpdateOrderAsync(Order order)
        {
            try
            {
                string responseData = "";
                using (var httpClient = new HttpClient { BaseAddress = this._ShipHeroUri })
                {

                    order.Token = this._AccessToken;
                    string orderOutput = JsonConvert.SerializeObject(order);

                    using (var content = new StringContent(orderOutput, Encoding.Default, "application/json"))
                    {
                        using (var response = await httpClient.PostAsync("v1/general-api/order-update/", content))
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
                throw new ShipHeroException("UpdateOrderAsync", e.Message);
            }
        }

        /// <summary>
        /// Add Order History to existing Order async
        /// </summary>
        /// <param name="orderHistory">Order History</param>
        /// <returns>Response Message</returns>
        public async Task<ResponseMessage> CreateOrderHistoryAsync(OrderHistory orderHistory)
        {
            try
            {
                string responseData = "";
                using (var httpClient = new HttpClient { BaseAddress = this._ShipHeroUri })
                {

                    orderHistory.Token = this._AccessToken;
                    string orderHistoryOutput = JsonConvert.SerializeObject(orderHistory);

                    using (var content = new StringContent(orderHistoryOutput, Encoding.Default, "application/json"))
                    {
                        using (var response = await httpClient.PostAsync("v1/general-api/order-history-creation/", content))
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
                throw new ShipHeroException("CreateOrderHistoryAsync", e.Message);
            }
        }

        /// <summary>
        /// Get Order by Order Reference (order_number) async
        /// </summary>
        /// <param name="orderReference">Order Id</param>
        /// <returns>Order returned by its reference</returns>
        public async Task<Order> GetOrderByOrderReferenceAsync(string orderReference)
        {
            try
            {
                string responseData = "";
                string parameters = "v1/general-api/get-order/?token=" + this._AccessToken + "&order_number=" + orderReference;
                using (var httpClient = new HttpClient { BaseAddress = this._ShipHeroUri })
                {

                    httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = httpClient.GetAsync(parameters).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        responseData = await response.Content.ReadAsStringAsync();
                    }

                    var responseApi = JsonConvert.DeserializeObject<Order>(responseData);
                    return responseApi;
                }
            }
            catch (Exception e)
            {
                throw new ShipHeroException("GetOrderByIdAsync", e.Message);
            }
        }

        /// <summary>
        /// Get Order by Order Number async
        /// </summary>
        /// <param name="orderNumber">Order Number</param>
        /// <returns>Order returned by Order Number</returns>
        public async Task<Order> GetOrderByNumberAsync(string orderNumber)
        {
            try
            {
                string responseData = "";
                string parameters = "v1/general-api/get-order/?token=" + this._AccessToken + "&order_number=" + orderNumber;
                using (var httpClient = new HttpClient { BaseAddress = this._ShipHeroUri })
                {

                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = httpClient.GetAsync(parameters).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        responseData = await response.Content.ReadAsStringAsync();
                    }

                    var responseApi = JsonConvert.DeserializeObject<Order>(responseData);
                    return responseApi;
                }
            }
            catch (Exception e)
            {
                throw new ShipHeroException("GetOrderByNumberAsync", e.Message);
            }
        }

        /// <summary>
        /// Get Orders async
        /// </summary>
        /// <param name="startDate">the filter Start Date</param>
        /// <param name="endDate">the filter End Date </param>
        /// <param name="page">the filter page</param>
        /// <returns>Collection or Orders returned</returns>
        public async Task<ICollection<Order>> GetOrdersAsync(string startDate, string endDate, string page = "")
        {
            try
            {
                string responseData = "";
                string parameters = "v1/general-api/get-orders/?token=" + this._AccessToken + "&page=" + page + "&from=" + startDate + "&to=" + endDate;
                using (var httpClient = new HttpClient { BaseAddress = this._ShipHeroUri })
                {

                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = httpClient.GetAsync(parameters).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        responseData = await response.Content.ReadAsStringAsync();
                    }

                    var responseApi = JsonConvert.DeserializeObject<IEnumerable<Order>>(responseData);
                    return responseApi.ToList();
                }
            }
            catch (Exception e)
            {
                throw new ShipHeroException("GetOrdersAsync", e.Message);
            }
        }

        /// <summary>
        /// Get Orders In Warehouse async
        /// </summary>
        /// <param name="startDate">the filter Start Date</param>
        /// <param name="endDate">the filter End Date </param>
        /// <param name="warehouseId">Warehouse Id</param>
        /// <param name="page">the filter page</param>
        /// <returns>Collection of Orders in Warehouse returned</returns>
        public async Task<ICollection<Order>> GetOrdersByWarehouseIdAsync(string startDate, string endDate, int warehouseId, string page = "")
        {
            try
            {
                string responseData = "";
                string parameters = "v1/general-api/get-orders/?token=" + this._AccessToken + "&page=" + page + "&from=" + startDate + "&to=" + endDate + "&warehouse_id=" + warehouseId;
                using (var httpClient = new HttpClient { BaseAddress = this._ShipHeroUri })
                {

                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = httpClient.GetAsync(parameters).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        responseData = await response.Content.ReadAsStringAsync();
                    }

                    var responseApi = JsonConvert.DeserializeObject<IEnumerable<Order>>(responseData);
                    return responseApi.ToList();
                }
            }
            catch (Exception e)
            {
                throw new ShipHeroException("GetOrdersInWarehouseAsync", e.Message);
            }
        }


    }
}
