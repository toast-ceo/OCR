using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 고시프_프로젝트
{

    public class Information
    {
        public string name { get; set; }
        public string type { get; set; }
        public string seat { get; set; }
        public string number { get; set; }
        public string date { get; set; }


        public  void MovieTicket()
        {
            type = "Movie";
        }
        public  void BaseballTicket()
        {
            type = "Baseball";
        }
        public void MuseumTicket()
        {
            type = "Museum";
        }

        public  void NameText(TextBox objTextBox)
        {
            name = objTextBox.Text;
        }
        public  void SeatText(TextBox objTextBox)
        {
            seat = objTextBox.Text;
        }
        public  void NumberText(TextBox objTextBox)
        {
            number = objTextBox.Text;
        }
        public  void DateText(TextBox objTextBox)
        {
            date = objTextBox.Text;       
        }

    }
}
