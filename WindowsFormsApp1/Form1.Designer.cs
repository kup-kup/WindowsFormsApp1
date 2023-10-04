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
            this.main_textbox = new System.Windows.Forms.TextBox();
            this.memo_label = new System.Windows.Forms.Label();
            this.enter_butt = new System.Windows.Forms.Button();
            this.plus_butt = new System.Windows.Forms.Button();
            this.minus_butt = new System.Windows.Forms.Button();
            this.mul_butt = new System.Windows.Forms.Button();
            this.div_butt = new System.Windows.Forms.Button();
            this.cleat_butt = new System.Windows.Forms.Button();
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
            // main_textbox
            // 
            this.main_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.main_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.main_textbox.ForeColor = System.Drawing.Color.White;
            this.main_textbox.Location = new System.Drawing.Point(45, 250);
            this.main_textbox.Name = "main_textbox";
            this.main_textbox.Size = new System.Drawing.Size(400, 80);
            this.main_textbox.TabIndex = 1;
            this.main_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.main_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // memo_label
            // 
            this.memo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.memo_label.ForeColor = System.Drawing.Color.DarkGray;
            this.memo_label.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.memo_label.Location = new System.Drawing.Point(45, 190);
            this.memo_label.Name = "memo_label";
            this.memo_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.memo_label.Size = new System.Drawing.Size(400, 48);
            this.memo_label.TabIndex = 2;
            this.memo_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.memo_label.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // enter_butt
            // 
            this.enter_butt.BackColor = System.Drawing.Color.DimGray;
            this.enter_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.enter_butt.ForeColor = System.Drawing.Color.White;
            this.enter_butt.Location = new System.Drawing.Point(328, 365);
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
            this.mul_butt.Click += new System.EventHandler(this.mul_butt_Click);
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
            this.div_butt.Click += new System.EventHandler(this.div_butt_Click);
            // 
            // cleat_butt
            // 
            this.cleat_butt.BackColor = System.Drawing.Color.DimGray;
            this.cleat_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cleat_butt.ForeColor = System.Drawing.Color.White;
            this.cleat_butt.Location = new System.Drawing.Point(328, 488);
            this.cleat_butt.Name = "cleat_butt";
            this.cleat_butt.Size = new System.Drawing.Size(100, 100);
            this.cleat_butt.TabIndex = 11;
            this.cleat_butt.Text = "Clear";
            this.cleat_butt.UseVisualStyleBackColor = false;
            this.cleat_butt.Click += new System.EventHandler(this.cleat_butt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.cleat_butt);
            this.Controls.Add(this.div_butt);
            this.Controls.Add(this.mul_butt);
            this.Controls.Add(this.minus_butt);
            this.Controls.Add(this.plus_butt);
            this.Controls.Add(this.enter_butt);
            this.Controls.Add(this.memo_label);
            this.Controls.Add(this.main_textbox);
            this.Controls.Add(this.Title);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox main_textbox;
        private System.Windows.Forms.Label memo_label;
        private System.Windows.Forms.Button enter_butt;
        private System.Windows.Forms.Button plus_butt;
        private System.Windows.Forms.Button minus_butt;
        private System.Windows.Forms.Button mul_butt;
        private System.Windows.Forms.Button div_butt;
        private System.Windows.Forms.Button cleat_butt;
    }
}

