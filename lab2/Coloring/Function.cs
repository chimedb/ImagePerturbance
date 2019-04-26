using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static lab2.Form1;

namespace lab2
{
    /// <summary>
    /// Class of the functions to color the triangles
    /// </summary>
    static class Function
    {
        /// <summary>
        /// Colors a triangle using scan line algorithm
        /// </summary>
        /// <param name="tr"></param>
        /// <param name="g"></param>
        /// <param name="light"></param>
        /// <param name="normal"></param>
        /// <param name="perturbance"></param>
        /// <param name="coefficient"></param>
        public static void ColorTriangle(Triangle tr, Graphics g, Light light, Vector normal, Vector perturbance, double coefficient)
        {
            Vertex[] vertices = tr.vertices.ToArray();
            Array.Sort(vertices, delegate (Vertex v1, Vertex v2) {
                return v1.Y.CompareTo(v2.Y);
            });
            double AX = vertices[0].X, AY = vertices[0].Y;
            double BX = vertices[1].X, BY = vertices[1].Y;
            double CX = vertices[2].X, CY = vertices[2].Y;
            double dx1 = 0, dx2 = 0, dx3 = 0;
            if (BY - AY > 0) dx1 = (BX - AX) / (BY - AY);
            if (CY - AY > 0) dx2 = (CX - AX) / (CY - AY);
            if (CY - BY > 0) dx3 = (CX - BX) / (CY - BY);
            double SX = AX, SY = AY, EX = AX, EY = AY;
            if (dx1 > dx2)
            {
                for (; SY <= BY; SY++, EY++, SX += dx2, EX += dx1)
                {
                    for (double i = SX; i <= EX; i++)
                    {
                        tr.Cover.ColorPixel(g, (int)i, (int)SY, light, normal, perturbance, coefficient);
                    }
                }
                EX = BX;
                EY = BY;
                for (; SY <= CY; SY++, EY++, SX += dx2, EX += dx3)
                {
                    for (double i = SX; i <= EX; i++)
                    {
                        tr.Cover.ColorPixel(g, (int)i, (int)SY, light, normal, perturbance, coefficient);
                    }
                }
            }
            else
            {
                for (; SY <= BY; SY++, EY++, SX += dx1, EX += dx2)
                {
                    for (double i = SX; i <= EX; i++)
                    {
                        tr.Cover.ColorPixel(g, (int)i, (int)SY, light, normal, perturbance, coefficient);
                    }
                }
                SX = BX;
                SY = BY;
                for (; SY <= CY; SY++, EY++, SX += dx3, EX += dx2)
                {
                    for (double i = SX; i <= EX; i++)
                    {
                        tr.Cover.ColorPixel(g, (int)i, (int)SY, light, normal, perturbance, coefficient);
                    }
                }
            }
        }
        /// <summary>
        /// Calculates a distance between two 2D points
        /// </summary>
        /// <param name="v"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static double Distance(Vertex v, Point p)
        {
            return (v.X - p.X) * (v.X - p.X) + (v.Y - p.Y) * (v.Y - p.Y);
        }
    }
}
