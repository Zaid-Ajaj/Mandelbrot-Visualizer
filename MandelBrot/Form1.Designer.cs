namespace MandelBrot
{
    partial class MandelbrotVisualizer
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
            this.mandelPictureBox = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label12 = new System.Windows.Forms.Label();
            this.txtZoomBoxSize = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtImaginary = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtReal = new System.Windows.Forms.TextBox();
            this.withParameter = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRedraw = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaxImaginary = new System.Windows.Forms.TextBox();
            this.txtMinImaginary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxReal = new System.Windows.Forms.TextBox();
            this.txtMinReal = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mandelPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mandelPictureBox
            // 
            this.mandelPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mandelPictureBox.Location = new System.Drawing.Point(0, 0);
            this.mandelPictureBox.Name = "mandelPictureBox";
            this.mandelPictureBox.Size = new System.Drawing.Size(627, 514);
            this.mandelPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mandelPictureBox.TabIndex = 0;
            this.mandelPictureBox.TabStop = false;
            this.mandelPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mandelPictureBox_MouseClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.txtZoomBoxSize);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.btnReset);
            this.splitContainer1.Panel1.Controls.Add(this.txtImaginary);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.txtReal);
            this.splitContainer1.Panel1.Controls.Add(this.withParameter);
            this.splitContainer1.Panel1.Controls.Add(this.btnSave);
            this.splitContainer1.Panel1.Controls.Add(this.btnRedraw);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.txtMaxImaginary);
            this.splitContainer1.Panel1.Controls.Add(this.txtMinImaginary);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtMaxReal);
            this.splitContainer1.Panel1.Controls.Add(this.txtMinReal);
            this.splitContainer1.Panel1.Controls.Add(this.txtWidth);
            this.splitContainer1.Panel1.Controls.Add(this.txtHeight);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mandelPictureBox);
            this.splitContainer1.Size = new System.Drawing.Size(796, 514);
            this.splitContainer1.SplitterDistance = 165;
            this.splitContainer1.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 380);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Size";
            // 
            // txtZoomBoxSize
            // 
            this.txtZoomBoxSize.Location = new System.Drawing.Point(49, 377);
            this.txtZoomBoxSize.Name = "txtZoomBoxSize";
            this.txtZoomBoxSize.Size = new System.Drawing.Size(73, 20);
            this.txtZoomBoxSize.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Zoom box";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(18, 450);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(118, 23);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtImaginary
            // 
            this.txtImaginary.Location = new System.Drawing.Point(48, 312);
            this.txtImaginary.Name = "txtImaginary";
            this.txtImaginary.Size = new System.Drawing.Size(73, 20);
            this.txtImaginary.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Im";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Re";
            // 
            // txtReal
            // 
            this.txtReal.Location = new System.Drawing.Point(49, 286);
            this.txtReal.Name = "txtReal";
            this.txtReal.Size = new System.Drawing.Size(73, 20);
            this.txtReal.TabIndex = 17;
            // 
            // withParameter
            // 
            this.withParameter.AutoSize = true;
            this.withParameter.Location = new System.Drawing.Point(15, 263);
            this.withParameter.Name = "withParameter";
            this.withParameter.Size = new System.Drawing.Size(99, 17);
            this.withParameter.TabIndex = 16;
            this.withParameter.Text = "With Parameter";
            this.withParameter.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(18, 479);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRedraw
            // 
            this.btnRedraw.Location = new System.Drawing.Point(18, 421);
            this.btnRedraw.Name = "btnRedraw";
            this.btnRedraw.Size = new System.Drawing.Size(118, 23);
            this.btnRedraw.TabIndex = 14;
            this.btnRedraw.Text = "Redraw";
            this.btnRedraw.UseVisualStyleBackColor = true;
            this.btnRedraw.Click += new System.EventHandler(this.btnRedraw_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "To";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "From";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Imaginary Range";
            // 
            // txtMaxImaginary
            // 
            this.txtMaxImaginary.Location = new System.Drawing.Point(49, 221);
            this.txtMaxImaginary.Name = "txtMaxImaginary";
            this.txtMaxImaginary.Size = new System.Drawing.Size(102, 20);
            this.txtMaxImaginary.TabIndex = 10;
            // 
            // txtMinImaginary
            // 
            this.txtMinImaginary.Location = new System.Drawing.Point(49, 195);
            this.txtMinImaginary.Name = "txtMinImaginary";
            this.txtMinImaginary.Size = new System.Drawing.Size(102, 20);
            this.txtMinImaginary.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Real Range";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Width";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Height";
            // 
            // txtMaxReal
            // 
            this.txtMaxReal.Location = new System.Drawing.Point(48, 130);
            this.txtMaxReal.Name = "txtMaxReal";
            this.txtMaxReal.Size = new System.Drawing.Size(103, 20);
            this.txtMaxReal.TabIndex = 3;
            // 
            // txtMinReal
            // 
            this.txtMinReal.Location = new System.Drawing.Point(48, 104);
            this.txtMinReal.Name = "txtMinReal";
            this.txtMinReal.Size = new System.Drawing.Size(103, 20);
            this.txtMinReal.TabIndex = 2;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(70, 39);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(81, 20);
            this.txtWidth.TabIndex = 1;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(70, 13);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(81, 20);
            this.txtHeight.TabIndex = 0;
            // 
            // MandelbrotVisualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 514);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MandelbrotVisualizer";
            this.Text = "Mandelbrot Set Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.mandelPictureBox)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mandelPictureBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaxImaginary;
        private System.Windows.Forms.TextBox txtMinImaginary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaxReal;
        private System.Windows.Forms.TextBox txtMinReal;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button btnRedraw;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtImaginary;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtReal;
        private System.Windows.Forms.CheckBox withParameter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtZoomBoxSize;
        private System.Windows.Forms.Label label11;
    }
}

