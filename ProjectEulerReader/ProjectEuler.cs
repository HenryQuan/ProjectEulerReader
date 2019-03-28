using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace ProjectEulerReader
{
    public static class ProjectEuler
    {
        // Recoding current question number
        public static int curQuestion = 1;
        // Website data
        public static string information = "";
        // All problem starts with this string
        private const string prefix = @"http://projecteuler.net/problem=";

        public static string getCurrentQuestion()
        {
            string text = "";
            if (curQuestion <= 0)
            {
                return text;
            }
            else
            {
                // Download string from website
                try
                {
                    var cookie = new CookieContainer();

                    HttpWebRequest request = WebRequest.Create(prefix + curQuestion) as HttpWebRequest;
                    request.Method = "GET";
                    request.CookieContainer = cookie;
                    request.AutomaticDecompression = DecompressionMethods.Deflate;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                        | SecurityProtocolType.Tls11
                        | SecurityProtocolType.Tls12
                        | SecurityProtocolType.Ssl3;
                    WebResponse response = request.GetResponse();

                    var dataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    information = reader.ReadToEnd();

                    // Clean up the streams.
                    reader.Close();
                    dataStream.Close();
                    response.Close();

                    if (!information.Contains("Problem not accessible"))
                    {
                        HtmlAgilityPack.HtmlDocument question = new HtmlAgilityPack.HtmlDocument();
                        question.LoadHtml(information);
                        foreach (HtmlNode node in question.DocumentNode.SelectNodes("//*[@id=\"content\"]/div[3]"))
                        {
                            text += node.InnerText + "\n";
                        }
                    }
                    else
                    {
                        curQuestion = 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return text;

            }
            
        }
    }
}
