using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RGBToCMYKConvertor.Bezier
{
    public class BezierControlPoint
    {
        public PointF position;
        public bool isSelected = false;
        public int r = 3;
        public bool isFirstOrLast = false;

        public BezierControlPoint(PointF pos)
        {
            this.position = pos;
        }

        public BezierControlPoint(string coordinates)
        {
            string[] numbers = coordinates.Split(',', ';');
            position.X = float.Parse(numbers[0]);
            position.Y = float.Parse(numbers[1]);
        }

        public void MoveTo(PointF newPosition)
        {
            if (newPosition.Y > 255) { newPosition.Y = 255; }
            if (newPosition.X > 255) { newPosition.X = 255; }
            if (isFirstOrLast)
            {
                newPosition.X = position.X;
            }
            position = newPosition;
        }

        public void Draw(Graphics g)
        {
            if (isSelected) g.FillEllipse(Brushes.Red, position.X - r, position.Y - r, 2 * r, 2 * r);
            else g.DrawEllipse(new Pen(Brushes.Black), position.X - r, position.Y - r, 2 * r, 2 * r);
        }

        public bool CheckIsInArea(PointF point)
        {
            if (((point.X >= position.X - r) && (point.X <= position.X + r))
                && ((point.Y >= position.Y - r) && (point.Y <= position.Y + r)))
            {
                return true;
            }
            return false;
        }
    }
}
