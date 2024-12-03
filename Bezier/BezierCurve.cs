﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RGBToCMYKConvertor.Bezier
{
    public class BezierCurve
    {
        public BezierContorolPoint[] bezierContorolPoints;

        private Pen _pen;

        public float[] yValues; 

        public BezierCurve(PointF[] givenPoints, Brush brush)
        {
            bezierContorolPoints = new BezierContorolPoint[4];
            _pen = new Pen(brush);
            
            for (int i = 0; i < 4; i++)
            {
                bezierContorolPoints[i] = new BezierContorolPoint(givenPoints[i]);
            }
            bezierContorolPoints[0].isFirstOrLast = true;
            bezierContorolPoints[3].isFirstOrLast = true;
            yValues = new float[256];
        }

        public void DrawCurve(Graphics g)
        {
            g.DrawBezier(_pen, bezierContorolPoints[0].position, bezierContorolPoints[1].position, 
                bezierContorolPoints[2].position, bezierContorolPoints[3].position);
            OverwriteYTable(g);
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
            foreach(var controlPoint in bezierContorolPoints)
            {
                if (controlPoint.CheckIsInArea(p)) return controlPoint;
            }

            return null;
        }

        public void OverwriteYTable(Graphics g)
        {
            int ind = 0;
            for (float targetX = 0f; targetX < 1f; targetX += 1f/255f)
            {
                float tLow = 0f;
                float tHigh = 1f;
                float t = 0f;
                float x = 0;
                for (int i = 0; i < 1000; i++)
                {
                    t = (tLow + tHigh) / 2;
                    x = 0f;
                    float[] bernstain3 = GetBrenstein3(t);
                    for (int j = 0; j < 4; j++)
                    {
                        x += bezierContorolPoints[j].position.X * bernstain3[j];
                    }

                    if (Math.Abs(x - targetX) < 0.0001f) break;

                    if (x < targetX) tLow = t;
                    else tHigh = t;
                }

                float y = 0;
                float[] bernstain3Y = GetBrenstein3(t);
                for (int k = 0; k < 4; k++)
                {
                    y += bezierContorolPoints[k].position.Y * bernstain3Y[k];
                }
                yValues[ind] = y;
                g.FillEllipse(new SolidBrush(Color.Green), x*385, y*385, 2, 2);
            }

        }


        public static float[] GetBrenstein3(float t)
        {
            float[] brenstein3 = new float[4];
            brenstein3[0] = (float)Math.Pow(1 - t, 3);
            brenstein3[1] = ((float)Math.Pow(1 - t, 2)) * 3 * t;
            brenstein3[2] = 3 * (1 - t) * t * t;
            brenstein3[3] = t * t * t;
            return brenstein3;
        }   
    }
}
