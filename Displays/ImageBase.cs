using RGBToCMYKConvertor.Bezier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.Pkcs;
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

        public ImageBase(Dictionary<string, BezierCurve> cur, int width, int height)
        {
            curves = cur;
            original = new Bitmap(width, height);
            generateBitmap(original);
            cyan = new Bitmap(original.Width, original.Height);
            magenta = new Bitmap(original.Width, original.Height);
            yellow = new Bitmap(original.Width, original.Height);
            black = new Bitmap(original.Width, original.Height);
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

        private Color HSV2RGB(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0)
                return Color.FromArgb(255, v, t, p);
            else if (hi == 1)
                return Color.FromArgb(255, q, v, p);
            else if (hi == 2)
                return Color.FromArgb(255, p, v, t);
            else if (hi == 3)
                return Color.FromArgb(255, p, q, v);
            else if (hi == 4)
                return Color.FromArgb(255, t, p, v);
            else
                return Color.FromArgb(255, v, p, q);
        }

        public void SaveAll(string selectedPath)
        {
            string original = System.IO.Path.Combine(selectedPath, "original.jpg");
            string cyan = System.IO.Path.Combine(selectedPath, "cyan.jpg");
            string magenta = System.IO.Path.Combine(selectedPath, "magenta.jpg");
            string yellow = System.IO.Path.Combine(selectedPath, "yellow.jpg");
            string black = System.IO.Path.Combine(selectedPath, "black.jpg");
            this.original.Save(original);
            this.cyan.Save(cyan);
            this.magenta.Save(magenta);
            this.yellow.Save(yellow);
            this.black.Save(black);
        }

        private void generateBitmap(Bitmap b)
        {
            int h = b.Height;
            int w = b.Width;

            for (int j = 0; j < w; j++)
            {
                for (int k = 0; k < h; k++)
                {
                    b.SetPixel(j, k, Color.White);
                }
            }

            int columnWidth = 20;
            int i = 0;
            while (i < w/2)
            {
                for (int j = 0; j < columnWidth; j++)
                {
                    for (int k = 0; k < h; k++) 
                    {
                        b.SetPixel(i + j, k, Color.FromArgb(0, 0, 0));
                    }
                }
                i += 2 * columnWidth;
                columnWidth--;
            }

            for (int j = w/2; j < w; j++)
            {
                for (int k = 0; k < h; k++)
                {
                    b.SetPixel(j, k, HSV2RGB(360 * (j - w / 2) / (w / 2), ((double)1 - ((double)k / (double)h)), 1));
                }
            }



        }
        
    }
}
