﻿using System.IO;
using System.Net;

namespace DDApi.Common
{
    public class HttpRequestHelper
    {
        public static string Get(string url)
        {
            WebRequest request = HttpWebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string content = reader.ReadToEnd();
            return content;
        }

        public static string Post(string url)
        {
            WebRequest request = HttpWebRequest.Create(url);
            request.Method = "POST";
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string content = reader.ReadToEnd();
            return content;
        }
    }
}
