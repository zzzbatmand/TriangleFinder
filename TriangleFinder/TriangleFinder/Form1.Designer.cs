namespace TriangleFinder
{
    partial class TriangleFinder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TriangleFinder));
            this.methodLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.methodBox = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.refImage = new System.Windows.Forms.PictureBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.TextBox();
            this.b2 = new System.Windows.Forms.TextBox();
            this.a2 = new System.Windows.Forms.TextBox();
            this.c1 = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.TextBox();
            this.a1 = new System.Windows.Forms.TextBox();
            this.background = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.refImage)).BeginInit();
            this.SuspendLayout();
            // 
            // methodLabel
            // 
            this.methodLabel.AutoSize = true;
            this.methodLabel.Location = new System.Drawing.Point(177, 8);
            this.methodLabel.Name = "methodLabel";
            this.methodLabel.Size = new System.Drawing.Size(97, 13);
            this.methodLabel.TabIndex = 55;
            this.methodLabel.Text = "Calculation method";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(12, 8);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(85, 13);
            this.resultLabel.TabIndex = 54;
            this.resultLabel.Text = "Calculated result";
            // 
            // methodBox
            // 
            this.methodBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.methodBox.Location = new System.Drawing.Point(180, 26);
            this.methodBox.Multiline = true;
            this.methodBox.Name = "methodBox";
            this.methodBox.ReadOnly = true;
            this.methodBox.Size = new System.Drawing.Size(240, 79);
            this.methodBox.TabIndex = 53;
            // 
            // resultBox
            // 
            this.resultBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.Location = new System.Drawing.Point(17, 27);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(158, 78);
            this.resultBox.TabIndex = 52;
            this.resultBox.Text = "Find triangle info";
            // 
            // refImage
            // 
            this.refImage.Image = ((System.Drawing.Image)(resources.GetObject("refImage.Image")));
            this.refImage.Location = new System.Drawing.Point(429, 23);
            this.refImage.Name = "refImage";
            this.refImage.Size = new System.Drawing.Size(188, 141);
            this.refImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refImage.TabIndex = 51;
            this.refImage.TabStop = false;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(348, 113);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 50;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(302, 115);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(40, 20);
            this.textBox6.TabIndex = 49;
            this.textBox6.Text = "    C";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(244, 115);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(52, 20);
            this.textBox5.TabIndex = 48;
            this.textBox5.Text = "       B";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(186, 115);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(52, 20);
            this.textBox4.TabIndex = 47;
            this.textBox4.Text = "       A";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(128, 115);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(52, 20);
            this.textBox3.TabIndex = 46;
            this.textBox3.Text = "       c";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(70, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(52, 20);
            this.textBox2.TabIndex = 45;
            this.textBox2.Text = "       b";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(52, 20);
            this.textBox1.TabIndex = 44;
            this.textBox1.Text = "       a";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(348, 141);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 43;
            this.submitButton.Text = "Enter";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // c2
            // 
            this.c2.Location = new System.Drawing.Point(302, 143);
            this.c2.Name = "c2";
            this.c2.ReadOnly = true;
            this.c2.Size = new System.Drawing.Size(40, 20);
            this.c2.TabIndex = 42;
            this.c2.Text = "90";
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(244, 143);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(52, 20);
            this.b2.TabIndex = 41;
            this.b2.Text = "0";
            this.b2.TextChanged += new System.EventHandler(this.global_TextChanged);
            // 
            // a2
            // 
            this.a2.Location = new System.Drawing.Point(186, 143);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(52, 20);
            this.a2.TabIndex = 40;
            this.a2.Text = "0";
            this.a2.TextChanged += new System.EventHandler(this.global_TextChanged);
            // 
            // c1
            // 
            this.c1.Location = new System.Drawing.Point(128, 143);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(52, 20);
            this.c1.TabIndex = 39;
            this.c1.Text = "0";
            this.c1.TextChanged += new System.EventHandler(this.global_TextChanged);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(70, 143);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(52, 20);
            this.b1.TabIndex = 38;
            this.b1.Text = "0";
            this.b1.TextChanged += new System.EventHandler(this.global_TextChanged);
            // 
            // a1
            // 
            this.a1.Location = new System.Drawing.Point(12, 143);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(52, 20);
            this.a1.TabIndex = 37;
            this.a1.Text = "0";
            this.a1.TextChanged += new System.EventHandler(this.global_TextChanged);
            // 
            // background
            // 
            this.background.Location = new System.Drawing.Point(12, 23);
            this.background.Multiline = true;
            this.background.Name = "background";
            this.background.ReadOnly = true;
            this.background.Size = new System.Drawing.Size(411, 86);
            this.background.TabIndex = 36;
            // 
            // TriangleFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 176);
            this.Controls.Add(this.methodLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.methodBox);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.refImage);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TriangleFinder";
            this.Text = "Triangle Finder";
            ((System.ComponentModel.ISupportInitialize)(this.refImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label methodLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox methodBox;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.PictureBox refImage;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox c2;
        private System.Windows.Forms.TextBox b2;
        private System.Windows.Forms.TextBox a2;
        private System.Windows.Forms.TextBox c1;
        private System.Windows.Forms.TextBox b1;
        private System.Windows.Forms.TextBox a1;
        private System.Windows.Forms.TextBox background;
    }
}

