using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите градусы, минуты, секунды");
            int gradus_ = Convert.ToInt32(Console.ReadLine());
            int min_ = Convert.ToInt32(Console.ReadLine());
            int sec_ = Convert.ToInt32(Console.ReadLine());

            Angle angle = new Angle(gradus_, min_, sec_);
            double totalAngle = angle.ToRadians();
            Console.WriteLine(totalAngle);
            Console.ReadKey();
        }
    }
}
