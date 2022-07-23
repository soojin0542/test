using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220723
{
    class Program
    {
        //enum(열거형)은 main 밖에서 해야한다.
        enum COLOR { BLACK, RED=3, WHITE }; 
        //             0     1       2
        //RED=3일때    0     3       4
        static void Main(string[] args)
        {
            //enum 열거형이름 {}
            //가독성이 좋아진다
            Console.WriteLine((int)COLOR.BLACK);
            Console.WriteLine((int)COLOR.RED);
            Console.WriteLine((int)COLOR.WHITE);

            //int, float, double, long, short, char
            int num = 1; //어떤 수를 대입하면 초기화된다.
            Console.WriteLine(num);

            /*int a = 10;
            int b = 20;
            int c = 30;
            //사라지는 순서 c-b-a*/

            //데이터 타입
            //byte = 1byte
            //sbyte(signed byte) = 1byte
            //short = 2byte
            //ushort(부호가 없음) = 2byte
            //int = 4byte
            //uint(부호가 없음) = 4byte
            //long = 8byte
            //ulong(부호가 없음) = 8byte
            //char = 2byte

            /*sbyte a = -10;
            sbyte b = 40;
            Console.WriteLine("a = {0}, b = {1}", a, b);

            short c = -30000;
            ushort d = 60000;
            Console.WriteLine(c);
            Console.WriteLine(d);

            uint number = uint.MaxValue;
            Console.WriteLine(number); //4294967295
            Console.WriteLine(number+1); //0, 최댓값에 1을 더하면 오버플로우 됨*/

            /*object a = 123;
            object b = 3.1415f;
            object c = true;
            object d = "안녕하세요";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            //object 타입은 모든 데이터형식을 담을 수 있음
            //기본 데이터 뿐만 아니라 프로그래머들이 만드는 데이터형식도 담을 수 있다.*/

            const int MAX_INT = 1234; //const(상수)는 선언과 동시에 초기화를 해야한다.
                                      //초기화를 안하면 에러가 난다.
            Console.WriteLine(MAX_INT);


            var vVariable = 10;     //int
            var str = "hello";      //string
            //var은 자동으로 타입을 추론한다.
            //지역변수로만 사용할 수 있다.

            /*int a = 10;

            //a++ => 연산자를 뒤에 사용(후위연산)
            //해당 문장의 실행이 끝난 후에 변수의 값 변경
            Console.WriteLine(a++); //10

            //++a => 변수의 앞에 사용(전위연산)
            //변수의 값을 변경한 후에 해당 문장이 실행
            Console.WriteLine(++a); //12*/

            //컴퓨터는 나눗셈보다 곱셈이 빠르다.
            //그러므로 10/2 보다는 10*0.5가 더 빨리 계산된다.

            //  0   0   0   0        0   0   0   0     0   0   0   0
            //2048 1024 512 256     128  64  32 16     8   4   2   1

            int shift_a = 240;
            int result = shift_a << 2;  //옮길 비트 수

            int age = 10;
            //동작 조건은 true


            if (age < 20) {
                Console.WriteLine("1첫번째 if문 실행\n");
            }
            else if (age < 30)
            {
                Console.WriteLine("1두번째 if문 실행\n");
            }
            if (age < 40)
            {
                Console.WriteLine("1세번째 if문 실행\n");
            }
            //첫번째, 세번째 if문 실행


            if (age < 20)
            {
                Console.WriteLine("2첫번째 if문 실행\n");
            }
            if (age < 30)
            {
                Console.WriteLine("2두번째 if문 실행\n");
            }
            if (age < 40)
            {
                Console.WriteLine("2세번째 if문 실행\n");
            }
            //첫번째, 두번째, 세번째 if문 실행


            age = 31;
            if (age < 20)
            {
                Console.WriteLine("3첫번째 if문 실행\n");
            }
            else if (age < 31)
            {
                Console.WriteLine("3두번째 if문 실행\n");
            }
            else if (age < 40)
            {
                Console.WriteLine("3세번째 if문 실행\n");
            }
            //세번째 if문 실행


            int test = 20;
            if ((test % 2) == 0)
            {
                Console.WriteLine("짝수\n");
            }
            else
            {
                Console.WriteLine("홀수\n");
            }

            /*if ((test % 2) != 0)
            {
                Console.WriteLine("홀수");
            }*/



            //Console.WriteLine()   문자열 입력을 받아 출력한다   (print)
            //Console.ReadLine()    문자열 입력을 받아 반환한다.  (scanf)
            /*Console.WriteLine("숫자를 입력하세요 : ");

            string input = Console.ReadLine();
            int number = Int32.Parse(input); 
            //parse는 string을 int형으로 변환하는 것이다

            if (number < 0) Console.WriteLine("음수");
            else if (number > 0) Console.WriteLine("양수");
            else Console.WriteLine("0");

            if (number % 2 == 0) Console.WriteLine("짝수");
            else Console.WriteLine("홀수");*/


            /*if (number > 0)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("0보다 큰 짝수");
                }
                else
                {
                    Console.WriteLine("0보다 큰 홀수");
                }
            }
            else
            {
                Console.WriteLine("0보다 작거나 같은 수");
            }*/


            /*switch (조건식)
            {
                case 1: 상수(정수나 문자열):    //if
                    //여기에 실행 코드
                    break;
                case 2:
                    상수(정수나 문자열):        //else if
                    //여기에 실행 코드
                    break;
                default:                        //else
                    break;
            }*/

            int number = 1;
            switch (number)
            {
                case 1: Console.WriteLine("하나\n");
                    break;
                case 2:
                    Console.WriteLine("둘\n");
                    break;
                case 3:
                    Console.WriteLine("셋\n");
                    break;
                default:
                    break;
            }

            //요일을 String으로
            //input 월  output monday
            string input = Console.ReadLine();

            switch (input)
            {
                case "월":
                    Console.WriteLine("Monday");
                    break;
                case "화":
                    Console.WriteLine("Tuesday");
                    break;
                case "수":
                    Console.WriteLine("Wednesday");
                    break;
                case "목":
                    Console.WriteLine("Thursday");
                    break;
                case "금":
                    Console.WriteLine("Friday");
                    break;
                case "토":
                    Console.WriteLine("Saturday");
                    break;
                case "일":
                    Console.WriteLine("Sunday");
                    break;
                default:
                    break;
            }
        }
    }
}