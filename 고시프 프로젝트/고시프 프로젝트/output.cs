using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 고시프_프로젝트
{

    public static class output
    {
        public static void OutDialog(string msg)
        {
            MessageBox.Show(msg);
        }
    }

    //인터프리터를 사용해서 MessageDIalog 만들기
    public interface Message
    {
        string CompareTo(Information information);
    }

    public class MessageDialog : Message
    {
        // Message 의 CompareTo 메서드 구현
        public string CompareTo(Information information)
        {
            
            string message = "회원 정보\n\n이름 : " + information.name + "\n좌석 : " + information.seat + "\n티켓 종류 : " + information.type + "\n날짜 : " + information.date + "\n일련번호 : " + information.number;
            return message;
        }
    }
}
