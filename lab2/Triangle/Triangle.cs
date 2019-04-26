using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab2
{
    /// <summary>
    /// Class of the triangles which consist of the vectices and edges, etc
    /// </summary>
    public class Triangle
    {
        public List<Vertex> vertices { get; set; }
        public List<Edge> edges;
        public Color Color { get; set; }
        public Coloring Cover;

        public Triangle(List<Vertex> vertices, List<Edge> edges, string texture_path)
        {
            this.vertices = vertices;
            this.edges = edges;
            Color = Color.Black;
            Cover = new Coloring(0, 0, texture_path);
        }

        public Triangle(List<Vertex> vertices, List<Edge> edges, string texture_path, Color color) : this(vertices, edges, texture_path)
        {
            Color = color;
        }
        /// <summary>
        /// Moves a whole triangle by mouse
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Move(int x, int y)
        {
            Cover.Xoffset += x;
            Cover.Yoffset += y;
            foreach (var v in vertices)
            {
                v.X += x;
                v.Y += y;
            }
        }
    }
}
