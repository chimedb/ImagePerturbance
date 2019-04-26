using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace lab2
{
    /// <summary>
    /// Class of the coloring properties of the triangle
    /// </summary>
    public class Coloring
    {
        private string texture_path;
        public enum ColoringStyle
        {
            Solid,
            Texture
        }
        public string TexturePath
        {
            get { return texture_path; }
            set
            {
                try
                {
                    texture_path = value;
                    Texture = new Bitmap(texture_path);
                }
                catch
                {
                    texture_path = string.Empty;
                    Texture = null;
                }
            }
        }
        public ColoringStyle color_style { get; set; }
        public Color current_color { get; set; }
        public Bitmap Texture { get; set; }
        public int Xoffset { get; set; }
        public int Yoffset { get; set; }
        public Coloring(int Xoffset, int Yoffset, string TexturePath)
        {
            this.TexturePath = TexturePath;
            this.Xoffset = Xoffset;
            this.Yoffset = Yoffset;
            color_style = ColoringStyle.Texture;
            current_color = Color.White;
        }
        /// <summary>
        /// Colors a pixel at (x, y)
        /// </summary>
        /// <param name="g"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="light"></param>
        /// <param name="normal"></param>
        /// <param name="perturbance"></param>
        /// <param name="coefficient"></param>
        public void ColorPixel(Graphics g, int x, int y, Light light, Vector normal, Vector perturbance, double coefficient)
        {
            Vector N = normal.GetVestorForPoint(x, y);
            Vector D = perturbance.GetVestorForPoint(x, y, N) * coefficient;
            Vector L = light.GetVersor(x, y); // normalized direction to light source
            Vector NSN = (N + D).Versor; // normalized surface normal
            double cos = NSN.Cosinus(L);
            if (cos < 0) cos = 0;
            Color color = current_color;
            if (color_style == ColoringStyle.Texture && Texture != null)
            {
                color = Texture.GetPixel((x - Xoffset + Texture.Width) % Texture.Width, (y - Yoffset + Texture.Height) % Texture.Height);
            }
            int R = (int)(color.R * light.LightColor.R / 255 * cos);
            int G = (int)(color.G * light.LightColor.G / 255 * cos);
            int B = (int)(color.B * light.LightColor.B / 255 * cos);
            if (R < 0) R = 0;
            if (R > 255) R = 255;
            if (G < 0) G = 0;
            if (G > 255) G = 255;
            if (B < 0) B = 0;
            if (B > 255) B = 255;
            Brush b = new SolidBrush(Color.FromArgb(R, G, B));
            g.FillRectangle(b, x, y, 1, 1);
        }
    }
}
