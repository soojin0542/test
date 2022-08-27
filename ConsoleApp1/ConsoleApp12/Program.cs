using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        enum DAY_OF_WEEK
        {
            SUN,
            MON,
            THE,
            WED,
            THU,
            FRI,
            SAT,
        }
        static void Main(string[] args)
        {
            DAY_OF_WEEK DayofWeek = DAY_OF_WEEK.FRI;
            string dayString = "";

            switch (DayofWeek)
            {
                case DAY_OF_WEEK.SUN:
                    dayString = "일";
                    break;
                case DAY_OF_WEEK.MON:
                    dayString = "월";
                    break;
                case DAY_OF_WEEK.THE:
                    dayString = "화";
                    break;
                case DAY_OF_WEEK.WED:
                    dayString = "수";
                    break;
                case DAY_OF_WEEK.THU:
                    dayString = "목";
                    break;
                case DAY_OF_WEEK.FRI:
                    dayString = "금";
                    break;
                case DAY_OF_WEEK.SAT:
                    dayString = "토";
                    break;
                default:
                    break;
            }
            Console.WriteLine("{0}요일 입니다.", dayString);
        }
    }
}
