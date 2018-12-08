using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80, 25);
            Console.SetWindowSize(80, 25);

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine dnLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine lftLine = new VerticalLine(0, 0, 24, '+');
            VerticalLine rgtLine = new VerticalLine(78, 0, 24, '+');

            upLine.Draw();
            dnLine.Draw();
            lftLine.Draw();
            rgtLine.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Directions.RIGHT);
            snake.Draw();
            snake.Move();
            
            Console.ReadLine();
        }
        
    }
}
