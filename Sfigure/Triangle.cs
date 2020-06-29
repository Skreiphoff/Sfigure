using System;
using System.Collections.Generic;


namespace Sfigure
{
    public class Triangle
    {
        static protected bool Existence (double side_A, double side_B, double side_C)
        {
            List<double> list_side = new List<double> { side_A, side_B, side_C };
            list_side.Sort();
            list_side.Reverse();

            if (Math.Pow(list_side[0], 2) == Math.Pow(list_side[1], 2) + Math.Pow(list_side[2], 2))
                return true;
            else
                return false;
        }

        static protected string Erros()
        {
            string error = "длина стороны должна быть больше нуля";
            return error;

        }


        static public string Area(double side_A, double side_B, double side_C)
        {
            if (side_A > 0 && side_B > 0 && side_C > 0)
            {
                if (Existence(side_A, side_B, side_C))
                {
                    List<double> list_side = new List<double> { side_A, side_B, side_C };
                    list_side.Sort();
                    list_side.Reverse();
                    return (0.5 * list_side[1] * list_side[2]).ToString();
                }
                else
                {
                    double p = (side_A + side_B + side_C) / 2;
                    return (Math.Sqrt(p * (p - side_A) * (p - side_B) * (p - side_C))).ToString();
                }
            }
            else
            {
                return Erros();
            }
        }
    }
}
