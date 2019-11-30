using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        public static bool IsDetermined(double a, double b)
        {
            if (a != 0 && b != 0)
                return true;
            else
                return false;
        }
        public static bool IsInconsisted(double a)
        {
            if (a == 0)
                return true;
            else
                return false;
        }
        public static bool IsDegree2(double a)
        {
            if (a != 0 )
                return true;
            else
                return false;
        }
        public static double Delta(double a, double b, double c)
        {
            double delta;
            if (a == 0)
                return delta = double.NaN;
            else
            {
                delta = (b * b) - (4 * a * c);
                return delta;
            }  
        }
        public static string EquationDegree1(double a, double b)
        {
            if (a == 0 && b != 0)
            {
                return "Impossibile";
            }
            else if (a == 0 && b == 0)
            {
                return "Indeterminata";
            }
            string y;
            y = ((-b) / a).ToString();
            return y;
        }
        public static string EquationDegree2(double a, double b, double c)
        {
            string x1;
            string x2;
            double delta = Equazioni.Delta(a, b, c);
            if (b == 0 && c != 0)
            {
                x1 = ((Math.Sqrt(-c))/a).ToString();
                x2 = (-(Math.Sqrt(-c)) / a).ToString();
                return ($"x1 è {x1} e x2 è {x2}");
            }
            else if (b != 0 && c == 0)
            {
                x1 = 0.ToString();
                x2 = (-b / a).ToString();
                return($"x1 è {x1} e x2 è {x2}");
            }
            else if (a != 0 && b != 0 && c != 0)
            {
                if (delta > 0)
                {
                    x1 = (-b - Math.Sqrt(delta) / (2 * a)).ToString();
                    x2 = (-b + Math.Sqrt(delta) / (2 * a)).ToString();
                    return ($"x1 è {x1} e x2 è {x2}");
                }
                else if (delta == 0)
                {
                    x2 = x1 = (-b / (2 * a)).ToString();
                    return ($"x1 è {x1} e x2 è {x2}");
                }
                else if (delta < 0)
                {
                    return "Impossibile";
                }
            }
            return "";
        }
    }
}