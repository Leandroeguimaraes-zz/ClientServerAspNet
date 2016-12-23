using IllusionistClient.Model.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace IllusionistClient.Model.Model
{
    public class Payment
    {
        private string Url { get; set; }       
        public Payment()
        {
            this.Url = "http://localhost:62377/api/transaction";
        }
        public void SendTransaction(Transaction transaction)
        {
            string content;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "POST";
            request.Accept = "application/json";
            request.ContentType = "application/xml";

            string json = "{'Transaction'}";
            byte[] jsonBytes = Encoding.UTF8.GetBytes(json);
            request.GetRequestStream().Write(jsonBytes, 0, jsonBytes.Length);

            HttpWebResponse response = (HttpWebResponse) request.GetResponse();
            using(Stream responseStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
               content = reader.ReadToEnd();
            }
            MessageBox.Show(content);
        }       
    }
}
