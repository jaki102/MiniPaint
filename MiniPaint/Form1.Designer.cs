namespace MiniPaint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgPicture = new System.Windows.Forms.PictureBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.IdColor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEllips = new System.Windows.Forms.Button();
            this.btnSquere = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPicture)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.imgPicture);
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 500);
            this.panel1.TabIndex = 0;
            // 
            // imgPicture
            // 
            this.imgPicture.Location = new System.Drawing.Point(0, 0);
            this.imgPicture.Name = "imgPicture";
            this.imgPicture.Size = new System.Drawing.Size(500, 500);
            this.imgPicture.TabIndex = 0;
            this.imgPicture.TabStop = false;
            this.imgPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgPicture_MouseDown);
            this.imgPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgPicture_MouseMove);
            this.imgPicture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imgPicture_MouseUp);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(32, 89);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(80, 30);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(32, 103);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(80, 30);
            this.btnClean.TabIndex = 2;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(32, 67);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // IdColor
            // 
            this.IdColor.BackColor = System.Drawing.Color.Black;
            this.IdColor.Location = new System.Drawing.Point(49, 29);
            this.IdColor.Name = "IdColor";
            this.IdColor.Size = new System.Drawing.Size(47, 44);
            this.IdColor.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEllips);
            this.groupBox1.Controls.Add(this.btnSquere);
            this.groupBox1.Controls.Add(this.btnLine);
            this.groupBox1.Location = new System.Drawing.Point(543, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 137);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shapes";
            // 
            // btnEllips
            // 
            this.btnEllips.Location = new System.Drawing.Point(32, 93);
            this.btnEllips.Name = "btnEllips";
            this.btnEllips.Size = new System.Drawing.Size(80, 30);
            this.btnEllips.TabIndex = 4;
            this.btnEllips.Text = "Ellipse";
            this.btnEllips.UseVisualStyleBackColor = true;
            // 
            // btnSquere
            // 
            this.btnSquere.Location = new System.Drawing.Point(32, 57);
            this.btnSquere.Name = "btnSquere";
            this.btnSquere.Size = new System.Drawing.Size(80, 30);
            this.btnSquere.TabIndex = 3;
            this.btnSquere.Text = "Square";
            this.btnSquere.UseVisualStyleBackColor = true;
            this.btnSquere.Click += new System.EventHandler(this.btnSquere_Click);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(32, 21);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(80, 30);
            this.btnLine.TabIndex = 2;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.IdColor);
            this.groupBox2.Controls.Add(this.btnColor);
            this.groupBox2.Location = new System.Drawing.Point(543, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 129);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRedo);
            this.groupBox3.Controls.Add(this.btnOpen);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.btnUndo);
            this.groupBox3.Controls.Add(this.btnClean);
            this.groupBox3.Location = new System.Drawing.Point(543, 298);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(145, 222);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action";
            // 
            // btnRedo
            // 
            this.btnRedo.Enabled = false;
            this.btnRedo.Location = new System.Drawing.Point(32, 175);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(80, 30);
            this.btnRedo.TabIndex = 6;
            this.btnRedo.Text = "Redo";
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(32, 31);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(80, 30);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Enabled = false;
            this.btnUndo.Location = new System.Drawing.Point(32, 139);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(80, 30);
            this.btnUndo.TabIndex = 5;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(715, 551);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MiniPaint";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgPicture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label IdColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEllips;
        private System.Windows.Forms.Button btnSquere;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.PictureBox imgPicture;
    }
}

