using CottingsleyWebService.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace CottingsleyWebService
{
    public class Register
    {
         
        public Register() {
        }

        public Response GetAllQuestions()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri("http://localhost:64344/api/LandingPage/GetAllQuestions"));
                request.Method = "GET";
                request.ContentType = "application/json";
                WebResponse response = request.GetResponse();
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    JavaScriptSerializer s = new JavaScriptSerializer();
                    var result = reader.ReadToEnd();
                    return s.Deserialize<Response>(result);
                }
            }
            catch (Exception e) {
                return new Response
                {
                    Message = "Cannot connect to Web API",
                    Data = null,
                    Status = false
                };
            }
        }
    }
}
