using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Collections.Specialized;

namespace ProgramingCompetitionLibrary.Models
{
    public static class OutputModel
    {
        public static string FetchData(string input)
        {
            string endpoint = "9d8f97f9.compilers.sphere-engine.com";
            string accessToken = "b9b0e0ea1a4c2f212faefafe43da0903";

            try
            {
                WebClient client = new WebClient();

                NameValueCollection formData = new NameValueCollection();
                formData.Add("source", input);
                formData.Add("compilerId", "27");

                // send request
                byte[] responseBytes = client.UploadValues("http://" + endpoint + "/api/v3/submissions?access_token=" + accessToken, "POST", formData);
                string responseBody = Encoding.UTF8.GetString(responseBytes);

                // process response
                return responseBody;
            }
            catch (WebException exception)
            {
                WebResponse response = exception.Response;
                response.Close();
                return $"{exception}";
            }

        }
    }
}





