using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace 고시프_프로젝트
{
    public static class ImageFile
    {
        public static Bitmap bmp;

        public static class FileOpen
        {
            public static void Open(PictureBox pictureBox1)
            {
                string imgfile = string.Empty;
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.InitialDirectory = @"C:\";
                if (dialog.ShowDialog() == DialogResult.OK)
                { imgfile = dialog.FileName; }
                else if (dialog.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                try { bmp = new Bitmap(imgfile); pictureBox1.Image = bmp; } catch { output.OutDialog("처리되지 않았어요!"); }
            }
        }
        public static class FileBinary
        {
            public static void Binary(PictureBox pictureBox1)
            {
                for (int i = 0; i < bmp.Width; i++)
                {
                    for (int j = 0; j < bmp.Height; j++)
                    {
                        Color c = bmp.GetPixel(i, j);
                        int binary = (c.R + c.G + c.B) / 3;

                        if (binary > 220)
                            bmp.SetPixel(i, j, Color.Black);
                        else
                            bmp.SetPixel(i, j, Color.White);
                    }
                }
                pictureBox1.Image = bmp;
            }
        }
        public static class FileAnalysis
        {
            public static void Analysis()
            {
                //tessract 분석  
                Pix pix = PixConverter.ToPix(bmp);
                var engine = new TesseractEngine(@"C:\\Users\\issac\\source\\repos\\고시프\\packages\\Tesseract.3.0.2.0\\tessdata", "eng", EngineMode.TesseractAndCube);
                var result = engine.Process(pix);
                String temp = result.GetText();

                //data modify
                temp = temp.ToUpper();
                temp = Regex.Replace(temp, @"\s", "");
                Console.WriteLine(temp);

                //타입의 변수들을 1,2,3으로 바꿔줌 
                temp = temp.Replace("MOVIE", "@");
                temp = temp.Replace("MUSEUM", "#");
                temp = temp.Replace("BASEBALL", "*");

                //해당 데이터 지움, 한 칸 띄운 이유 => 변수끼리 더해져서 단어가 만들어질 가능성을 줄이기 위함
                temp = temp.Replace("NAME", " ");
                temp = temp.Replace("SEAT", " ");
                temp = temp.Replace("DATE", " ");
                temp = temp.Replace("NUMBER", " ");

                // 맞는 티켓 형식으로 나눠줌, 각 Movie : 1, Museum : 2, BaseBall : 3
                if (temp.Contains("@"))
                {
                    MovieTicket movieTicket = new MovieTicket();
                    movieTicket.Loading(temp);
                    movieTicket.InterimVerification();
                }
                else if (temp.Contains("#"))
                {
                    MuseumTicket museumTicket = new MuseumTicket();
                    museumTicket.Loading(temp);
                    museumTicket.InterimVerification();
                }
                else if (temp.Contains("*"))
                {
                    BaseballTicket baseballTicket = new BaseballTicket();
                    baseballTicket.Loading(temp);
                    baseballTicket.InterimVerification();
                }
                else
                {
                    output.OutDialog("입력 사진이 옳바르지 않아요");
                }
              
            }
        }
    }


}
