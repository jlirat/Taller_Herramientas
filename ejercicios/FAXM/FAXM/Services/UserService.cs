using FAXM.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace FAXM.Services
{
    public class UserService
    {
        public bool login(User user)
        {

            var url = $"https://kaantera.com/api/2/login/authenticate";
            var request = (HttpWebRequest)WebRequest.Create(url);
            string json = "{" + "\"user\":\"" + user.Username + "\", " + "\"pass\": \"" + user.Pass + "\"}";
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            using (var streamWriter = new StreamWriter(request.GetRequestStream())) {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            try
            {
                using (WebResponse response =  request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return false;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            Console.WriteLine(responseBody);
                            if (responseBody.CompareTo("Unauthorized")==0)
                            {
                                return false;
                            } else
                            {
                                return true;
                            }
                        }
                    }
                }
            }catch(Exception ex)
            {
                return false;
            }
        }
    }
}
