
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer2;
using Newtonsoft.Json;

namespace BusinessLogicLayer
{
    public class Logic
    {
        Api mgr = new Api();
        private static readonly HttpClient client = new HttpClient();
        public async Task< object> Group_by_date()
        {

            string apiUrl = mgr.GroupByDate; // API endpoint

            try
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode(); // Throw exception if HTTP request fails

                string jsonData = await response.Content.ReadAsStringAsync();

                // Convert JSON response to DataTable
                var dataTable = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonData);

                // Log the deserialized dictionary for debugging
                foreach (var keyValue in dataTable)
                {
                    Console.WriteLine($"{keyValue.Key}: {keyValue.Value}");
                }

                return dataTable;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching data: {ex.Message}");
                return null;
            }
        }


    }
}
