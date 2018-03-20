using CottingsleyWebService.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
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
        public Response SchoolvisitorInformation(SchoolRegistration slkReg)
        {

          try
          {

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri("http://localhost:64344/api/LandingPage/PostSchoolRegistration"));
            var postData = slkReg;
            JavaScriptSerializer s = new JavaScriptSerializer();
            var data = s.Serialize(postData);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = data.Length;

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(data);
                streamWriter.Flush();
            }

            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            return new Response
            {
                Message = "Posted data to Web API",
                Data = responseString,
                Status = true
            };
  
            }
          catch (Exception)
          {
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
