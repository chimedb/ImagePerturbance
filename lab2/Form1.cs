using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {

        public bool sphere_light;
        /// <summary>
        /// Tells whether Left Mouse move a vertex of the triangle
        /// </summary>
        public bool move_vertex;
        /// <summary>
        /// Tells whether Right Mouse move a triangle
        /// </summary>
        public bool move_triangle;
        /// <summary>
        /// Represents the first triangle
        /// </summary>
        private Triangle ftr;
        /// <summary>
        /// Represents the second triangle
        /// </summary>
        private Triangle str;
        /// <summary>
        /// Represents the constant light
        /// </summary>
        private Light light;
        /// <summary>
        /// Points selected vertex by mouse
        /// </summary>
        private Vertex selected_vertex;
        /// <summary>
        /// Index of the selected triangle by mouse
        /// </summary>
        private int selected_triangle;
        /// <summary>
        /// Represents the normal vector
        /// </summary>
        private Vector normal_vector;
        /// <summary>
        /// Represents the perturbance vector
        /// </summary>
        private Vector perturbance_vector;
        /// <summary>
        /// Perturbance coefficient
        /// </summary>
        private double perturbance_coefficient;
        /// <summary>
        /// Texture path which will fill triangles
        /// </summary>
        private string color_texture_path;
        /// <summary>
        /// Normal map texture path
        /// </summary>
        private string normal_texture_path;
        /// <summary>
        /// Perturbance texture path
        /// </summary>
        private string perturbance_texture_path;
        /// <summary>
        /// Default solid color
        /// </summary>
        private Color default_solid_color = Color.Blue;
        /// <summary>
        /// Default texture path of the triangles
        /// </summary>
        private string default_color_texture_path = "C:\\Users\\Chimee\\source\\repos\\lab2\\lab2\\lab2\\Textures\\hmap0.png";
        /// <summary>
        /// Default normal map texture path
        /// </summary>
        private string default_normal_texture_path = "C:\\Users\\Chimee\\source\\repos\\lab2\\lab2\\lab2\\Textures\\mountain0.png";
        /// <summary>
        /// Default perturbance texture path
        /// </summary>
        private string default_perturbance_texture_path = "C:\\Users\\Chimee\\source\\repos\\lab2\\lab2\\lab2\\Textures\\nmap1.png";


        //private string default_color_texture_path = "C:\\Users\\Chimee\\source\\repos\\lab2\\lab2\\Textures\\naruto0.png";
        //private string default_normal_texture_path = "C:\\Users\\Chimee\\source\\repos\\lab2\\lab2\\Textures\\mountain0.png";
        //private string default_perturbance_texture_path = "C:\\Users\\Chimee\\source\\repos\\lab2\\lab2\\Textures\\nmap1.png";

        /// <summary>
        /// Initializes the triangles
        /// </summary>
        public void InitializeTriangle()
        {
            List<Vertex> ftr_vertices = new List<Vertex>() { new Vertex(47, 34), new Vertex(47, 200), new Vertex(231, 323) };
            List<Vertex> str_vertices = new List<Vertex>() { new Vertex(474, 158), new Vertex(719, 24), new Vertex(750, 210) };
            List<Edge> ftr_edges = new List<Edge>();
            ftr_edges.Add(new Edge(new Vertex(47, 34), new Vertex(47, 200)));
            ftr_edges.Add(new Edge(new Vertex(47, 200), new Vertex(231, 323)));
            ftr_edges.Add(new Edge(new Vertex(231, 323), new Vertex(47, 34)));
            List<Edge> str_edges = new List<Edge>();
            str_edges.Add(new Edge(new Vertex(474, 158), new Vertex(719, 24)));
            str_edges.Add(new Edge(new Vertex(719, 24), new Vertex(750, 210)));
            str_edges.Add(new Edge(new Vertex(750, 210), new Vertex(474, 158)));
            ftr = new Triangle(ftr_vertices, ftr_edges, default_color_texture_path);
            str = new Triangle(str_vertices, str_edges, default_color_texture_path);
        }

        /// <summary>
        /// Initializes other fields
        /// </summary>
        public void InitializeProperties()
        {
            sphere_light = false;
            move_vertex = false;
            move_triangle = false;
            color_texture_path = default_color_texture_path;
            normal_texture_path = default_normal_texture_path;
            perturbance_texture_path = default_perturbance_texture_path;
            light = new Light();
            normal_vector = new NormalVector();
            perturbance_vector = new PerturbanceVector();
            Random random = new Random();
            perturbance_coefficient = random.Next(40, 100); 
        }

        public Form1()
        {
            InitializeTriangle();
            InitializeComponent();
            InitializeProperties();
            first_texture_color_radiobutton_Click(null, null);
            second_texture_radio_Click(null, null);
            normal_constant_radiobutton_Click(null, null);
            perturbance_constant_radiobutton_Click(null, null);
            light_constant_radiobutton_Click(null, null);
            //default_color_texture_path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\Textures\\naruto0.png";
            //default_normal_texture_path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\Textures\\mountain0.png";
            //default_perturbance_texture_path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\Textures\\nmap1.png";
            first_texture_picturebox.Image = new Bitmap(default_color_texture_path);
            second_texture_picturebox.Image = new Bitmap(default_color_texture_path);
        }

        /// <summary>
        /// Draws the triangles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Light current_light = light;
            //if (LonzoBall.Checked == true);
            Function.ColorTriangle(ftr, e.Graphics, current_light, normal_vector, perturbance_vector, perturbance_coefficient);
            Function.ColorTriangle(str, e.Graphics, current_light, normal_vector, perturbance_vector, perturbance_coefficient);
            for (int i = 0; i < 3; i++)
            {
                RectangleF rect1 = new RectangleF(ftr.vertices[i].X - 3, ftr.vertices[i].Y - 3, 6, 6);
                g.FillEllipse(new SolidBrush(Color.Black), rect1);
                g.DrawEllipse(new Pen(Color.Black, 3), rect1);
                RectangleF rect2 = new RectangleF(str.vertices[i].X - 3, str.vertices[i].Y - 3, 6, 6);
                g.FillEllipse(new SolidBrush(Color.Black), rect2);
                g.DrawEllipse(new Pen(Color.Black, 3), rect2);
                g.DrawLine(new Pen(Color.Black), new Point(ftr.vertices[i].X, ftr.vertices[i].Y), new Point(ftr.vertices[(i + 1) % 3].X, ftr.vertices[(i + 1) % 3].Y));
                g.DrawLine(new Pen(Color.Black), new Point(str.vertices[i].X, str.vertices[i].Y), new Point(str.vertices[(i + 1) % 3].X, str.vertices[(i + 1) % 3].Y));
            }
        }

        /// <summary>
        /// To find selected vertex and triangle by mouse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    foreach (var i in ftr.vertices)
                    {
                        if (Function.Distance(i, e.Location) <= 100)
                        {
                            selected_vertex = i;
                            move_vertex = true;
                            break;
                        }
                    }
                    foreach (var i in str.vertices)
                    {
                        if (Function.Distance(i, e.Location) <= 100)
                        {
                            selected_vertex = i;
                            move_vertex = true;
                            break;
                        }
                    }
                    break;
                case MouseButtons.Right:
                    foreach (var i in ftr.vertices)
                    {
                        if (Function.Distance(i, e.Location) <= 100)
                        {
                            selected_vertex = i;
                            selected_triangle = 1;
                            move_triangle = true;
                            break;
                        }
                    }
                    foreach (var i in str.vertices)
                    {
                        if (Function.Distance(i, e.Location) <= 100)
                        {
                            selected_vertex = i;
                            selected_triangle = 2;
                            move_triangle = true;
                            break;
                        }
                    }
                    break;
                case MouseButtons.Middle:
                    break;
            }
            pictureBox1.Invalidate();
        }

        /// <summary>
        /// Mouse.Left moves a vertex, and Mouse.Right moves a triangle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move_vertex)
            {
                selected_vertex.X = e.X;
                selected_vertex.Y = e.Y;
            }
            if (move_triangle)
            {
                int deltax = e.X - selected_vertex.X;
                int deltay = e.Y - selected_vertex.Y;
                if (selected_triangle == 1) ftr.Move(deltax, deltay);
                else str.Move(deltax, deltay);
            }
            if (LonzoBall.Checked)
            {
                normal_vector.X = e.X;
                normal_vector.Y = e.Y;
            }
            if (sphere_light)
            {
                normal_vector.X = e.X;
                normal_vector.Y = e.Y;
            }
            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                move_vertex = false;
                pictureBox1.Invalidate();
            }
            if (e.Button == MouseButtons.Right)
            {
                move_triangle = false;
                pictureBox1.Invalidate();
            }
        }
        /// <summary>
        /// Enables solid color change for the first triangle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void first_solid_color_radiobutton_Click(object sender, EventArgs e)
        {
            first_solid_color_radiobutton.Checked = true;
            first_solid_color_change.Enabled = true;
            first_texture_color_change.Enabled = false;
            first_texture_color_radiobutton.Checked = false;
            ftr.Cover.current_color = default_solid_color;
            first_solid_picturebox.BackColor = default_solid_color;
            first_texture_picturebox.Image = null;
            ftr.Cover.color_style = Coloring.ColoringStyle.Solid;
            pictureBox1.Invalidate();
        }
        /// <summary>
        /// Enables texture color change for the first triangle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void first_texture_color_radiobutton_Click(object sender, EventArgs e)
        {
            first_texture_color_radiobutton.Checked = true;
            first_texture_color_change.Enabled = true;
            first_solid_color_change.Enabled = false;
            first_solid_color_radiobutton.Checked = false;
            ftr.Cover.TexturePath = default_color_texture_path;
            first_solid_picturebox.BackColor = Color.White;
            first_texture_picturebox.Image = new Bitmap(default_color_texture_path);
            ftr.Cover.color_style = Coloring.ColoringStyle.Texture;
            pictureBox1.Invalidate();
        }
        /// <summary>
        /// Changes solid color of the first triangle from the solid color bitmap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Solid_color_change_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                first_solid_picturebox.BackColor = cd.Color;
                ftr.Cover.current_color = cd.Color;
                ftr.Cover.color_style = Coloring.ColoringStyle.Solid;
                pictureBox1.Invalidate();
            }
        }
        /// <summary>
        /// Changes texture color of the first triangle from the texture color bitmap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Texture_color_change_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.bmp, *.png, *.jpg) | *.bmp; *.png; *.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string pathname = Path.GetFullPath(ofd.FileName);
                try
                {
                    first_texture_picturebox.Image = new Bitmap(pathname);
                    color_texture_path = pathname;
                }
                catch
                {
                    first_texture_picturebox.Image = new Bitmap(default_color_texture_path);
                    color_texture_path = default_color_texture_path;
                }
                ftr.Cover.color_style = Coloring.ColoringStyle.Texture;
                ftr.Cover.TexturePath = pathname;
                pictureBox1.Invalidate();
            }
        }
        /// <summary>
        /// Enables solid color change for the second triangle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void second_solid_radio_Click(object sender, EventArgs e)
        {
            second_solid_radio.Checked = true;
            second_solid_color_change.Enabled = true;
            second_texture_color_change.Enabled = false;
            second_texture_radio.Checked = false;
            str.Cover.current_color = default_solid_color;
            second_solid_picturebox.BackColor = default_solid_color;
            second_texture_picturebox.Image = null;
            str.Cover.color_style = Coloring.ColoringStyle.Solid;
            pictureBox1.Invalidate();
        }
        /// <summary>
        /// Enables texture color change for the second triangle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void second_texture_radio_Click(object sender, EventArgs e)
        {
           second_texture_radio.Checked = true;
           second_texture_color_change.Enabled = true;
           second_solid_color_change.Enabled = false;
           second_solid_radio.Checked = false;
           str.Cover.TexturePath = default_color_texture_path;
            second_solid_picturebox.BackColor = Color.White;
            second_texture_picturebox.Image = new Bitmap(default_color_texture_path);
           str.Cover.color_style = Coloring.ColoringStyle.Texture;
           pictureBox1.Invalidate();
        }
        /// <summary>
        /// Changes solid color of the second triangle from the solid color bitmap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void second_solid_color_change_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                second_solid_picturebox.BackColor = cd.Color;
                str.Cover.current_color = cd.Color;
                str.Cover.color_style = Coloring.ColoringStyle.Solid;
                pictureBox1.Invalidate();
            }
        }
        /// <summary>
        /// Changes texture color of the second triangle from the texture color bitmap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void second_texture_color_change_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.bmp, *.png, *.jpg) | *.bmp; *.png; *.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string pathname = Path.GetFullPath(ofd.FileName);
                try
                {
                    second_texture_picturebox.Image = new Bitmap(pathname);
                    color_texture_path = pathname;
                }
                catch
                {
                    second_texture_picturebox.Image = new Bitmap(default_color_texture_path);
                    color_texture_path = default_color_texture_path;
                }
                str.Cover.color_style = Coloring.ColoringStyle.Texture;
                str.Cover.TexturePath = pathname;
                pictureBox1.Invalidate();
            }
        }
        /// <summary>
        /// No normal map to use 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void normal_constant_radiobutton_Click(object sender, EventArgs e)
        {
            normal_constant_radiobutton.Checked = true;
            normal_texture_radiobutton.Checked = false;
            normal_texture_color_change.Enabled = false;
            normal_function_radiobutton.Checked = false;
            normal_vector = new NormalVector();
            pictureBox1.Invalidate();
        }
        /// <summary>
        /// Normal map from the texture to use
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void normal_texture_radiobutton_Click(object sender, EventArgs e)
        {
            normal_texture_radiobutton.Checked = true;
            normal_constant_radiobutton.Checked = false;
            normal_function_radiobutton.Checked = false;
            normal_texture_color_change.Enabled = true;
            normal_vector = new NormalTextureVector(default_normal_texture_path);
            pictureBox1.Invalidate();
        }
        /// <summary>
        /// Changes texture color of the normal map
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void normal_texture_color_change_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.bmp, *.png) | *.bmp; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string pathname = Path.GetFullPath(ofd.FileName);
                try
                {
                    normal_texture_picturebox.Image = new Bitmap(pathname);
                    normal_texture_path = pathname;
                }
                catch
                {
                    normal_texture_picturebox.Image = new Bitmap(default_normal_texture_path);
                    normal_texture_path = default_normal_texture_path;
                }
                normal_vector = new NormalTextureVector(pathname);
                pictureBox1.Invalidate();
            }
        }
        /// <summary>
        /// No perturbance to use
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void perturbance_constant_radiobutton_Click(object sender, EventArgs e)
        {
            perturbance_constant_radiobutton.Checked = true;
            perturbance_texture_radiobutton.Checked = false;
            perturbance_texture_color_change.Enabled = false;
            perturbance_vector = new PerturbanceVector();
            pictureBox1.Invalidate();
        }
        /// <summary>
        /// Perturbance from the texture to use
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void perturbance_texture_radiobutton_Click(object sender, EventArgs e)
        {
            perturbance_texture_radiobutton.Checked = true;
            perturbance_constant_radiobutton.Checked = false;
            perturbance_texture_color_change.Enabled = true;
            perturbance_vector = new PerturbanceTextureVector(default_perturbance_texture_path);
            pictureBox1.Invalidate();
        }
        /// <summary>
        /// Perturbance color change from the texture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void perturbance_texture_color_change_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.bmp, *.png) | *.bmp; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string pathname = Path.GetFullPath(ofd.FileName);
                try
                {
                    perturbance_texture_picturebox.Image = new Bitmap(pathname);
                    perturbance_texture_path = pathname;
                }
                catch
                {
                    perturbance_texture_picturebox.Image = new Bitmap(default_perturbance_texture_path);
                    perturbance_texture_path = default_perturbance_texture_path;
                }
                perturbance_vector = new PerturbanceTextureVector(pathname);
                pictureBox1.Invalidate();
            }
        }
        /// <summary>
        /// Constant light to shine
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void light_constant_radiobutton_Click(object sender, EventArgs e)
        {
            light = new Light(light.LightColor);
            light_constant_radiobutton.Checked = true;
            light_animation_radiobutton.Checked = false;
            //added today
            light_sphere_start.Enabled = false;
            light_sphere_stop.Enabled = false;
            pictureBox1.Invalidate();
        }
        /// <summary>
        /// Changes the color of the constant light
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void light_color_change_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                light.LightColor = cd.Color;
                light_color_picturebox.BackColor = cd.Color;
                pictureBox1.Invalidate();
            }
        }
        /// <summary>
        /// Animated sphere light
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void light_animation_radiobutton_Click(object sender, EventArgs e)
        {
            light_sphere_start.Enabled = true;
            light_sphere_stop.Enabled = false;
            pictureBox1.Invalidate();
        }
        /// <summary>
        /// Appears a ball under the mouse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LonzoBall_Click(object sender, EventArgs e)
        {
            LonzoBall_OFF.Checked = false;
            LonzoBall.Checked = true;
            normal_vector = new BallVector();
        }
        /// <summary>
        /// Disappears a ball under the mouse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LonzoBall_OFF_Click(object sender, EventArgs e)
        {
            LonzoBall_OFF.Checked = true;
            LonzoBall.Checked = false;
            normal_vector = new NormalVector();
        }

        private void normal_function_radiobutton_Click(object sender, EventArgs e)
        {
            normal_function_radiobutton.Checked = true;
            normal_constant_radiobutton.Checked = false;
            normal_texture_radiobutton.Checked = false;
            normal_vector = new NormalFunctionVector();
            pictureBox1.Invalidate();
        }

        private void light_sphere_start_Click(object sender, EventArgs e)
        {
            sphere_light = true;
            light_sphere_start.Enabled = false;
            light_sphere_stop.Enabled = true;
            normal_vector = new BallVector(1000);
            pictureBox1.Invalidate();
        }

        private void light_sphere_stop_Click(object sender, EventArgs e)
        {
            sphere_light = false;
            light_sphere_start.Enabled = true;
            light_sphere_stop.Enabled = false;
            normal_vector = new NormalVector();
            pictureBox1.Invalidate();
        }
    }
}
