/*
Problem 4. Rectangles

Write an expression that calculates rectangle’s perimeter and area by given width and height. 
*/

using System;

namespace Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, type the width of the redtange.");
            float w = float.Parse(Console.ReadLine());

            Console.WriteLine("Please, type the lenght of the rectangle.");
            float l = float.Parse(Console.ReadLine());

            float area = w * l;
            float perimeter = w * 2 + l * 2;

            Console.WriteLine("The area of the rectangle is {0} ", area);
            Console.WriteLine("The perimeter of the rectangle is {0} ", perimeter);
        }
    }
}
