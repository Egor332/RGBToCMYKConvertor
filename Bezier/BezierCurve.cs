using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGBToCMYKConvertor.Bezier
{
    public class BezierCurve
    {
        public BezierContorolPoint[] bezierContorolPoints;

        private Pen _pen;

        public BezierCurve(PointF[] givenPoints, Brush brush)
        {
            bezierContorolPoints = new BezierContorolPoint[4];
            _pen = new Pen(brush);
            
            for (int i = 0; i < 4; i++)
            {
                bezierContorolPoints[i] = new BezierContorolPoint(givenPoints[i]);
            }
            
        }

        public void DrawCurve(Graphics g)
        {
            g.DrawBezier(_pen, bezierContorolPoints[0].position, bezierContorolPoints[1].position, 
                bezierContorolPoints[2].position, bezierContorolPoints[3].position);
        }

        public void DrawControlPoints(Graphics g)
        {
            foreach (var point in bezierContorolPoints)
            {
                point.Draw(g);
            }
        }

        public BezierContorolPoint? CheckControlPointClicked(PointF p)
        {
            BezierContorolPoint? contorolPoint = null;
            if (bezierContorolPoints[1].CheckIsInArea(p))
            {
                contorolPoint = bezierContorolPoints[1];
            }
            if (bezierContorolPoints[2].CheckIsInArea(p))
            {
                contorolPoint = bezierContorolPoints[2];
            }
            return contorolPoint;
        }
    }
}
