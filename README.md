# 티켓 판별기(고시프 프로젝트)

### 202004026 이삭

# 프로그램 설명

- OCR 을 이용해 티켓을 이미지 형태로 받아와서 해당 티켓이 진짜인지 가짜인지 판별해주는 프로그램
- 티켓의 정보를 넣어주는 Manager 와 티켓을 판별해주는 User 으로 나눴습니다

# 구조 설명

- 전체적으로 사용하는 변수는 name, type, seat, number, date 5개 이다.

![%E1%84%90%E1%85%B5%E1%84%8F%E1%85%A6%E1%86%BA%20%E1%84%91%E1%85%A1%E1%86%AB%E1%84%87%E1%85%A7%E1%86%AF%E1%84%80%E1%85%B5(%E1%84%80%E1%85%A9%E1%84%89%E1%85%B5%E1%84%91%E1%85%B3%20%E1%84%91%E1%85%B3%E1%84%85%E1%85%A9%E1%84%8C%E1%85%A6%E1%86%A8%E1%84%90%E1%85%B3)%2013f2917e94dd4ec1878d1ee368bf6114/Untitled.png](%E1%84%90%E1%85%B5%E1%84%8F%E1%85%A6%E1%86%BA%20%E1%84%91%E1%85%A1%E1%86%AB%E1%84%87%E1%85%A7%E1%86%AF%E1%84%80%E1%85%B5(%E1%84%80%E1%85%A9%E1%84%89%E1%85%B5%E1%84%91%E1%85%B3%20%E1%84%91%E1%85%B3%E1%84%85%E1%85%A9%E1%84%8C%E1%85%A6%E1%86%A8%E1%84%90%E1%85%B3)%2013f2917e94dd4ec1878d1ee368bf6114/Untitled.png)

![%E1%84%90%E1%85%B5%E1%84%8F%E1%85%A6%E1%86%BA%20%E1%84%91%E1%85%A1%E1%86%AB%E1%84%87%E1%85%A7%E1%86%AF%E1%84%80%E1%85%B5(%E1%84%80%E1%85%A9%E1%84%89%E1%85%B5%E1%84%91%E1%85%B3%20%E1%84%91%E1%85%B3%E1%84%85%E1%85%A9%E1%84%8C%E1%85%A6%E1%86%A8%E1%84%90%E1%85%B3)%2013f2917e94dd4ec1878d1ee368bf6114/Untitled%201.png](%E1%84%90%E1%85%B5%E1%84%8F%E1%85%A6%E1%86%BA%20%E1%84%91%E1%85%A1%E1%86%AB%E1%84%87%E1%85%A7%E1%86%AF%E1%84%80%E1%85%B5(%E1%84%80%E1%85%A9%E1%84%89%E1%85%B5%E1%84%91%E1%85%B3%20%E1%84%91%E1%85%B3%E1%84%85%E1%85%A9%E1%84%8C%E1%85%A6%E1%86%A8%E1%84%90%E1%85%B3)%2013f2917e94dd4ec1878d1ee368bf6114/Untitled%201.png)

# Menu.cs 윈폼

---

![%E1%84%90%E1%85%B5%E1%84%8F%E1%85%A6%E1%86%BA%20%E1%84%91%E1%85%A1%E1%86%AB%E1%84%87%E1%85%A7%E1%86%AF%E1%84%80%E1%85%B5(%E1%84%80%E1%85%A9%E1%84%89%E1%85%B5%E1%84%91%E1%85%B3%20%E1%84%91%E1%85%B3%E1%84%85%E1%85%A9%E1%84%8C%E1%85%A6%E1%86%A8%E1%84%90%E1%85%B3)%2013f2917e94dd4ec1878d1ee368bf6114/Untitled%202.png](%E1%84%90%E1%85%B5%E1%84%8F%E1%85%A6%E1%86%BA%20%E1%84%91%E1%85%A1%E1%86%AB%E1%84%87%E1%85%A7%E1%86%AF%E1%84%80%E1%85%B5(%E1%84%80%E1%85%A9%E1%84%89%E1%85%B5%E1%84%91%E1%85%B3%20%E1%84%91%E1%85%B3%E1%84%85%E1%85%A9%E1%84%8C%E1%85%A6%E1%86%A8%E1%84%90%E1%85%B3)%2013f2917e94dd4ec1878d1ee368bf6114/Untitled%202.png)

- Manager 윈폼과 User윈폼으로 이동 할 수 있게 하는 윈폼

# Output.cs

```csharp
public interface outputMessage
    {
        void OutDialog(string msg);
    }
    public class Output: outputMessage
    {
        public void OutDialog(string msg)
        {
            MessageBox.Show(msg);
        }
	   }

    //인터페이스를 사용해서 MessageDIalog 만들기
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
```

- 인터페이스를 활용하여 출력하는 Dialog 기능
- Manager의 확인 버튼을 눌렀을 때 Dialog로 출력할 문자열을 처리해주는 기능

# Manager.cs 윈폼

---

![%E1%84%90%E1%85%B5%E1%84%8F%E1%85%A6%E1%86%BA%20%E1%84%91%E1%85%A1%E1%86%AB%E1%84%87%E1%85%A7%E1%86%AF%E1%84%80%E1%85%B5(%E1%84%80%E1%85%A9%E1%84%89%E1%85%B5%E1%84%91%E1%85%B3%20%E1%84%91%E1%85%B3%E1%84%85%E1%85%A9%E1%84%8C%E1%85%A6%E1%86%A8%E1%84%90%E1%85%B3)%2013f2917e94dd4ec1878d1ee368bf6114/Untitled%203.png](%E1%84%90%E1%85%B5%E1%84%8F%E1%85%A6%E1%86%BA%20%E1%84%91%E1%85%A1%E1%86%AB%E1%84%87%E1%85%A7%E1%86%AF%E1%84%80%E1%85%B5(%E1%84%80%E1%85%A9%E1%84%89%E1%85%B5%E1%84%91%E1%85%B3%20%E1%84%91%E1%85%B3%E1%84%85%E1%85%A9%E1%84%8C%E1%85%A6%E1%86%A8%E1%84%90%E1%85%B3)%2013f2917e94dd4ec1878d1ee368bf6114/Untitled%203.png)

- 각 TextBox 핸들 기능
- 확인 버튼을 눌렀을 땐 해당 정보의 값을 보여주는 이벤트 기능
- 완료 버튼을 눌렀을 떄 해당 정보를 Json파일로 보내주는 이벤트 기능

## Manager_information.cs

```csharp
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
```

- 각 변수를 프로퍼티로 받는다.
- type버튼을 눌렀을 땐 메소드를 사용하여 변수를 설정하고, 나머지 변수들은 TextBox 값을 가져와서 설정해준다

## Manager_Json.cs

- ReadJson 메소드와 ToDictionary 메소드

```csharp
public void ReadJson()
        {
            string jsonFilePath = @"";

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
```

- 완료 버튼을 누르면 ReadJson메소드를 먼저 돌리는데 json파일에 정보가 있을 때, 각 변수의 리스트의 값을 받아오고 저장함

```csharp

        public void ToDictionary(Information information)
        {
           
            string path = @"C:";
            
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
```

- 해당 메소드는 각 변수의 리스트에 저장되어있는 값들을 숫자 : {"변수" : "해당 값"} 의 형식으로 Json파일로 만들어준다

    ⇒ 다 만들었다면 Output 클래스를 이용해 Dialog를 출력함

# User.cs 윈폼

---

![%E1%84%90%E1%85%B5%E1%84%8F%E1%85%A6%E1%86%BA%20%E1%84%91%E1%85%A1%E1%86%AB%E1%84%87%E1%85%A7%E1%86%AF%E1%84%80%E1%85%B5(%E1%84%80%E1%85%A9%E1%84%89%E1%85%B5%E1%84%91%E1%85%B3%20%E1%84%91%E1%85%B3%E1%84%85%E1%85%A9%E1%84%8C%E1%85%A6%E1%86%A8%E1%84%90%E1%85%B3)%2013f2917e94dd4ec1878d1ee368bf6114/Untitled%204.png](%E1%84%90%E1%85%B5%E1%84%8F%E1%85%A6%E1%86%BA%20%E1%84%91%E1%85%A1%E1%86%AB%E1%84%87%E1%85%A7%E1%86%AF%E1%84%80%E1%85%B5(%E1%84%80%E1%85%A9%E1%84%89%E1%85%B5%E1%84%91%E1%85%B3%20%E1%84%91%E1%85%B3%E1%84%85%E1%85%A9%E1%84%8C%E1%85%A6%E1%86%A8%E1%84%90%E1%85%B3)%2013f2917e94dd4ec1878d1ee368bf6114/Untitled%204.png)

- 파일 열기 버튼 : User_imagefile.cs Open메소드를 실행
- 비교 결과 버튼 :  User_imagefile.cs Binary, Analysis메소드를 실행

# User_ImageFile.cs

- Open, Binary, Analysis 메소드가 있음

    ### Open 메소드

    - 파일을 열어 PictureBox에 해당이미지를 가져오는 메소드

    ### Binary 메소드

    - Open메소드를 통해 가져온 이미지의 픽셀마다 RGB값을 통해 흑과 백으로 나눠주는 메소드
    - int binary = (color.R + color.G + color.B) / 3;
    - 위의 값이 220정도일 때, 흑과 백의 분석이 잘 나오는 것 같아서 220을 기준으로 잡았다.

    ### Analysis 메소드

    ![%E1%84%90%E1%85%B5%E1%84%8F%E1%85%A6%E1%86%BA%20%E1%84%91%E1%85%A1%E1%86%AB%E1%84%87%E1%85%A7%E1%86%AF%E1%84%80%E1%85%B5(%E1%84%80%E1%85%A9%E1%84%89%E1%85%B5%E1%84%91%E1%85%B3%20%E1%84%91%E1%85%B3%E1%84%85%E1%85%A9%E1%84%8C%E1%85%A6%E1%86%A8%E1%84%90%E1%85%B3)%2013f2917e94dd4ec1878d1ee368bf6114/_.-001_(1).png](%E1%84%90%E1%85%B5%E1%84%8F%E1%85%A6%E1%86%BA%20%E1%84%91%E1%85%A1%E1%86%AB%E1%84%87%E1%85%A7%E1%86%AF%E1%84%80%E1%85%B5(%E1%84%80%E1%85%A9%E1%84%89%E1%85%B5%E1%84%91%E1%85%B3%20%E1%84%91%E1%85%B3%E1%84%85%E1%85%A9%E1%84%8C%E1%85%A6%E1%86%A8%E1%84%90%E1%85%B3)%2013f2917e94dd4ec1878d1ee368bf6114/_.-001_(1).png)

    - 이해를 돕기위한 티켓 형식

    ---

    ```csharp
    public void Analysis()
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
    ```

    - 바이너리화 시킨 이미지를 분석하는 메소드
    - 해당 메소드가 하는 기능
        1. Tesseract패키지를 이용해서 해당 사진을 분석한다.
        2. 분석한 데이터를 문자열로 받아와준다.
        3. 문자열을 수정해준다.
            1. 해당 문자열이 "\n"과 " "신경쓰지않고 다 받아내기 때문에 전체 문자열을 temp = Regex.Replace(temp, @"\s", ""); 로 다 이어준다.
            2. 그리곤 티켓의 타입을 구별해주는 "Movie, Museum, Baseball"의 문자가 있기 때문에 이를 @, #, *로 바꿔준다.
            3. 나머지 변수명도 " "로 바꿔준다.
        4. 티켓 형식에 맞춰서 해당 상속 클래스(User_Ticket.cs)를 만들어 주고 해당 클래스에 있는 Loading, InterVerification메소드를 호출한다.

# User_TIcket.cs

```csharp
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
```

- 추상클래스 이용 : Ticket이라는 클래스를 정의해주고 각 형식에 맞게 클래스를 상속시켜주었습니다.
- 위의 코드는 하나만 보여주지만 실제 코드는 Movie, Museum, Baseball 3개의 클래스를 만듬.

### Loding메소드

```csharp
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
```

- 분석해서 가져온 정보를 Dictionary형태로 바꿔주기위한 메소드
- 티켓 종류의 따라 형식은 같기 때문에 List와 foreach를 이용해서 로직을 구성해보았습니다.
- 리스트는 키값의 타입을 넣고 foreach로 반복문을 돌리면서 Dictionary에 넣어주는 형태입니다.

### Interimverification 메소드

- 분석한 것을 확인해주는 윈폼(Information_check.cs)을 호출하는 메소드
- 이때, Loading함수에서 만든 Dictionary를 전달해준다.

# User_DataComparison.cs

```csharp
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
```

- Json 파일에 정보들과 분석한 이미지의 정보를 비교해주는 클래스
- 각 형식의 맞게 3가지 메소드로 되어있다 (MovieDataComparison, MuseumDataComparison, BaseballDataComparison)
- 해당 티켓의 타입과 변수 모두다 맞는 정보가 있을 경우 output클래스를 이용해 진짜임을 출력시킨다

# Information_check.cs 윈폼

---

![%E1%84%90%E1%85%B5%E1%84%8F%E1%85%A6%E1%86%BA%20%E1%84%91%E1%85%A1%E1%86%AB%E1%84%87%E1%85%A7%E1%86%AF%E1%84%80%E1%85%B5(%E1%84%80%E1%85%A9%E1%84%89%E1%85%B5%E1%84%91%E1%85%B3%20%E1%84%91%E1%85%B3%E1%84%85%E1%85%A9%E1%84%8C%E1%85%A6%E1%86%A8%E1%84%90%E1%85%B3)%2013f2917e94dd4ec1878d1ee368bf6114/Untitled%205.png](%E1%84%90%E1%85%B5%E1%84%8F%E1%85%A6%E1%86%BA%20%E1%84%91%E1%85%A1%E1%86%AB%E1%84%87%E1%85%A7%E1%86%AF%E1%84%80%E1%85%B5(%E1%84%80%E1%85%A9%E1%84%89%E1%85%B5%E1%84%91%E1%85%B3%20%E1%84%91%E1%85%B3%E1%84%85%E1%85%A9%E1%84%8C%E1%85%A6%E1%86%A8%E1%84%90%E1%85%B3)%2013f2917e94dd4ec1878d1ee368bf6114/Untitled%205.png)

- 앞에서 분석한 티켓의 정보가 맞는지 확인해주는 윈폼클래스
- 확인 버튼을 눌렀을 때, DataComparison 클래스를 인스턴스화 시켜주어  해당 티켓 형식의 메소드로 맞게 처리해준다