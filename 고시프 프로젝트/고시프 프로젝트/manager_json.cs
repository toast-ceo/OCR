using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 고시프_프로젝트
{
    public class JsonManagement
    {
        /// <summary>
        ///  해야할 것.
        ///  1. 티켓 종류 선택.
        ///  2. 종류에 따른 입력 값 받기
        ///  3. 해당 입력 값을 변수에 1대1 대응 시켜 놓기
        /// </summary>

        List<string> nameList = new List<string>();
        List<string> typeList = new List<string>();
        List<string> seatList = new List<string>();
        List<string> numberList = new List<string>();
        List<string> dateList = new List<string>();

        //json파일 생성
        public void CreateJson()
        {
            string path = @"C:\\Users\\issac\\source\\repos\\고시프 프로젝트\\test.json";
            if (!File.Exists(path))
            {
                using (File.Create(path))
                {
                    MessageBox.Show("파일 생성 성공");
                }
            }
            else
            {
                MessageBox.Show("이미 파일이 존재합니다");
            }
        }
        //json파일 사용
        public void ReadJson()
        {
            string jsonFilePath = @"C:\\Users\\issac\\source\\repos\\고시프 프로젝트\\test.json";

            using (JsonTextReader reader = new JsonTextReader(File.OpenText(jsonFilePath)))
            {
                JObject json = (JObject)JToken.ReadFrom(reader);

                if (json.Count > 0)
                {
                    for (int tmp = 0; tmp < json.Count; tmp++)
                    {
                        nameList.Add((string)json[$"{tmp}"]["name"]);
                        typeList.Add((string)json[$"{tmp}"]["type"]);
                        seatList.Add((string)json[$"{tmp}"]["seat"]);
                        numberList.Add((string)json[$"{tmp}"]["number"]);
                        dateList.Add((string)json[$"{tmp}"]["date"]);
                    }
                }
                else { }
            }

        }
        //json파일 쓰기
        public void ToDictionary(Information information)
        {
           
            string path = @"C:\\Users\\issac\\source\\repos\\고시프 프로젝트\\test.json";
            
            nameList.Add(information.name);
            typeList.Add(information.type);
            seatList.Add(information.seat);
            numberList.Add(information.number);
            dateList.Add(information.date);

            Dictionary<int, Dictionary<string, string>> dic = new Dictionary<int, Dictionary<string, string>> { };

            for (int tmp = 0; tmp < nameList.Count; tmp++)
            {
                Dictionary<string, string> user = new Dictionary<string, string>
                {
                    { "name", nameList[tmp] },
                    { "type", typeList[tmp]},
                    { "seat", seatList[tmp] },
                    { "number", numberList[tmp] },
                    { "date", dateList[tmp]}
                };
                dic.Add(tmp, user);
            }
            File.WriteAllText(path, JsonConvert.SerializeObject(dic));
            output.OutDialog("입력이 완료 되었습니다!");
        }


    }
}
