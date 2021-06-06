using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 고시프_프로젝트
{
    public class DataComparison
    {
        public bool check = false;
        public void MovieDataComparison(string name, string seat, string number, string date)
        {
            string jsonFilePath = @"C:\\Users\\issac\\source\\repos\\고시프 프로젝트\\test.json";

            using (JsonTextReader reader = new JsonTextReader(File.OpenText(jsonFilePath)))
            {
                JObject json = (JObject)JToken.ReadFrom(reader);

                for (int tmp = 0; tmp < json.Count; tmp++)
                {
                    if ("Movie" == (string)json[$"{tmp}"]["type"] && name == (string)json[$"{tmp}"]["name"] && seat == (string)json[$"{tmp}"]["seat"] && number == (string)json[$"{tmp}"]["number"] && date == (string)json[$"{tmp}"]["date"])
                    {
                        check = true;
                        output.OutDialog("해당 티켓은 진짜입니다 !");
                       
                    }
                }
                if (!check)
                {
                    output.OutDialog("해당 티켓은 가짜입니다 !");
                }
                
            }
        }
        public void MuseumDataComparison(string name,  string number, string date)
        {
            string jsonFilePath = @"C:\\Users\\issac\\source\\repos\\고시프 프로젝트\\test.json";

            using (JsonTextReader reader = new JsonTextReader(File.OpenText(jsonFilePath)))
            {
                JObject json = (JObject)JToken.ReadFrom(reader);

                for (int tmp = 0; tmp < json.Count; tmp++)
                {
                    if ("Museum" == (string)json[$"{tmp}"]["type"] && name == (string)json[$"{tmp}"]["name"] && number == (string)json[$"{tmp}"]["number"] && date == (string)json[$"{tmp}"]["date"])
                    {
                        check = true;
                        output.OutDialog("해당 티켓은 진짜입니다 !");
                       
                    }
                }
                if (!check)
                {
                    output.OutDialog("해당 티켓은 가짜입니다 !");
                }

            }
        }
            public void BaseballDataComparison(string name, string seat, string number, string date)
            {
                string jsonFilePath = @"C:\\Users\\issac\\source\\repos\\고시프 프로젝트\\test.json";

                using (JsonTextReader reader = new JsonTextReader(File.OpenText(jsonFilePath)))
                {
                    JObject json = (JObject)JToken.ReadFrom(reader);

                    for (int tmp = 0; tmp < json.Count; tmp++)
                    {
                        if ("Baseball" == (string)json[$"{tmp}"]["type"] && name == (string)json[$"{tmp}"]["name"] && seat == (string)json[$"{tmp}"]["seat"] && number == (string)json[$"{tmp}"]["number"] && date == (string)json[$"{tmp}"]["date"])
                        {
                        check = true;
                        output.OutDialog("해당 티켓은 진짜입니다 !");          
                        }
                    } 
                    if (!check)
                    {
                    output.OutDialog("해당 티켓은 가짜입니다 !");
                    }
                    
                }
            }
        }
    }
