using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Common
{
    public class BaseRestAccess
    {
        private string Url;
        public ClientRestFul client;



        public BaseRestAccess(string url)
        {
            this.Url = url;
          

        }



        public string GetAllRaw(HttpVerb _method, string body, object[] newParameters = null)
        {

            string url = Url;
            if (newParameters != null)
            {
                foreach (object param in newParameters)
                    url += $"/{param.ToString()}";
            }

            client = new ClientRestFul(url, _method, body);
            string response = client.MakeRequest();
            return response;
        }



    }
}
