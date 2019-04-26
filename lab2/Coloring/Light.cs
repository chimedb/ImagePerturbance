using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace lab2
{
    /// <summary>
    /// Class of the constant light
    /// </summary>
    public class Light
    {
        public Color LightColor { get; set; }
        public Vector Versor { get; set; }
        public Light()
        {
            LightColor = Color.White;
            Versor = new Vector(0, 0, 1);
        }
        public Light(Color color)
        {
            LightColor = color;
            Versor = new Vector(0, 0, 1);
        }
        public virtual Vector GetVersor(int x, int y)
        {
            return Versor;
        }
    }
}
