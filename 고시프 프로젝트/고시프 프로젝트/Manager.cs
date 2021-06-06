using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace 고시프_프로젝트
{
    public partial class Manager : Form
    {
        public static Information information = new Information();
        public Manager()
        {
            InitializeComponent();
        }

        //Movie버튼을 눌렀을 때
        private void Movie_Type(object sender, EventArgs e)
        {
            information.MovieTicket();
        }
        //Museum버튼을 눌렀을 때
        private void Museum_Type(object sender, EventArgs e)
        {
            information.MuseumTicket();
        }
        //Baseball버튼을 눌렀을 때
        private void Baseball_Type(object sender, EventArgs e)
        {
            information.BaseballTicket();
        }

        private void NameTextbox(object sender, EventArgs e)
        {
            information.NameText((TextBox)sender);
        }

        private void SeatTextbox(object sender, EventArgs e)
        {
            information.SeatText((TextBox)sender);
        }

        private void NumberTextbox(object sender, EventArgs e)
        {
            information.NumberText((TextBox)sender);
        }

        private void DateTextbox(object sender, EventArgs e)
        {
            information.DateText((TextBox)sender);
        }

        //정보확인
        private void Check_Informtion(object sender, EventArgs e)
        {
            
            Message msg = new MessageDialog();
            output.OutDialog(msg.CompareTo(information));
        }

        //최종 확인
        private void Check(object sender, EventArgs e)
        {
            JsonManagement jsonManagement = new JsonManagement();
            //jsonManagement.CreateJson();
            jsonManagement.ReadJson();
            jsonManagement.ToDictionary(information);
            
        }
       
    }
}
