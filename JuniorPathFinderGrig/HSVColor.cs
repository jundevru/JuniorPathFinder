using System;
using System.Drawing;
using JuniorPathFinderCore;

namespace JuniorPathFinderGrig
{
    public class HSVColor
    {
        /// <summary>
        /// Компонента h 0...1
        /// </summary>
        public float h = 1.0f;
        /// <summary>
        /// Компонента s 0...1
        /// </summary>
        public float s = 1.0f;
        /// <summary>
        /// Компонента v 0...1
        /// </summary>
        public float v = 1.0f;

        public HSVColor(float h, float s, float v)
        {
            this.h = h;
            this.s = s;
            this.v = v;
        }


        /// <summary>
        /// Возвращает цвет в формате System.Drawing.Color по индексу слоя
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static Color GetRGBColor(Layers layer)
        {
            return GetRGBColor(new HSVColor((float)layer / 31, ((int)layer % 2 != 0) ? 1.0f : 0.5f, 1.0f));
        }

        private static Color GetRGBColor(HSVColor color)
        {
            float hh = color.h * 360;
            float ss = color.s;
            float vv = color.v;

            double H = hh;
            while (H < 0) { H += 360; };
            while (H >= 360) { H -= 360; };
            double R, G, B;
            if (vv <= 0)
            { R = G = B = 0; }
            else if (ss <= 0)
            {
                R = G = B = vv;
            }
            else
            {
                double hf = H / 60.0;
                int i = (int)Math.Floor(hf);
                double f = hf - i;
                double pv = vv * (1 - ss);
                double qv = vv * (1 - ss * f);
                double tv = vv * (1 - ss * (1 - f));
                switch (i)
                {

                    // Red is the dominant color

                    case 0:
                        R = vv;
                        G = tv;
                        B = pv;
                        break;

                    // Green is the dominant color

                    case 1:
                        R = qv;
                        G = vv;
                        B = pv;
                        break;
                    case 2:
                        R = pv;
                        G = vv;
                        B = tv;
                        break;

                    // Blue is the dominant color

                    case 3:
                        R = pv;
                        G = qv;
                        B = vv;
                        break;
                    case 4:
                        R = tv;
                        G = pv;
                        B = vv;
                        break;

                    // Red is the dominant color

                    case 5:
                        R = vv;
                        G = pv;
                        B = qv;
                        break;

                    // Just in case we overshoot on our math by a little, we put these here. Since its a switch it won't slow us down at all to put these here.

                    case 6:
                        R = vv;
                        G = tv;
                        B = pv;
                        break;
                    case -1:
                        R = vv;
                        G = pv;
                        B = qv;
                        break;

                    // The color is not defined, we should throw an error.

                    default:
                        //LFATAL("i Value error in Pixel conversion, Value is %d", i);
                        R = G = B = vv; // Just pretend its black/white
                        break;
                }
            }
            int r = Clamp((int)(R * 255.0));
            int g = Clamp((int)(G * 255.0));
            int b = Clamp((int)(B * 255.0));
            return Color.FromArgb(255, r, g, b);
        }
        static int Clamp(int i)
        {
            if (i < 0) return 0;
            if (i > 255) return 255;
            return i;
        }

    }
}
