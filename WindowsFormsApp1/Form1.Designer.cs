namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.Title = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enter_butt = new System.Windows.Forms.Button();
            this.plus_butt = new System.Windows.Forms.Button();
            this.minus_butt = new System.Windows.Forms.Button();
            this.mul_butt = new System.Windows.Forms.Button();
            this.div_butt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(91, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(309, 42);
            this.Title.TabIndex = 0;
            this.Title.Text = "Simple Calculator";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(45, 250);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 80);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(45, 190);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(400, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "starting";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // enter_butt
            // 
            this.enter_butt.BackColor = System.Drawing.Color.DimGray;
            this.enter_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.enter_butt.ForeColor = System.Drawing.Color.White;
            this.enter_butt.Location = new System.Drawing.Point(323, 427);
            this.enter_butt.Name = "enter_butt";
            this.enter_butt.Size = new System.Drawing.Size(100, 100);
            this.enter_butt.TabIndex = 3;
            this.enter_butt.Text = "Enter";
            this.enter_butt.UseVisualStyleBackColor = false;
            this.enter_butt.Click += new System.EventHandler(this.button1_Click);
            // 
            // plus_butt
            // 
            this.plus_butt.BackColor = System.Drawing.Color.DimGray;
            this.plus_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.plus_butt.ForeColor = System.Drawing.Color.White;
            this.plus_butt.Location = new System.Drawing.Point(77, 365);
            this.plus_butt.Name = "plus_butt";
            this.plus_butt.Size = new System.Drawing.Size(100, 100);
            this.plus_butt.TabIndex = 4;
            this.plus_butt.Text = "+";
            this.plus_butt.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.plus_butt.UseVisualStyleBackColor = false;
            this.plus_butt.Click += new System.EventHandler(this.plus_butt_Click);
            // 
            // minus_butt
            // 
            this.minus_butt.BackColor = System.Drawing.Color.DimGray;
            this.minus_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.minus_butt.ForeColor = System.Drawing.Color.White;
            this.minus_butt.Location = new System.Drawing.Point(201, 365);
            this.minus_butt.Name = "minus_butt";
            this.minus_butt.Size = new System.Drawing.Size(100, 100);
            this.minus_butt.TabIndex = 8;
            this.minus_butt.Text = "-";
            this.minus_butt.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.minus_butt.UseVisualStyleBackColor = false;
            this.minus_butt.Click += new System.EventHandler(this.minus_butt_Click_1);
            // 
            // mul_butt
            // 
            this.mul_butt.BackColor = System.Drawing.Color.DimGray;
            this.mul_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.mul_butt.ForeColor = System.Drawing.Color.White;
            this.mul_butt.Location = new System.Drawing.Point(77, 488);
            this.mul_butt.Name = "mul_butt";
            this.mul_butt.Size = new System.Drawing.Size(100, 100);
            this.mul_butt.TabIndex = 9;
            this.mul_butt.Text = "X";
            this.mul_butt.UseVisualStyleBackColor = false;
            // 
            // div_butt
            // 
            this.div_butt.BackColor = System.Drawing.Color.DimGray;
            this.div_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.div_butt.ForeColor = System.Drawing.Color.White;
            this.div_butt.Location = new System.Drawing.Point(201, 488);
            this.div_butt.Name = "div_butt";
            this.div_butt.Size = new System.Drawing.Size(100, 100);
            this.div_butt.TabIndex = 10;
            this.div_butt.Text = "/";
            this.div_butt.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.div_butt);
            this.Controls.Add(this.mul_butt);
            this.Controls.Add(this.minus_butt);
            this.Controls.Add(this.plus_butt);
            this.Controls.Add(this.enter_butt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Title);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enter_butt;
        private System.Windows.Forms.Button plus_butt;
        private System.Windows.Forms.Button minus_butt;
        private System.Windows.Forms.Button mul_butt;
        private System.Windows.Forms.Button div_butt;
    }
}

