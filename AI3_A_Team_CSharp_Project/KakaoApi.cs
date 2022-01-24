using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace AI3_A_Team_CSharp_Project
{
    public class KakaoApi
    {
        public static List<Book> Search(string qstr)
        {
            List<Book> books = new List<Book>();//리스트 만들기

            string site = "https://dapi.kakao.com/v3/search/book"; //사이트 주소
            string query = $"{site}?target=title&query={qstr}&size=20";//20개씩 가져오기
            WebRequest request = WebRequest.Create(query);

            string rkey = "";
            string header = "KakaoAK " + rkey;
            request.Headers.Add("Authorization", header);// 헤더에 옵션값 추가

            WebResponse response = request.GetResponse(); //WebRequest 개체의 GetResponse 메서드를 호출해서 보낸데이터를 기반으로 받기
            Stream stream = response.GetResponseStream();// 받은 데이터를 스트림으로 쓴다
            StreamReader reader = new StreamReader(stream, Encoding.UTF8); // 스트림을 읽기 위해 리더를 오픈
            string json = reader.ReadToEnd(); // 스트림의 내용을 읽어서 문자열로 반환

            JavaScriptSerializer js = new JavaScriptSerializer(); // JSON 문자열을 다시 .NET 객체로 복원하기 위해서 JavaScriptSerializer 의 Deserialize 메서드를 사용
            dynamic dob = js.Deserialize<dynamic>(json);
            dynamic docs = dob["documents"];
            object[] buf = docs;
            int length = buf.Length;

            for(int i = 0; i < length; i++)
            {
                string title = docs[i]["title"];
                string authors = docs[i]["authors"][0];
                string publisher = docs[i]["publisher"];
                string contents = docs[i]["contents"];
                books.Add(new Book(title, authors, publisher, contents));

            }
            return books;


        }
        

    }
}
