using System;


namespace Sfigure
{
    public class Circle
    {
        static public string Area(double radius)
        {
            if(radius>=0)
            {
                return (Math.PI * Math.Pow(radius, 2)).ToString();
            }
            else
            {
                return Errors();
            }
        }

        static protected string Errors(){
            string error = "Ошибка, радиус должен быть больше, либо равен нулю";
            return error;
        }
    }
}
