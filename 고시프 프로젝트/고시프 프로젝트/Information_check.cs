using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 고시프_프로젝트
{
    public partial class Information_check : Form
    {
       
        public Information_check()
        {
            InitializeComponent();
        }

        string type = null;
        string name = null;
        string seat = null;
        string number = null;
        string date = null;

        public void Loading(Dictionary<string, string> temp)
        {
            TicketName.Text = temp["typename"];
            NameTextBox.Text = temp["name"];
            SeatTextBox.Text = temp["seat"];
            NumberTextBox.Text = temp["number"];
            DateTextBox.Text = temp["date"];
            type = temp["type"];
        }
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            name = NameTextBox.Text;
        }
        private void SeatTextBox_TextChanged(object sender, EventArgs e)
        {
            seat = SeatTextBox.Text;
        }
        private void NumberTextBox_TextChanged(object sender, EventArgs e)
        {
            number = NumberTextBox.Text;
        }
        private void DateTextBox_TextChanged(object sender, EventArgs e)
        {
            date = DateTextBox.Text;
        }

        public void Modify_Button(object sender, EventArgs e)
        {
            DataComparison dataComparison = new DataComparison();
            if(type == "Movie")
            {
                dataComparison.MovieDataComparison(name, seat, number, date);
            }
            else if (type == "Museum")
            {
                dataComparison.MuseumDataComparison(name, number, date);
            }
            else if (type == "Baseball")
            {
                dataComparison.BaseballDataComparison(name, seat, number, date);
            }
            //닫기
            using (Information_check frm = (Information_check)ActiveForm)
            {
                frm.Close();
            }
        }

    }
}
