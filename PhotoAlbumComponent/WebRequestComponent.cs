using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PhotoAlbumProjectComponents
{
    public static class WebRequestComponent
    {
        public static string GetWebResponse(string requestBaseURI)
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
