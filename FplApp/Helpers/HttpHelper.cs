using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FplApp.Helpers
{
    public static class HttpHelper
    {
        public static string Get(string uri, string token, string refreshToken)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            request.Headers.Add("Authorization", "Bearer " + token);
            request.Headers.Add("refreshToken", refreshToken);

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return reader.ReadToEnd();
                }
                else if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    return "";
                }
                return "";
            }
        }

        public static string Post(string uri, string resource, string token, string refreshToken)
        {
            try
            {
                ASCIIEncoding encoder = new ASCIIEncoding();
                byte[] data = encoder.GetBytes(resource);
                HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
                request.Method = "POST";
                request.ContentType = "application/json";
                request.ContentLength = data.Length;
                request.Expect = "application/json";
                request.Headers.Add("Authorization", "Bearer " + token);
                //request.Headers.Add("refreshToken", refreshToken);

                request.GetRequestStream().Write(data, 0, data.Length);

                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                string responseFromServer = string.Empty;
                using (Stream stream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream);
                    responseFromServer = reader.ReadToEnd();

                }
                if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Created)
                {
                    return responseFromServer;
                }

                return null;

            }
            catch (Exception e)
            {
                return null;

                throw;
            }
        }

        public static string Patch(string uri, string resource, string token, string refreshToken)
        {
            try
            {
                ASCIIEncoding encoder = new ASCIIEncoding();
                byte[] data = encoder.GetBytes(resource); // a json object, or xml, whatever...

                HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
                request.Method = "PATCH";
                request.ContentType = "application/json";
                request.ContentLength = data.Length;
                request.Expect = "application/json";
                request.Headers.Add("Authorization", "Bearer " + token);
                //request.Headers.Add("refreshToken", refreshToken);

                request.GetRequestStream().Write(data, 0, data.Length);

                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Created)
                {
                    return "ok";
                }
                return null;
            }
            catch (Exception e)
            {
                return null;

                throw;
            }
        }
        public static string Delete(string uri, int resource, string token, string refreshToken)
        {

            WebRequest request = WebRequest.Create(uri + "/" + resource);
            request.Method = "DELETE";
            request.Headers.Add("Authorization", "Bearer " + token);
            request.Headers.Add("refreshToken", refreshToken);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Created)
            {
                return "ok";
            }
            return null;
        }
    }
}
