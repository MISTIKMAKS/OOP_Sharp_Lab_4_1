using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    class Angle
    {
        private int grades;
        private int minutes;
        public int GetGrades() 
        { 
            return grades; 
        }
        public int GetMinutes() 
        { 
            return minutes; 
        }

        public bool SetGrades(int grad)
        {
            if (grad < 0)
            {
                //grad = -grad;
                Console.WriteLine("Bad Input! Try Again!");
                return false;
            }
            grades = grad % 360;
            return true;
        }
        public bool SetMinutes(int min)
        {
            if (min < 0)
            {
                //min = -min;
                Console.WriteLine("Bad Input! Try Again!");
                return false;
            }
            int rest = min / 60;
            grades += rest;
            minutes = min % 60;
            return true;
        }
        public bool Init(int grad, int min)
        {
            return SetGrades(grad) && SetMinutes(min);
        }
        public void Read()
        {
            int grad;
            int min;
            do
            {
                Console.WriteLine("Grades: ");
                grad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Minutes: ");
                min = Convert.ToInt32(Console.ReadLine());
            } while (!Init(grad, min));
        }
        public void Display()
        {
            Console.WriteLine("Grades: " + grades);
            Console.WriteLine("Minutes: " + minutes);
        }

        public void Minus()
        {
            Console.WriteLine("Minus Operations: ");
            Console.WriteLine("Minus to Grades: ");
            int minus_grad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Minus to Minutes: ");
            int minus_min = Convert.ToInt32(Console.ReadLine());
            grades -= minus_grad;
            minutes -= minus_min;
            while(minutes < 0)
            {
                grades -= 1;
                minutes += 60;
            }
            SetGrades(grades);
            SetMinutes(minutes);
        }
        public void Plus()
        {
            Console.WriteLine("Plus Operations: ");
            Console.WriteLine("Plus to Grades: ");
            int plus_grad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Plus to Minutes: ");
            int plus_min = Convert.ToInt32(Console.ReadLine());
            grades += plus_grad;
            minutes += plus_min;
            while (minutes > 60)
            {
                grades += 1;
                minutes -= 60;
            }
            SetMinutes(minutes);
            SetGrades(grades);
        }

        public double Radian()
        {
            double radian = 0;
            double gradians = grades + (minutes / 60);
            radian = Math.Round(gradians * (Math.PI / 180), 2);
            return radian;
        }
        public double Sin()
        {
            double radian = 0;
            double sin = 0;
            double gradians = grades + (minutes / 60);
            radian = Math.Round(gradians * (Math.PI / 180), 2);
            sin = Math.Round(Math.Sin(radian), 2);
            return sin;
        }
    }
}
