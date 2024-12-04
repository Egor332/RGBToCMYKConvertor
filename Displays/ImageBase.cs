using RGBToCMYKConvertor.Bezier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RGBToCMYKConvertor.Displays
{
    public class ImageBase
    {
        public Bitmap original;
        public Bitmap cyan;
        public Bitmap magenta;
        public Bitmap yellow;
        public Bitmap black;
        public Dictionary<string, BezierCurve> curves;

        public ImageBase(string path, Dictionary<string, BezierCurve> cur)
        {
            original = new Bitmap(path);
            cyan = new Bitmap(original.Width, original.Height);
            magenta = new Bitmap(original.Width, original.Height);
            yellow = new Bitmap(original.Width, original.Height);
            black = new Bitmap(original.Width, original.Height);
            curves = cur;
            ResetBitmaps();
        }

        public void ResetBitmaps()
        {
            for (int i = 0; i < original.Height; i++)
            {
                for (int j = 0; j < original.Width; j++)
                {
                    ResetPixel(i, j);
                }
            }
        }

        private void ResetPixel(int i, int j)
        {
            Color originalColor = original.GetPixel(j, i);
            Vector4 cmykColor;
            cmykColor.X = 1f - (float)originalColor.R / 255f;
            cmykColor.Y = 1f - (float)originalColor.G / 255f;
            cmykColor.Z = 1f - (float)originalColor.B / 255f;
            if (cmykColor.X > cmykColor.Y)
            {
                cmykColor.W = (cmykColor.Y > cmykColor.Z ) ? cmykColor.Z : cmykColor.Y;
            }
            else
            {
                cmykColor.W = (cmykColor.X > cmykColor.Z) ? cmykColor.Z : cmykColor.X;
            }
            cmykColor = RecountCMYK(cmykColor);

            Vector4 cmykCyan = new Vector4(cmykColor.X, 0, 0, 0);
            Vector4 cmykMagenta = new Vector4(0, cmykColor.Y, 0, 0);
            Vector4 cmykYellow = new Vector4(0, 0, cmykColor.Z, 0);
            Vector4 cmykBlack = new Vector4(0, 0, 0, cmykColor.W);

            cyan.SetPixel(j, i, CMYK2RGB(cmykCyan));
            magenta.SetPixel(j, i, CMYK2RGB(cmykMagenta));
            yellow.SetPixel(j, i, CMYK2RGB(cmykYellow));
            black.SetPixel(j, i, CMYK2RGB(cmykBlack));
        }

        private Vector4 RecountCMYK(Vector4 cmyk)
        {
            Vector4 newCMYK = cmyk;
            int indK = (int)Math.Round((double)(cmyk.W * 255));
            newCMYK.X = cmyk.X - cmyk.W + (curves["Cyan"].yValues[indK] / 255f);
            newCMYK.Y = cmyk.Y - cmyk.W + (curves["Magenta"].yValues[indK] / 255f);
            newCMYK.Z = cmyk.Z - cmyk.W + (curves["Yellow"].yValues[indK] / 255f);
            newCMYK.W = curves["Black"].yValues[indK] / 255f;
            return newCMYK;
        }

        private Color CMYK2RGB(Vector4 cmyk)
        {
            cmyk.X = cmyk.X > 1 ? 1 : cmyk.X;
            cmyk.Y = cmyk.Y > 1 ? 1 : cmyk.Y;
            cmyk.Z = cmyk.Z > 1 ? 1 : cmyk.Z;
            cmyk.W = cmyk.W > 1 ? 1 : cmyk.W;
            Color rgb = Color.FromArgb((int)(255 * (1 - cmyk.X) * (1 - cmyk.W)),
                (int)(255 * (1 - cmyk.Y) * (1 - cmyk.W)),
                (int)(255 * (1 - cmyk.Z) * (1 - cmyk.W)));
            return rgb;

        }
        
    }
}
