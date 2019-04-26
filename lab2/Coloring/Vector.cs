using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab2
{
    /// <summary>
    /// Class of the general vector
    /// </summary>
    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector(double X, double Y, double Z = 0.0)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public double Length
        {
            get { return Math.Sqrt(X * X + Y * Y + Z * Z); }
        }

        public Vector Versor
        {
            get
            {
                return new Vector(X / Length, Y / Length, Z / Length);
            }
        }
        /// <summary>
        /// Scalar product
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public double DotProduct(Vector v)
        {
            return v.X * X + v.Y * Y + v.Z * Z;
        }

        //cosine of the angle = the dot product of vectors for unit vectors
        public double Cosinus(Vector v) 
        {
            return Versor.DotProduct(v.Versor);
        }

        public Vector CrossProduct(Vector v)
        {
            double x, y, z;
            x = Y * v.Z - v.Y * v.Z;
            y = (X * v.Z - v.X * Z) * -1;
            z = X * v.Y - v.X * Y;

            return new Vector(x, y, z);
        }

        public static Vector operator+(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        public static Vector operator*(Vector v, double k)
        {
            return new Vector(v.X * k, v.Y * k, v.Z * k);
        }

        public virtual Vector GetVestorForPoint(int x, int y)
        {
            return this;
        }

        public virtual Vector GetVestorForPoint(int x, int y, Vector N)
        {
            return this;
        }
    }
    /// <summary>
    /// Class of the texture vector of the triangle
    /// </summary>
    class TextureVector : Vector
    {
        private string texture_path;
        public string TexturePath
        {
            get
            {
                return texture_path;
            }
            set
            {
                try
                {
                    texture_path = value;
                    Texture = new Bitmap(value);
                }
                catch
                {
                    texture_path = String.Empty;
                }
            }
        }
        public Bitmap Texture { get; set; }
        public TextureVector(string texture_path) : base(0, 0)
        {
            TexturePath = texture_path;
        }
    }
    /// <summary>
    /// Class of the constant normal vector
    /// </summary>
    class NormalVector : Vector
    {
        public NormalVector() : base(0, 0, 1) { }
        public NormalVector(double X, double Y, double Z = 0) : base(X, Y, Z) { }
    }

    class NormalFunctionVector : Vector
    {
        public NormalFunctionVector() : base(0, 0, 1) { }
        public NormalFunctionVector(double X, double Y, double Z = 0) : base(X, Y, Z) { }
        public override Vector GetVestorForPoint(int x, int y)
        {
            double xp = -4 * Math.Sin(x) * Math.Sin(y);
            xp = Math.Abs(xp);
            double yp = 4 * Math.Cos(x) * Math.Cos(y);
            yp = Math.Abs(yp);
            Vector Zx = new Vector(1, 0, xp);
            Vector Zy = new Vector(0, 1, yp);
            return Zx.CrossProduct(Zy);
        }
    }

    /// <summary>
    /// Class of the normal vector from the texture
    /// </summary>
    class NormalTextureVector : TextureVector
    {
        public NormalTextureVector(string texture_path) : base(texture_path) { }
        public override Vector GetVestorForPoint(int x, int y)
        {
            int texturex = (x + Texture.Width) % Texture.Width;
            int texturey = (y + Texture.Height) % Texture.Height;
            Color texture_color = Texture.GetPixel(texturex, texturey);
            double Nx = 2 * texture_color.R / 255 - 1;
            double Ny = 2 * texture_color.G / 255 - 1;
            double Nz = texture_color.B / 255;
            return Nz == 0 ? new Vector(Nx, Ny, Nz) : new Vector(Nx / Nz, Ny / Nz, 1);
        }
    }
    /// <summary>
    /// Class of the constant perturbance vector
    /// </summary>
    class PerturbanceVector : Vector
    {
        public PerturbanceVector() : base(0, 0, 0) { }
        public PerturbanceVector(double X, double Y, double Z = 0) : base(X, Y, Z) { }
    }
    /// <summary>
    /// Class of the perturbance vector from the texture
    /// </summary>
    class PerturbanceTextureVector : TextureVector
    {
        public PerturbanceTextureVector(string texture_path) : base(texture_path) { }
        public override Vector GetVestorForPoint(int x, int y, Vector N)
        {
            int texturex1 = (x + Texture.Width) % Texture.Width;
            int texturey1 = (y + Texture.Height) % Texture.Height;
            int texturex2 = (x + 1 + Texture.Width) % Texture.Width;
            int texturey2 = (y + 1 + Texture.Height) % Texture.Height;
            Color texture_color = Texture.GetPixel(texturex1, texturey1);
            Color x_change_color = Texture.GetPixel(texturex2, texturey1);
            Color y_change_color = Texture.GetPixel(texturex1, texturey2);
            Vector T = new Vector(1, 0, -N.X);
            Vector B = new Vector(0, 1, -N.Y);
            double dhx = x_change_color.GetBrightness() - texture_color.GetBrightness();
            double dhy = y_change_color.GetBrightness() - texture_color.GetBrightness();
            return T * dhx + B * dhy;
        }
    }
    /// <summary>
    /// Class of the ball under the mouse
    /// </summary>
    class BallVector : Vector
    {
        public int radius { get; set; }
        public BallVector(int radius = 20) : base(0, 0, 0)
        {
            this.radius = radius;
        }
        public BallVector(double x, double y, double z = 0, int radius = 20) : base(x, y, z)
        {
            this.radius = radius;
        }
        public override Vector GetVestorForPoint(int x, int y)
        {
            double len = (x - X) * (x - X) + (y - Y) * (y - Y);
            if (len > radius * radius) return new Vector(0, 0, 1);
            double z = Math.Sqrt(radius * radius - len);
            return new Vector(((double)x - X) / z, ((double)y - Y) / z, 1);
        }
    }
}
