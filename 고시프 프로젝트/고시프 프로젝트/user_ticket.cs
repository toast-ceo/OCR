using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 고시프_프로젝트

{
    //factory pattern
    public abstract class Ticket
    {
        public abstract void Loading(string info);
        public abstract void InterimVerification();
      
    }

    public class MovieTicket : Ticket
    {
        public List<string> userInfoList = new List<string>();
        public Dictionary<string, string> userInfoDictionary = new Dictionary<string, string>();
        Information_check informationCheckFrm = new Information_check();

        //초기화
        public override void Loading(string info)
        {
            info = info.Replace("@", "");
            userInfoList.Add("typename");
            userInfoList.Add("name");
            userInfoList.Add("seat");
            userInfoList.Add("number");
            userInfoList.Add("date");
            userInfoList.Add("type");

            string[] val = info.Split(' ');
            int num = 0;
            foreach (string temp in val)
            {
                userInfoDictionary.Add(userInfoList[num], temp);
                num++;
            }
            userInfoDictionary.Add(userInfoList[num], "Movie");
        }
        public override void InterimVerification()
        {                    
            informationCheckFrm.Loading(userInfoDictionary);
            informationCheckFrm.Show();             
        }
        

    }

    public class MuseumTicket : Ticket
    {
        public List<string> userInfoList = new List<string>();
        public Dictionary<string, string> userInfoDictionary = new Dictionary<string, string>();
        Information_check informationCheckFrm = new Information_check();

        //초기화
        public override void Loading(string info)
        {
            info = info.Replace("#", "");
            userInfoList.Add("typename");
            userInfoList.Add("name");
            userInfoList.Add("number");
            userInfoList.Add("date");
            userInfoList.Add("type");

            string[] val = info.Split(' ');
            int num = 0;
            foreach (string temp in val)
            {
                userInfoDictionary.Add(userInfoList[num], temp);
                num++;
            }
            userInfoDictionary.Add(userInfoList[num], "Museum");
        }
        public override void InterimVerification()
        {
            informationCheckFrm.Loading(userInfoDictionary);
            informationCheckFrm.Show();
        }


    }

    public class BaseballTicket : Ticket
    {
        public List<string> userInfoList = new List<string>();
        public Dictionary<string, string> userInfoDictionary = new Dictionary<string, string>();
        Information_check informationCheckFrm = new Information_check();

        //초기화
        public override void Loading(string info)
        {
            info = info.Replace("*", "");
            userInfoList.Add("typename");
            userInfoList.Add("name");
            userInfoList.Add("number");
            userInfoList.Add("seat");
            userInfoList.Add("date");
            userInfoList.Add("type");

            string[] val = info.Split(' ');
            int num = 0;
            foreach (string temp in val)
            {
                userInfoDictionary.Add(userInfoList[num], temp);
                num++;
            }
            userInfoDictionary.Add(userInfoList[num], "Baseball");
        }
        public override void InterimVerification()
        {
            informationCheckFrm.Loading(userInfoDictionary);
            informationCheckFrm.Show();
        }
    }
    
}
