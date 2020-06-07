namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox = new System.Windows.Forms.TextBox();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bEqual = new System.Windows.Forms.Button();
            this.bDivide = new System.Windows.Forms.Button();
            this.bMultiply = new System.Windows.Forms.Button();
            this.bSubtract = new System.Windows.Forms.Button();
            this.bPlus = new System.Windows.Forms.Button();
            this.bClean = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bSquare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox.Location = new System.Drawing.Point(5, 26);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(247, 26);
            this.textBox.TabIndex = 2;
            this.textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(12, 71);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(54, 41);
            this.b7.TabIndex = 4;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b8
            // 
            this.b8.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.b8.Location = new System.Drawing.Point(72, 71);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(54, 41);
            this.b8.TabIndex = 5;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(132, 71);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(54, 41);
            this.b9.TabIndex = 6;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(12, 118);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(54, 41);
            this.b4.TabIndex = 7;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(72, 118);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(54, 41);
            this.b5.TabIndex = 8;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(132, 118);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(54, 41);
            this.b6.TabIndex = 9;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(12, 165);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(54, 41);
            this.b1.TabIndex = 10;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(72, 165);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(54, 41);
            this.b2.TabIndex = 11;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(132, 165);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(54, 41);
            this.b3.TabIndex = 12;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(12, 212);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(54, 41);
            this.b0.TabIndex = 13;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // bEqual
            // 
            this.bEqual.Location = new System.Drawing.Point(12, 259);
            this.bEqual.Name = "bEqual";
            this.bEqual.Size = new System.Drawing.Size(234, 41);
            this.bEqual.TabIndex = 14;
            this.bEqual.Text = "=";
            this.bEqual.UseVisualStyleBackColor = true;
            this.bEqual.Click += new System.EventHandler(this.bEqual_Click);
            // 
            // bDivide
            // 
            this.bDivide.Location = new System.Drawing.Point(132, 212);
            this.bDivide.Name = "bDivide";
            this.bDivide.Size = new System.Drawing.Size(54, 41);
            this.bDivide.TabIndex = 15;
            this.bDivide.Text = "/";
            this.bDivide.UseVisualStyleBackColor = true;
            this.bDivide.Click += new System.EventHandler(this.bDivide_Click);
            // 
            // bMultiply
            // 
            this.bMultiply.Location = new System.Drawing.Point(72, 212);
            this.bMultiply.Name = "bMultiply";
            this.bMultiply.Size = new System.Drawing.Size(54, 41);
            this.bMultiply.TabIndex = 16;
            this.bMultiply.Text = "x";
            this.bMultiply.UseVisualStyleBackColor = true;
            this.bMultiply.Click += new System.EventHandler(this.bMultiply_Click);
            // 
            // bSubtract
            // 
            this.bSubtract.Location = new System.Drawing.Point(192, 165);
            this.bSubtract.Name = "bSubtract";
            this.bSubtract.Size = new System.Drawing.Size(54, 41);
            this.bSubtract.TabIndex = 17;
            this.bSubtract.Text = "-";
            this.bSubtract.UseVisualStyleBackColor = true;
            this.bSubtract.Click += new System.EventHandler(this.bSubtract_Click);
            // 
            // bPlus
            // 
            this.bPlus.Location = new System.Drawing.Point(192, 118);
            this.bPlus.Name = "bPlus";
            this.bPlus.Size = new System.Drawing.Size(54, 41);
            this.bPlus.TabIndex = 18;
            this.bPlus.Text = "+";
            this.bPlus.UseVisualStyleBackColor = true;
            this.bPlus.Click += new System.EventHandler(this.bPlus_Click);
            // 
            // bClean
            // 
            this.bClean.Location = new System.Drawing.Point(192, 71);
            this.bClean.Name = "bClean";
            this.bClean.Size = new System.Drawing.Size(54, 41);
            this.bClean.TabIndex = 19;
            this.bClean.Text = "C";
            this.bClean.UseVisualStyleBackColor = true;
            this.bClean.Click += new System.EventHandler(this.bClean_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(5, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 13);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // bSquare
            // 
            this.bSquare.Location = new System.Drawing.Point(192, 212);
            this.bSquare.Name = "bSquare";
            this.bSquare.Size = new System.Drawing.Size(54, 41);
            this.bSquare.TabIndex = 21;
            this.bSquare.Text = "√";
            this.bSquare.UseVisualStyleBackColor = true;
            this.bSquare.Click += new System.EventHandler(this.bSquare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(255, 304);
            this.Controls.Add(this.bSquare);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bClean);
            this.Controls.Add(this.bPlus);
            this.Controls.Add(this.bSubtract);
            this.Controls.Add(this.bMultiply);
            this.Controls.Add(this.bDivide);
            this.Controls.Add(this.bEqual);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Kalkulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bEqual;
        private System.Windows.Forms.Button bDivide;
        private System.Windows.Forms.Button bMultiply;
        private System.Windows.Forms.Button bSubtract;
        private System.Windows.Forms.Button bPlus;
        private System.Windows.Forms.Button bClean;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bSquare;
    }
}

