namespace lab2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TriangleTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.second_solid_radio = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.second_texture_radio = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.first_texture_color_radiobutton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.first_solid_color_radiobutton = new System.Windows.Forms.RadioButton();
            this.second_texture_picturebox = new System.Windows.Forms.PictureBox();
            this.second_solid_picturebox = new System.Windows.Forms.PictureBox();
            this.second_texture_color_change = new System.Windows.Forms.Button();
            this.second_solid_color_change = new System.Windows.Forms.Button();
            this.Second_triangle_color_label = new System.Windows.Forms.Label();
            this.first_texture_picturebox = new System.Windows.Forms.PictureBox();
            this.first_solid_picturebox = new System.Windows.Forms.PictureBox();
            this.first_texture_color_change = new System.Windows.Forms.Button();
            this.first_solid_color_change = new System.Windows.Forms.Button();
            this.First_triangle_color_label = new System.Windows.Forms.Label();
            this.LightTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.LonzoBall_OFF = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.LonzoBall = new System.Windows.Forms.RadioButton();
            this.addition_label = new System.Windows.Forms.Label();
            this.light_color_change = new System.Windows.Forms.Button();
            this.light_color_picturebox = new System.Windows.Forms.PictureBox();
            this.Light_color_label = new System.Windows.Forms.Label();
            this.light_sphere_stop = new System.Windows.Forms.Button();
            this.light_sphere_start = new System.Windows.Forms.Button();
            this.light_animation_radiobutton = new System.Windows.Forms.RadioButton();
            this.light_constant_radiobutton = new System.Windows.Forms.RadioButton();
            this.Light_label = new System.Windows.Forms.Label();
            this.FillingTabPage = new System.Windows.Forms.TabPage();
            this.normal_function_radiobutton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.normal_texture_radiobutton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.normal_constant_radiobutton = new System.Windows.Forms.RadioButton();
            this.perturbance_texture_color_change = new System.Windows.Forms.Button();
            this.perturbance_texture_picturebox = new System.Windows.Forms.PictureBox();
            this.perturbance_texture_radiobutton = new System.Windows.Forms.RadioButton();
            this.perturbance_constant_radiobutton = new System.Windows.Forms.RadioButton();
            this.perturbance_label = new System.Windows.Forms.Label();
            this.normal_texture_color_change = new System.Windows.Forms.Button();
            this.normal_texture_picturebox = new System.Windows.Forms.PictureBox();
            this.normal_vector_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.TriangleTabPage.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.second_texture_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.second_solid_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_texture_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_solid_picturebox)).BeginInit();
            this.LightTabPage.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.light_color_picturebox)).BeginInit();
            this.FillingTabPage.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perturbance_texture_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normal_texture_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(6, 155);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1191, 534);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TriangleTabPage);
            this.tabControl1.Controls.Add(this.LightTabPage);
            this.tabControl1.Controls.Add(this.FillingTabPage);
            this.tabControl1.Location = new System.Drawing.Point(6, 5);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1191, 148);
            this.tabControl1.TabIndex = 2;
            // 
            // TriangleTabPage
            // 
            this.TriangleTabPage.Controls.Add(this.tableLayoutPanel4);
            this.TriangleTabPage.Controls.Add(this.tableLayoutPanel3);
            this.TriangleTabPage.Controls.Add(this.tableLayoutPanel2);
            this.TriangleTabPage.Controls.Add(this.tableLayoutPanel1);
            this.TriangleTabPage.Controls.Add(this.second_texture_picturebox);
            this.TriangleTabPage.Controls.Add(this.second_solid_picturebox);
            this.TriangleTabPage.Controls.Add(this.second_texture_color_change);
            this.TriangleTabPage.Controls.Add(this.second_solid_color_change);
            this.TriangleTabPage.Controls.Add(this.Second_triangle_color_label);
            this.TriangleTabPage.Controls.Add(this.first_texture_picturebox);
            this.TriangleTabPage.Controls.Add(this.first_solid_picturebox);
            this.TriangleTabPage.Controls.Add(this.first_texture_color_change);
            this.TriangleTabPage.Controls.Add(this.first_solid_color_change);
            this.TriangleTabPage.Controls.Add(this.First_triangle_color_label);
            this.TriangleTabPage.Location = new System.Drawing.Point(4, 29);
            this.TriangleTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TriangleTabPage.Name = "TriangleTabPage";
            this.TriangleTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TriangleTabPage.Size = new System.Drawing.Size(1183, 115);
            this.TriangleTabPage.TabIndex = 1;
            this.TriangleTabPage.Text = "Triangle";
            this.TriangleTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.second_solid_radio, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(759, 5);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(118, 45);
            this.tableLayoutPanel4.TabIndex = 17;
            // 
            // second_solid_radio
            // 
            this.second_solid_radio.Location = new System.Drawing.Point(4, 5);
            this.second_solid_radio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.second_solid_radio.Name = "second_solid_radio";
            this.second_solid_radio.Size = new System.Drawing.Size(110, 35);
            this.second_solid_radio.TabIndex = 8;
            this.second_solid_radio.TabStop = true;
            this.second_solid_radio.Text = "Solid";
            this.second_solid_radio.UseVisualStyleBackColor = true;
            this.second_solid_radio.Click += new System.EventHandler(this.second_solid_radio_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.second_texture_radio, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(759, 54);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(118, 43);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // second_texture_radio
            // 
            this.second_texture_radio.Location = new System.Drawing.Point(4, 5);
            this.second_texture_radio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.second_texture_radio.Name = "second_texture_radio";
            this.second_texture_radio.Size = new System.Drawing.Size(110, 33);
            this.second_texture_radio.TabIndex = 9;
            this.second_texture_radio.TabStop = true;
            this.second_texture_radio.Text = "Texture";
            this.second_texture_radio.UseVisualStyleBackColor = true;
            this.second_texture_radio.Click += new System.EventHandler(this.second_texture_radio_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.first_texture_color_radiobutton, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(164, 54);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(138, 43);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // first_texture_color_radiobutton
            // 
            this.first_texture_color_radiobutton.Location = new System.Drawing.Point(4, 5);
            this.first_texture_color_radiobutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.first_texture_color_radiobutton.Name = "first_texture_color_radiobutton";
            this.first_texture_color_radiobutton.Size = new System.Drawing.Size(129, 33);
            this.first_texture_color_radiobutton.TabIndex = 2;
            this.first_texture_color_radiobutton.Text = "Texture";
            this.first_texture_color_radiobutton.UseVisualStyleBackColor = true;
            this.first_texture_color_radiobutton.Click += new System.EventHandler(this.first_texture_color_radiobutton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.first_solid_color_radiobutton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(164, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(138, 48);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // first_solid_color_radiobutton
            // 
            this.first_solid_color_radiobutton.Location = new System.Drawing.Point(4, 5);
            this.first_solid_color_radiobutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.first_solid_color_radiobutton.Name = "first_solid_color_radiobutton";
            this.first_solid_color_radiobutton.Size = new System.Drawing.Size(129, 38);
            this.first_solid_color_radiobutton.TabIndex = 1;
            this.first_solid_color_radiobutton.Text = "Solid";
            this.first_solid_color_radiobutton.UseVisualStyleBackColor = true;
            this.first_solid_color_radiobutton.Click += new System.EventHandler(this.first_solid_color_radiobutton_Click);
            // 
            // second_texture_picturebox
            // 
            this.second_texture_picturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.second_texture_picturebox.Location = new System.Drawing.Point(910, 60);
            this.second_texture_picturebox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.second_texture_picturebox.Name = "second_texture_picturebox";
            this.second_texture_picturebox.Size = new System.Drawing.Size(71, 33);
            this.second_texture_picturebox.TabIndex = 13;
            this.second_texture_picturebox.TabStop = false;
            // 
            // second_solid_picturebox
            // 
            this.second_solid_picturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.second_solid_picturebox.Location = new System.Drawing.Point(910, 14);
            this.second_solid_picturebox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.second_solid_picturebox.Name = "second_solid_picturebox";
            this.second_solid_picturebox.Size = new System.Drawing.Size(71, 34);
            this.second_solid_picturebox.TabIndex = 12;
            this.second_solid_picturebox.TabStop = false;
            // 
            // second_texture_color_change
            // 
            this.second_texture_color_change.Enabled = false;
            this.second_texture_color_change.Location = new System.Drawing.Point(1010, 60);
            this.second_texture_color_change.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.second_texture_color_change.Name = "second_texture_color_change";
            this.second_texture_color_change.Size = new System.Drawing.Size(92, 35);
            this.second_texture_color_change.TabIndex = 11;
            this.second_texture_color_change.Text = "Change";
            this.second_texture_color_change.UseVisualStyleBackColor = true;
            this.second_texture_color_change.Click += new System.EventHandler(this.second_texture_color_change_Click);
            // 
            // second_solid_color_change
            // 
            this.second_solid_color_change.Enabled = false;
            this.second_solid_color_change.Location = new System.Drawing.Point(1010, 14);
            this.second_solid_color_change.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.second_solid_color_change.Name = "second_solid_color_change";
            this.second_solid_color_change.Size = new System.Drawing.Size(92, 35);
            this.second_solid_color_change.TabIndex = 10;
            this.second_solid_color_change.Text = "Change";
            this.second_solid_color_change.UseVisualStyleBackColor = true;
            this.second_solid_color_change.Click += new System.EventHandler(this.second_solid_color_change_Click);
            // 
            // Second_triangle_color_label
            // 
            this.Second_triangle_color_label.Location = new System.Drawing.Point(610, 6);
            this.Second_triangle_color_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Second_triangle_color_label.Name = "Second_triangle_color_label";
            this.Second_triangle_color_label.Size = new System.Drawing.Size(111, 91);
            this.Second_triangle_color_label.TabIndex = 7;
            this.Second_triangle_color_label.Text = "Second Triangle";
            this.Second_triangle_color_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // first_texture_picturebox
            // 
            this.first_texture_picturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.first_texture_picturebox.Location = new System.Drawing.Point(339, 63);
            this.first_texture_picturebox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.first_texture_picturebox.Name = "first_texture_picturebox";
            this.first_texture_picturebox.Size = new System.Drawing.Size(76, 34);
            this.first_texture_picturebox.TabIndex = 6;
            this.first_texture_picturebox.TabStop = false;
            // 
            // first_solid_picturebox
            // 
            this.first_solid_picturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.first_solid_picturebox.Location = new System.Drawing.Point(339, 14);
            this.first_solid_picturebox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.first_solid_picturebox.Name = "first_solid_picturebox";
            this.first_solid_picturebox.Size = new System.Drawing.Size(76, 39);
            this.first_solid_picturebox.TabIndex = 5;
            this.first_solid_picturebox.TabStop = false;
            // 
            // first_texture_color_change
            // 
            this.first_texture_color_change.Enabled = false;
            this.first_texture_color_change.Location = new System.Drawing.Point(442, 63);
            this.first_texture_color_change.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.first_texture_color_change.Name = "first_texture_color_change";
            this.first_texture_color_change.Size = new System.Drawing.Size(88, 35);
            this.first_texture_color_change.TabIndex = 4;
            this.first_texture_color_change.Text = "Change";
            this.first_texture_color_change.UseVisualStyleBackColor = true;
            this.first_texture_color_change.Click += new System.EventHandler(this.Texture_color_change_Click);
            // 
            // first_solid_color_change
            // 
            this.first_solid_color_change.Enabled = false;
            this.first_solid_color_change.Location = new System.Drawing.Point(442, 14);
            this.first_solid_color_change.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.first_solid_color_change.Name = "first_solid_color_change";
            this.first_solid_color_change.Size = new System.Drawing.Size(88, 38);
            this.first_solid_color_change.TabIndex = 3;
            this.first_solid_color_change.Text = "Change";
            this.first_solid_color_change.UseVisualStyleBackColor = true;
            this.first_solid_color_change.Click += new System.EventHandler(this.Solid_color_change_Click);
            // 
            // First_triangle_color_label
            // 
            this.First_triangle_color_label.Location = new System.Drawing.Point(22, 5);
            this.First_triangle_color_label.Name = "First_triangle_color_label";
            this.First_triangle_color_label.Size = new System.Drawing.Size(117, 105);
            this.First_triangle_color_label.TabIndex = 0;
            this.First_triangle_color_label.Text = "First Triangle";
            this.First_triangle_color_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LightTabPage
            // 
            this.LightTabPage.Controls.Add(this.tableLayoutPanel8);
            this.LightTabPage.Controls.Add(this.tableLayoutPanel7);
            this.LightTabPage.Controls.Add(this.addition_label);
            this.LightTabPage.Controls.Add(this.light_color_change);
            this.LightTabPage.Controls.Add(this.light_color_picturebox);
            this.LightTabPage.Controls.Add(this.Light_color_label);
            this.LightTabPage.Controls.Add(this.light_sphere_stop);
            this.LightTabPage.Controls.Add(this.light_sphere_start);
            this.LightTabPage.Controls.Add(this.light_animation_radiobutton);
            this.LightTabPage.Controls.Add(this.light_constant_radiobutton);
            this.LightTabPage.Controls.Add(this.Light_label);
            this.LightTabPage.Location = new System.Drawing.Point(4, 29);
            this.LightTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LightTabPage.Name = "LightTabPage";
            this.LightTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LightTabPage.Size = new System.Drawing.Size(1183, 115);
            this.LightTabPage.TabIndex = 0;
            this.LightTabPage.Text = "Light";
            this.LightTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.LonzoBall_OFF, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(1017, 58);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(141, 40);
            this.tableLayoutPanel8.TabIndex = 19;
            // 
            // LonzoBall_OFF
            // 
            this.LonzoBall_OFF.Location = new System.Drawing.Point(4, 5);
            this.LonzoBall_OFF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LonzoBall_OFF.Name = "LonzoBall_OFF";
            this.LonzoBall_OFF.Size = new System.Drawing.Size(132, 30);
            this.LonzoBall_OFF.TabIndex = 18;
            this.LonzoBall_OFF.TabStop = true;
            this.LonzoBall_OFF.Text = "BALL OFF";
            this.LonzoBall_OFF.UseVisualStyleBackColor = true;
            this.LonzoBall_OFF.Click += new System.EventHandler(this.LonzoBall_OFF_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.LonzoBall, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(1017, 0);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(136, 38);
            this.tableLayoutPanel7.TabIndex = 17;
            // 
            // LonzoBall
            // 
            this.LonzoBall.Location = new System.Drawing.Point(4, 5);
            this.LonzoBall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LonzoBall.Name = "LonzoBall";
            this.LonzoBall.Size = new System.Drawing.Size(128, 28);
            this.LonzoBall.TabIndex = 16;
            this.LonzoBall.TabStop = true;
            this.LonzoBall.Text = "BALL ON";
            this.LonzoBall.UseVisualStyleBackColor = true;
            this.LonzoBall.Click += new System.EventHandler(this.LonzoBall_Click);
            // 
            // addition_label
            // 
            this.addition_label.Location = new System.Drawing.Point(874, 5);
            this.addition_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addition_label.Name = "addition_label";
            this.addition_label.Size = new System.Drawing.Size(150, 94);
            this.addition_label.TabIndex = 15;
            this.addition_label.Text = "Additional Task";
            this.addition_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // light_color_change
            // 
            this.light_color_change.Location = new System.Drawing.Point(708, 63);
            this.light_color_change.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.light_color_change.Name = "light_color_change";
            this.light_color_change.Size = new System.Drawing.Size(112, 35);
            this.light_color_change.TabIndex = 14;
            this.light_color_change.Text = "Change";
            this.light_color_change.UseVisualStyleBackColor = true;
            this.light_color_change.Click += new System.EventHandler(this.light_color_change_Click);
            // 
            // light_color_picturebox
            // 
            this.light_color_picturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.light_color_picturebox.Location = new System.Drawing.Point(708, 11);
            this.light_color_picturebox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.light_color_picturebox.Name = "light_color_picturebox";
            this.light_color_picturebox.Size = new System.Drawing.Size(113, 39);
            this.light_color_picturebox.TabIndex = 13;
            this.light_color_picturebox.TabStop = false;
            // 
            // Light_color_label
            // 
            this.Light_color_label.Location = new System.Drawing.Point(519, 5);
            this.Light_color_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Light_color_label.Name = "Light_color_label";
            this.Light_color_label.Size = new System.Drawing.Size(134, 94);
            this.Light_color_label.TabIndex = 12;
            this.Light_color_label.Text = "Color Of The Light";
            this.Light_color_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // light_sphere_stop
            // 
            this.light_sphere_stop.Enabled = false;
            this.light_sphere_stop.Location = new System.Drawing.Point(398, 58);
            this.light_sphere_stop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.light_sphere_stop.Name = "light_sphere_stop";
            this.light_sphere_stop.Size = new System.Drawing.Size(64, 35);
            this.light_sphere_stop.TabIndex = 11;
            this.light_sphere_stop.Text = "stop";
            this.light_sphere_stop.UseVisualStyleBackColor = true;
            this.light_sphere_stop.Click += new System.EventHandler(this.light_sphere_stop_Click);
            // 
            // light_sphere_start
            // 
            this.light_sphere_start.Enabled = false;
            this.light_sphere_start.Location = new System.Drawing.Point(312, 58);
            this.light_sphere_start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.light_sphere_start.Name = "light_sphere_start";
            this.light_sphere_start.Size = new System.Drawing.Size(63, 35);
            this.light_sphere_start.TabIndex = 10;
            this.light_sphere_start.Text = "start";
            this.light_sphere_start.UseVisualStyleBackColor = true;
            this.light_sphere_start.Click += new System.EventHandler(this.light_sphere_start_Click);
            // 
            // light_animation_radiobutton
            // 
            this.light_animation_radiobutton.AutoSize = true;
            this.light_animation_radiobutton.Location = new System.Drawing.Point(214, 63);
            this.light_animation_radiobutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.light_animation_radiobutton.Name = "light_animation_radiobutton";
            this.light_animation_radiobutton.Size = new System.Drawing.Size(86, 24);
            this.light_animation_radiobutton.TabIndex = 3;
            this.light_animation_radiobutton.Text = "Sphere";
            this.light_animation_radiobutton.UseVisualStyleBackColor = true;
            this.light_animation_radiobutton.Click += new System.EventHandler(this.light_animation_radiobutton_Click);
            // 
            // light_constant_radiobutton
            // 
            this.light_constant_radiobutton.AutoSize = true;
            this.light_constant_radiobutton.Checked = true;
            this.light_constant_radiobutton.Location = new System.Drawing.Point(214, 11);
            this.light_constant_radiobutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.light_constant_radiobutton.Name = "light_constant_radiobutton";
            this.light_constant_radiobutton.Size = new System.Drawing.Size(85, 24);
            this.light_constant_radiobutton.TabIndex = 1;
            this.light_constant_radiobutton.TabStop = true;
            this.light_constant_radiobutton.Text = "[0, 0, 1]";
            this.light_constant_radiobutton.UseVisualStyleBackColor = true;
            this.light_constant_radiobutton.Click += new System.EventHandler(this.light_constant_radiobutton_Click);
            // 
            // Light_label
            // 
            this.Light_label.Location = new System.Drawing.Point(24, 5);
            this.Light_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Light_label.Name = "Light_label";
            this.Light_label.Size = new System.Drawing.Size(154, 98);
            this.Light_label.TabIndex = 0;
            this.Light_label.Text = "Version Of The Light";
            this.Light_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FillingTabPage
            // 
            this.FillingTabPage.Controls.Add(this.normal_function_radiobutton);
            this.FillingTabPage.Controls.Add(this.tableLayoutPanel6);
            this.FillingTabPage.Controls.Add(this.tableLayoutPanel5);
            this.FillingTabPage.Controls.Add(this.perturbance_texture_color_change);
            this.FillingTabPage.Controls.Add(this.perturbance_texture_picturebox);
            this.FillingTabPage.Controls.Add(this.perturbance_texture_radiobutton);
            this.FillingTabPage.Controls.Add(this.perturbance_constant_radiobutton);
            this.FillingTabPage.Controls.Add(this.perturbance_label);
            this.FillingTabPage.Controls.Add(this.normal_texture_color_change);
            this.FillingTabPage.Controls.Add(this.normal_texture_picturebox);
            this.FillingTabPage.Controls.Add(this.normal_vector_label);
            this.FillingTabPage.Location = new System.Drawing.Point(4, 29);
            this.FillingTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FillingTabPage.Name = "FillingTabPage";
            this.FillingTabPage.Size = new System.Drawing.Size(1183, 115);
            this.FillingTabPage.TabIndex = 2;
            this.FillingTabPage.Text = "Filling";
            this.FillingTabPage.UseVisualStyleBackColor = true;
            // 
            // normal_function_radiobutton
            // 
            this.normal_function_radiobutton.Location = new System.Drawing.Point(387, 6);
            this.normal_function_radiobutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.normal_function_radiobutton.Name = "normal_function_radiobutton";
            this.normal_function_radiobutton.Size = new System.Drawing.Size(156, 38);
            this.normal_function_radiobutton.TabIndex = 12;
            this.normal_function_radiobutton.TabStop = true;
            this.normal_function_radiobutton.Text = "4 * cosx * siny";
            this.normal_function_radiobutton.UseVisualStyleBackColor = true;
            this.normal_function_radiobutton.Click += new System.EventHandler(this.normal_function_radiobutton_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.normal_texture_radiobutton, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(213, 52);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(150, 37);
            this.tableLayoutPanel6.TabIndex = 11;
            // 
            // normal_texture_radiobutton
            // 
            this.normal_texture_radiobutton.Location = new System.Drawing.Point(4, 5);
            this.normal_texture_radiobutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.normal_texture_radiobutton.Name = "normal_texture_radiobutton";
            this.normal_texture_radiobutton.Size = new System.Drawing.Size(141, 27);
            this.normal_texture_radiobutton.TabIndex = 2;
            this.normal_texture_radiobutton.Text = "From Texture";
            this.normal_texture_radiobutton.UseVisualStyleBackColor = true;
            this.normal_texture_radiobutton.Click += new System.EventHandler(this.normal_texture_radiobutton_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.normal_constant_radiobutton, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(213, 6);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(150, 34);
            this.tableLayoutPanel5.TabIndex = 10;
            // 
            // normal_constant_radiobutton
            // 
            this.normal_constant_radiobutton.Location = new System.Drawing.Point(4, 5);
            this.normal_constant_radiobutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.normal_constant_radiobutton.Name = "normal_constant_radiobutton";
            this.normal_constant_radiobutton.Size = new System.Drawing.Size(106, 24);
            this.normal_constant_radiobutton.TabIndex = 1;
            this.normal_constant_radiobutton.Text = "[0, 0, 1]";
            this.normal_constant_radiobutton.UseVisualStyleBackColor = true;
            this.normal_constant_radiobutton.Click += new System.EventHandler(this.normal_constant_radiobutton_Click);
            // 
            // perturbance_texture_color_change
            // 
            this.perturbance_texture_color_change.Enabled = false;
            this.perturbance_texture_color_change.Location = new System.Drawing.Point(1018, 57);
            this.perturbance_texture_color_change.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.perturbance_texture_color_change.Name = "perturbance_texture_color_change";
            this.perturbance_texture_color_change.Size = new System.Drawing.Size(92, 32);
            this.perturbance_texture_color_change.TabIndex = 9;
            this.perturbance_texture_color_change.Text = "Change";
            this.perturbance_texture_color_change.UseVisualStyleBackColor = true;
            this.perturbance_texture_color_change.Click += new System.EventHandler(this.perturbance_texture_color_change_Click);
            // 
            // perturbance_texture_picturebox
            // 
            this.perturbance_texture_picturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.perturbance_texture_picturebox.Location = new System.Drawing.Point(932, 58);
            this.perturbance_texture_picturebox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.perturbance_texture_picturebox.Name = "perturbance_texture_picturebox";
            this.perturbance_texture_picturebox.Size = new System.Drawing.Size(58, 28);
            this.perturbance_texture_picturebox.TabIndex = 8;
            this.perturbance_texture_picturebox.TabStop = false;
            // 
            // perturbance_texture_radiobutton
            // 
            this.perturbance_texture_radiobutton.AutoSize = true;
            this.perturbance_texture_radiobutton.Location = new System.Drawing.Point(790, 62);
            this.perturbance_texture_radiobutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.perturbance_texture_radiobutton.Name = "perturbance_texture_radiobutton";
            this.perturbance_texture_radiobutton.Size = new System.Drawing.Size(128, 24);
            this.perturbance_texture_radiobutton.TabIndex = 7;
            this.perturbance_texture_radiobutton.TabStop = true;
            this.perturbance_texture_radiobutton.Text = "From Texture";
            this.perturbance_texture_radiobutton.UseVisualStyleBackColor = true;
            this.perturbance_texture_radiobutton.Click += new System.EventHandler(this.perturbance_texture_radiobutton_Click);
            // 
            // perturbance_constant_radiobutton
            // 
            this.perturbance_constant_radiobutton.AutoSize = true;
            this.perturbance_constant_radiobutton.Location = new System.Drawing.Point(790, 20);
            this.perturbance_constant_radiobutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.perturbance_constant_radiobutton.Name = "perturbance_constant_radiobutton";
            this.perturbance_constant_radiobutton.Size = new System.Drawing.Size(85, 24);
            this.perturbance_constant_radiobutton.TabIndex = 6;
            this.perturbance_constant_radiobutton.Text = "[0, 0, 0]";
            this.perturbance_constant_radiobutton.UseVisualStyleBackColor = true;
            this.perturbance_constant_radiobutton.Click += new System.EventHandler(this.perturbance_constant_radiobutton_Click);
            // 
            // perturbance_label
            // 
            this.perturbance_label.Location = new System.Drawing.Point(592, 5);
            this.perturbance_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.perturbance_label.Name = "perturbance_label";
            this.perturbance_label.Size = new System.Drawing.Size(150, 103);
            this.perturbance_label.TabIndex = 5;
            this.perturbance_label.Text = "Perturbance";
            this.perturbance_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // normal_texture_color_change
            // 
            this.normal_texture_color_change.Enabled = false;
            this.normal_texture_color_change.Location = new System.Drawing.Point(466, 57);
            this.normal_texture_color_change.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.normal_texture_color_change.Name = "normal_texture_color_change";
            this.normal_texture_color_change.Size = new System.Drawing.Size(84, 32);
            this.normal_texture_color_change.TabIndex = 4;
            this.normal_texture_color_change.Text = "Change";
            this.normal_texture_color_change.UseVisualStyleBackColor = true;
            this.normal_texture_color_change.Click += new System.EventHandler(this.normal_texture_color_change_Click);
            // 
            // normal_texture_picturebox
            // 
            this.normal_texture_picturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.normal_texture_picturebox.Location = new System.Drawing.Point(387, 58);
            this.normal_texture_picturebox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.normal_texture_picturebox.Name = "normal_texture_picturebox";
            this.normal_texture_picturebox.Size = new System.Drawing.Size(53, 30);
            this.normal_texture_picturebox.TabIndex = 3;
            this.normal_texture_picturebox.TabStop = false;
            // 
            // normal_vector_label
            // 
            this.normal_vector_label.Location = new System.Drawing.Point(36, 0);
            this.normal_vector_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.normal_vector_label.Name = "normal_vector_label";
            this.normal_vector_label.Size = new System.Drawing.Size(148, 108);
            this.normal_vector_label.TabIndex = 0;
            this.normal_vector_label.Text = "Normal Vector";
            this.normal_vector_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filling Triangles";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.TriangleTabPage.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.second_texture_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.second_solid_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_texture_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_solid_picturebox)).EndInit();
            this.LightTabPage.ResumeLayout(false);
            this.LightTabPage.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.light_color_picturebox)).EndInit();
            this.FillingTabPage.ResumeLayout(false);
            this.FillingTabPage.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.perturbance_texture_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normal_texture_picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage LightTabPage;
        private System.Windows.Forms.TabPage TriangleTabPage;
        private System.Windows.Forms.Label First_triangle_color_label;
        private System.Windows.Forms.RadioButton first_texture_color_radiobutton;
        private System.Windows.Forms.RadioButton first_solid_color_radiobutton;
        private System.Windows.Forms.PictureBox first_texture_picturebox;
        private System.Windows.Forms.PictureBox first_solid_picturebox;
        private System.Windows.Forms.Button first_texture_color_change;
        private System.Windows.Forms.Button first_solid_color_change;
        private System.Windows.Forms.Label Second_triangle_color_label;
        private System.Windows.Forms.Button second_texture_color_change;
        private System.Windows.Forms.Button second_solid_color_change;
        private System.Windows.Forms.RadioButton second_texture_radio;
        private System.Windows.Forms.RadioButton second_solid_radio;
        private System.Windows.Forms.PictureBox second_texture_picturebox;
        private System.Windows.Forms.PictureBox second_solid_picturebox;
        private System.Windows.Forms.TabPage FillingTabPage;
        private System.Windows.Forms.RadioButton normal_texture_radiobutton;
        private System.Windows.Forms.RadioButton normal_constant_radiobutton;
        private System.Windows.Forms.Label normal_vector_label;
        private System.Windows.Forms.Button normal_texture_color_change;
        private System.Windows.Forms.PictureBox normal_texture_picturebox;
        private System.Windows.Forms.Label perturbance_label;
        private System.Windows.Forms.RadioButton perturbance_texture_radiobutton;
        private System.Windows.Forms.RadioButton perturbance_constant_radiobutton;
        private System.Windows.Forms.Button perturbance_texture_color_change;
        private System.Windows.Forms.PictureBox perturbance_texture_picturebox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label Light_label;
        private System.Windows.Forms.RadioButton light_animation_radiobutton;
        private System.Windows.Forms.RadioButton light_constant_radiobutton;
        private System.Windows.Forms.Button light_sphere_stop;
        private System.Windows.Forms.Button light_sphere_start;
        private System.Windows.Forms.Label Light_color_label;
        private System.Windows.Forms.Button light_color_change;
        private System.Windows.Forms.PictureBox light_color_picturebox;
        private System.Windows.Forms.Label addition_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.RadioButton LonzoBall;
        private System.Windows.Forms.RadioButton LonzoBall_OFF;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.RadioButton normal_function_radiobutton;
    }
}

