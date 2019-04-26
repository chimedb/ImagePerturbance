using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    /// <summary>
    /// Class of the edge of the triangle
    /// </summary>
    public class Edge
    {
        public Vertex from;
        public Vertex to;
        public Edge(Vertex from, Vertex to)
        {
            this.from = from;
            this.to = to;
        }
    }
}
