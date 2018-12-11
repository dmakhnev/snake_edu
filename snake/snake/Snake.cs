using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Snake:Figure
    {
        Directions direction;

        public Snake(Point tail, int lenght, Directions _direction)
        {
            direction = _direction;

            pList = new List<Point>();

            for(int i=0; i<lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);

            return (nextPoint);
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Directions.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Directions.RIGHT;
            else if (key == ConsoleKey.UpArrow)
                direction = Directions.UP;
            else if (key == ConsoleKey.DownArrow)
                direction = Directions.DOWN;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();

            if (head.IsHeat(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return (true);
            }
            else
            {
                return (false);
            }            
        }
    }
}
