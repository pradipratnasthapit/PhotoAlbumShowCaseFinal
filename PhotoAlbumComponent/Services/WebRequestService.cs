using System.IO;
using System.Net;


namespace Services
{
    public class WebRequestService
    {
        public string GetWebResponse(string requestBaseURI)
        {
            WebRequest request = WebRequest.Create(requestBaseURI);
            request.Method = "GET";

            WebResponse response = request.GetResponse();

            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();

            reader.Close();
            response.Close();
            return responseFromServer;
        }
    }
}
