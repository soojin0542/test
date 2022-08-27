using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            string strGrade = null;

            Console.WriteLine("점수를 입력하세요 : ");
            num = int.Parse(Console.ReadLine());

            switch (num / 10)
            {
                case 10:
                case 9:
                    strGrade = "A";
                    break;
                //위 case 값을 안넣으면 아래 case 값이 출력됨
                //case 10과 9의 결과는 같음
                case 8:
                    strGrade = "B";
                    break;
                case 7:
                    strGrade = "C";
                    break;
                case 6:
                    strGrade = "D";
                    break;
                case 5:
                    strGrade = "F";
                    break;
            }
            Console.Write("결과값은 {0}", strGrade);
        }
    }
}
