using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eRentModel;
using System.Windows.Forms;
using Flurl;
using System.Net;
using eRentModel;
namespace eRent.WinUi
{
    public class APIService
    {
        private string _route = null;
        public string endpoint = $"{Properties.Settings.Default.APIUrl}";

        public static string Username { get; set; }
        public static string Password { get; set; }

        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search = null)
        {
            //var url = $"{Properties.Settings.Default.APIUrl}/{_route}";
            //if (search != null)
            //{
            //    url += "?";
            //    url += await search.ToQueryString();
            //}
            //var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            //return result;
            try
            {
                var query = "";
                if (search != null)
                {
                    query = await search?.ToQueryString();
                }
                //  get all ako je null
                var list = await $"{endpoint}/{_route}?{query}"
                  .WithBasicAuth(Username, Password)
                  .GetJsonAsync<T>();
                return list;
            }
            catch (FlurlHttpException ex)
            {
                return await HandleException<T>(ex);
            }

        }


        public async Task<T> GetById<T>(object id)
        {
            try
            {
                var url = $"{endpoint}/{_route}/{id}";
                return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            }
            catch (FlurlHttpException ex)
            {
                return await HandleException<T>(ex);
            }

        }
        public async Task<T> Insert<T>(object request)
        {
            try
            {
                var url = $"{endpoint}/{_route}";

                return await url
                    .WithBasicAuth(Username, Password)
                    .PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                return await HandleException<T>(ex);
            }
        }


        public async Task<T> Update<T>(object id, object request)
        {
            try
            {
                var url = $"{endpoint}/{_route}/{id}";

                return await url
                    .WithBasicAuth(Username, Password)
                    .PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                return await HandleException<T>(ex);
            }

        }

        private async Task<T> HandleException<T>(FlurlHttpException ex)
        {
            if (ex.StatusCode == (int)HttpStatusCode.Unauthorized)
            {
                MessageBox.Show("Niste autentifikovani.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ex.StatusCode == (int)HttpStatusCode.Forbidden)
            {
                MessageBox.Show("Nemate pravo pristupa.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //else
            //{
            //    var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

            //    var stringBuilder = new StringBuilder();
            //    foreach (var error in errors)
            //    {
            //        stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
            //    }

            //    MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            return default;
        }
    }
}
