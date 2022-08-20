using System;

namespace ConsoleApp2
{
    class Program1
    {
        static void Main(string[] args)
        {
            /*
            long max = long.MaxValue;
            long min = long.MinValue;
            Console.WriteLine("writeline"); //자동으로 줄바꾸기가 됨
            Console.Write("write");         //줄바꾸기를 하지 않음
            Console.Write("\n");            //줄바꾸기
            Console.WriteLine("long max : {0}, long min : {1}\n", max, min);
            //long값의 최댓값과 최솟값 구하기

            char a = 'A';   //작은 따옴표는 문자, 큰 따옴표는 문자열일때 사용
            int num = a;
            Console.WriteLine("문자 : {0} 아스키코드값 : {1} 문자로 캐스트 연산 {2}\n", a ,num, (char)num);
            */

            /*
            string str1 = "abcdefg";
            string str2 = "hijklmn";
            string str3 = str1 + str2;
            Console.WriteLine("str1 + str2 = {0}", str3);

            string str4 = "zzz";
            string str5 = "zzz";
            Console.WriteLine("str4 == str5 {0}\n", str4 == str5);

            string str7 = "Hello World!";
            string str8 = str7.Replace("Hello", "Hi");
            Console.WriteLine("str8 : {0}\n", str8);

            Console.WriteLine("str8.ToUpper(): {0}", str8.ToUpper());
            Console.WriteLine("str8.ToLower(): {0}\n", str8.ToLower());


            CHAR_STATE charstate = CHAR_STATE.IDLE;
            Console.WriteLine("캐릭터 상태 : {0} {1}", charstate, (int)charstate);
            charstate = CHAR_STATE.RUN;
            Console.WriteLine("캐릭터 상태 : {0} {1}", charstate, (int)charstate);
            charstate = CHAR_STATE.DIE;
            Console.WriteLine("캐릭터 상태 : {0} {1}", charstate, (int)charstate);

            Console.WriteLine("클릭 상태 : {0} {1}", CLICK_STATE.NONE, (int)CLICK_STATE.NONE);
            Console.WriteLine("클릭 상태 : {0} {1}", CLICK_STATE.CLICK, (int)CLICK_STATE.CLICK);
            Console.WriteLine("클릭 상태 : {0} {1}", CLICK_STATE.DOUBLE_CLICK, (int)CLICK_STATE.DOUBLE_CLICK);
            Console.WriteLine("캐릭터 상태 : {0} {1}", CLICK_STATE.UP, (int)CLICK_STATE.UP);
            */

            /*
            //var형식
            //변수에 넣은 식에 따라 형식이 바뀜
            var a = 100;
            var b = 3.141592;
            var c = 'a';
            var d = "world";

            Console.WriteLine("type : {0}, a : {1}", a.GetType(), a);
            Console.WriteLine("type : {0}, b : {1}", b.GetType(), b);
            Console.WriteLine("type : {0}, c : {1}", c.GetType(), c);
            Console.WriteLine("type : {0}, d : {1}\n", d.GetType(), d);
            */

            /*
            int a = 100;
            string strA = a.ToString(); //int형을 string식으로 변환해 string에 넣음
            Console.WriteLine("a.ToString() : {0}", strA);
            */

            /*
            //입력받기
            Console.WriteLine("정수를 입력하세요");
            string inputNum = Console.ReadLine();
            int num = int.Parse(inputNum);
            Console.WriteLine("입력한 수는 : " + num);
            */

            //var형식 응용
            var a = 100;
            var b = "AAA";
            var c = 0.123;
            var d = 'A';

            Console.WriteLine("a : {0}, a.GetType() : {1}", a, a.GetType());
            Console.WriteLine("b : {0}, b.GetType() : {1}", b, b.GetType());
            Console.WriteLine("c : {0}, c.GetType() : {1}", c, c.GetType());
            Console.WriteLine("d : {0}, d.GetType() : {1}", d, d.GetType());

            //입력 응용
            Console.Write("국어 점수를 입력하세요");
            int korean = int.Parse(Console.ReadLine());
            Console.Write("영어 점수를 입력하세요");
            int English = int.Parse(Console.ReadLine());
            Console.Write("수학 점수를 입력하세요");
            int mess = int.Parse(Console.ReadLine());
            Console.Write("과학 점수를 입력하세요");
            int korean = int.Parse(Console.ReadLine());
        }
    }
}
