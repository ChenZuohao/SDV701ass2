using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WinForms
{
    public static class ServiceClient
    {
        internal async static Task<List<string>> GetBrandName()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<string>>
            (await lcHttpClient.GetStringAsync("http://localhost:60065/api/gallery/GetBrandName/"));
        }

        internal async static Task<clsCarBrand> GetBrandAsync(string prBrandName)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<clsCarBrand>
            (await lcHttpClient.GetStringAsync
        ("http://localhost:60065/api/gallery/GetBrand?Car_BrandName=" + prBrandName));

        }

        internal async static Task<string> RemoveCarBrandAsync(string car_BrandName)
        {
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.DeleteAsync($"http://localhost:60065/api/gallery/RemoveCarBrand?Car_BrandName={car_BrandName}");
                return await lcRespMessage.Content.ReadAsStringAsync();
            }
        }

        internal async static Task<string> RemoveCarAsync(int car_ID)
        {
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.DeleteAsync($"http://localhost:60065/api/gallery/RemoveCar?Car_ID={car_ID}");
                return await lcRespMessage.Content.ReadAsStringAsync();
            }
        }


        internal async static Task<List<ClsCarOrder>> GetCarOrderListAsync()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<ClsCarOrder>>
            (await lcHttpClient.GetStringAsync("http://localhost:60065/api/gallery/GetCarOrderList"));

        }

        internal async static Task<string> RemoveCarOrderAsync(int car_ID)
        {
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.DeleteAsync($"http://localhost:60065/api/gallery/RemoveCarOrder?Car_ID={car_ID}");
                return await lcRespMessage.Content.ReadAsStringAsync();
            }

        }


        private async static Task<string> InsertOrUpdateAsync<TItem>(TItem prItem, string prUrl, string prRequest)
        {
            using (HttpRequestMessage lcReqMessage = new HttpRequestMessage(new HttpMethod(prRequest), prUrl))
            using (lcReqMessage.Content =
        new StringContent(JsonConvert.SerializeObject(prItem), Encoding.Default, "application/json"))
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.SendAsync(lcReqMessage);
                return await lcRespMessage.Content.ReadAsStringAsync();
            }
        }

        internal async static Task<string> UpdateCarkAsync(clsCar _Car)
        {
            return await InsertOrUpdateAsync(_Car, "http://localhost:60065/api/gallery/PutCar", "PUT");
        }

        internal async static Task<string> InsertCarAsync(clsCar _Car)
        {
            return await InsertOrUpdateAsync(_Car, "http://localhost:60065/api/gallery/AddCar", "POST");
        }


        internal async static Task<string> InsertBrandAsync(clsCarBrand prBrand)
        {
            return await InsertOrUpdateAsync(prBrand, "http://localhost:60065/api/gallery/AddBrand", "POST");
        }

        internal async static Task<string> UpdateBrandAsync(clsCarBrand prBrand)
        {
            return await InsertOrUpdateAsync(prBrand, "http://localhost:60065/api/gallery/PutBrand", "PUT");
        }

        internal async static Task<string> DeleteCarAsync(clsCar _Car)
        {
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.DeleteAsync
            ("http://localhost:60065/api/gallery/DeleteCar?_Car={_Car}");
                return await lcRespMessage.Content.ReadAsStringAsync();
            }
        }
    }
}
