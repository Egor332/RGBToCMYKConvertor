using RGBToCMYKConvertor.Bezier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGBToCMYKConvertor.DataManagers
{
    public class Transformer
    {
        public List<BezierControlPoint> ConvertStringsToControlPoints(List<string> source)
        {
            List<BezierControlPoint> pointList = new List<BezierControlPoint>();
            foreach (string line in source)
            {
                pointList.Add(new BezierControlPoint(line));
            }
            return pointList;
        }

        public string ConvertControlPointToString(List<BezierControlPoint> points)
        {
            StringBuilder sb = new StringBuilder();
            foreach (BezierControlPoint point in points)
            {
                sb.Append(point.position.X.ToString() + ", ");
                sb.Append(point.position.Y.ToString() + ", ");
                sb.Append("\n");
            }
            return sb.ToString();
        }

        public void SaveCurves(List<BezierCurve> curves, string filename)
        {
            List<BezierControlPoint> points = new List<BezierControlPoint>();
            foreach (BezierCurve curve in curves)
            {
                foreach (BezierControlPoint point in curve.bezierContorolPoints)
                {
                    points.Add(point);
                }
            }
            string pointsString = ConvertControlPointToString(points);
            Writer.WriteToFile(pointsString, filename);
        }

        public void LoadCurves(List<BezierCurve> curves, string filename)
        {
            int i = 0;
            List<string> pointStringList = Reader.ReadFromFile(filename);
            List<BezierControlPoint> pointsList = ConvertStringsToControlPoints(pointStringList);
            foreach (BezierCurve curve in curves)
            {
                List<BezierControlPoint> pointsForCurve = new List<BezierControlPoint> 
                { pointsList[i*4 + 0], pointsList[i*4 + 1], pointsList[i*4 + 2], pointsList[i*4 + 3] };
                i++;
                curve.ResetCurve(pointsForCurve);
            }
        }
    }
}
