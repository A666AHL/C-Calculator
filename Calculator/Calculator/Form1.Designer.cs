namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.input = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.output = new System.Windows.Forms.TextBox();
            this.left_kuohao = new System.Windows.Forms.Button();
            this.right_kuohao = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Jian = new System.Windows.Forms.Button();
            this.Cheng = new System.Windows.Forms.Button();
            this.Chu = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(34, 73);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(399, 28);
            this.input.TabIndex = 0;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(34, 122);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(399, 28);
            this.output.TabIndex = 2;
            this.output.TextChanged += new System.EventHandler(this.output_TextChanged);
            // 
            // left_kuohao
            // 
            this.left_kuohao.Location = new System.Drawing.Point(34, 168);
            this.left_kuohao.Name = "left_kuohao";
            this.left_kuohao.Size = new System.Drawing.Size(75, 45);
            this.left_kuohao.TabIndex = 3;
            this.left_kuohao.Text = "(";
            this.left_kuohao.UseVisualStyleBackColor = true;
            this.left_kuohao.Click += new System.EventHandler(this.left_kuohao_Click);
            // 
            // right_kuohao
            // 
            this.right_kuohao.Location = new System.Drawing.Point(115, 168);
            this.right_kuohao.Name = "right_kuohao";
            this.right_kuohao.Size = new System.Drawing.Size(75, 45);
            this.right_kuohao.TabIndex = 4;
            this.right_kuohao.Text = ")";
            this.right_kuohao.UseVisualStyleBackColor = true;
            this.right_kuohao.Click += new System.EventHandler(this.right_kuohao_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(196, 168);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 45);
            this.del.TabIndex = 5;
            this.del.Text = "Del";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(277, 168);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 45);
            this.reset.TabIndex = 6;
            this.reset.Text = "C";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(115, 219);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 45);
            this.Add.TabIndex = 7;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Jian
            // 
            this.Jian.Location = new System.Drawing.Point(196, 219);
            this.Jian.Name = "Jian";
            this.Jian.Size = new System.Drawing.Size(75, 45);
            this.Jian.TabIndex = 8;
            this.Jian.Text = "-";
            this.Jian.UseVisualStyleBackColor = true;
            this.Jian.Click += new System.EventHandler(this.Jian_Click);
            // 
            // Cheng
            // 
            this.Cheng.Location = new System.Drawing.Point(277, 219);
            this.Cheng.Name = "Cheng";
            this.Cheng.Size = new System.Drawing.Size(75, 45);
            this.Cheng.TabIndex = 9;
            this.Cheng.Text = "×";
            this.Cheng.UseVisualStyleBackColor = true;
            this.Cheng.Click += new System.EventHandler(this.Cheng_Click);
            // 
            // Chu
            // 
            this.Chu.Location = new System.Drawing.Point(277, 270);
            this.Chu.Name = "Chu";
            this.Chu.Size = new System.Drawing.Size(75, 45);
            this.Chu.TabIndex = 10;
            this.Chu.Text = "÷";
            this.Chu.UseVisualStyleBackColor = true;
            this.Chu.Click += new System.EventHandler(this.Chu_Click);
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(196, 270);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(75, 45);
            this.num3.TabIndex = 11;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(115, 270);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(75, 45);
            this.num2.TabIndex = 12;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(34, 270);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(75, 45);
            this.num1.TabIndex = 13;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // num4
            // 
            this.num4.Location = new System.Drawing.Point(34, 321);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(75, 45);
            this.num4.TabIndex = 14;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num5
            // 
            this.num5.Location = new System.Drawing.Point(115, 321);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(75, 45);
            this.num5.TabIndex = 15;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num6
            // 
            this.num6.Location = new System.Drawing.Point(196, 321);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(75, 45);
            this.num6.TabIndex = 16;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // Dot
            // 
            this.Dot.Location = new System.Drawing.Point(277, 321);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(75, 45);
            this.Dot.TabIndex = 17;
            this.Dot.Text = ".";
            this.Dot.UseVisualStyleBackColor = true;
            this.Dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // num7
            // 
            this.num7.Location = new System.Drawing.Point(34, 372);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(75, 45);
            this.num7.TabIndex = 18;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num8
            // 
            this.num8.Location = new System.Drawing.Point(115, 372);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(75, 45);
            this.num8.TabIndex = 19;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num9
            // 
            this.num9.Location = new System.Drawing.Point(196, 372);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(75, 45);
            this.num9.TabIndex = 20;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // Equal
            // 
            this.Equal.Location = new System.Drawing.Point(358, 372);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(75, 45);
            this.Equal.TabIndex = 21;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // num0
            // 
            this.num0.Location = new System.Drawing.Point(34, 219);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(75, 45);
            this.num0.TabIndex = 22;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // Sqrt
            // 
            this.Sqrt.Location = new System.Drawing.Point(358, 168);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(75, 45);
            this.Sqrt.TabIndex = 23;
            this.Sqrt.Text = "√";
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Visible = false;
            this.Sqrt.Click += new System.EventHandler(this.Sqrt_Click);
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(277, 372);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(75, 45);
            this.Show.TabIndex = 24;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(358, 219);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(75, 45);
            this.sin.TabIndex = 25;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Visible = false;
            this.sin.Click += new System.EventHandler(this.sin_Click);
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(358, 270);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(75, 45);
            this.cos.TabIndex = 26;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Visible = false;
            this.cos.Click += new System.EventHandler(this.cos_Click);
            // 
            // square
            // 
            this.square.Location = new System.Drawing.Point(358, 321);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(75, 45);
            this.square.TabIndex = 27;
            this.square.Text = "x²";
            this.square.UseVisualStyleBackColor = true;
            this.square.Visible = false;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 450);
            this.Controls.Add(this.square);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.Dot);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.Chu);
            this.Controls.Add(this.Cheng);
            this.Controls.Add(this.Jian);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.del);
            this.Controls.Add(this.right_kuohao);
            this.Controls.Add(this.left_kuohao);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button left_kuohao;
        private System.Windows.Forms.Button right_kuohao;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Jian;
        private System.Windows.Forms.Button Cheng;
        private System.Windows.Forms.Button Chu;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button Dot;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button square;
    }
}

