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
            this.IdColor = new System.Windows.Forms.Label();
            this.groupBoxShape = new System.Windows.Forms.GroupBox();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnEllips = new System.Windows.Forms.Button();
            this.btnSquere = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.groupBoxAction = new System.Windows.Forms.GroupBox();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxSize = new System.Windows.Forms.GroupBox();
            this.sizeBar = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPicture)).BeginInit();
            this.groupBoxShape.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.groupBoxAction.SuspendLayout();
            this.menu.SuspendLayout();
            this.groupBoxSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.imgPicture);
            this.panel1.Location = new System.Drawing.Point(20, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 580);
            this.panel1.TabIndex = 0;
            // 
            // imgPicture
            // 
            this.imgPicture.Location = new System.Drawing.Point(0, 0);
            this.imgPicture.Name = "imgPicture";
            this.imgPicture.Size = new System.Drawing.Size(570, 580);
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
            this.btnClean.Location = new System.Drawing.Point(32, 30);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(80, 30);
            this.btnClean.TabIndex = 2;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // IdColor
            // 
            this.IdColor.BackColor = System.Drawing.Color.Black;
            this.IdColor.Location = new System.Drawing.Point(49, 29);
            this.IdColor.Name = "IdColor";
            this.IdColor.Size = new System.Drawing.Size(47, 44);
            this.IdColor.TabIndex = 4;
            // 
            // groupBoxShape
            // 
            this.groupBoxShape.Controls.Add(this.btnCircle);
            this.groupBoxShape.Controls.Add(this.btnEllips);
            this.groupBoxShape.Controls.Add(this.btnSquere);
            this.groupBoxShape.Controls.Add(this.btnLine);
            this.groupBoxShape.Location = new System.Drawing.Point(619, 39);
            this.groupBoxShape.Name = "groupBoxShape";
            this.groupBoxShape.Size = new System.Drawing.Size(145, 183);
            this.groupBoxShape.TabIndex = 5;
            this.groupBoxShape.TabStop = false;
            this.groupBoxShape.Text = "Shapes";
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(32, 138);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(80, 30);
            this.btnCircle.TabIndex = 5;
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = true;
            // 
            // btnEllips
            // 
            this.btnEllips.Location = new System.Drawing.Point(32, 102);
            this.btnEllips.Name = "btnEllips";
            this.btnEllips.Size = new System.Drawing.Size(80, 30);
            this.btnEllips.TabIndex = 4;
            this.btnEllips.Text = "Ellipse";
            this.btnEllips.UseVisualStyleBackColor = true;
            // 
            // btnSquere
            // 
            this.btnSquere.Location = new System.Drawing.Point(32, 66);
            this.btnSquere.Name = "btnSquere";
            this.btnSquere.Size = new System.Drawing.Size(80, 30);
            this.btnSquere.TabIndex = 3;
            this.btnSquere.Text = "Square";
            this.btnSquere.UseVisualStyleBackColor = true;
            this.btnSquere.Click += new System.EventHandler(this.btnSquere_Click);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(32, 30);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(80, 30);
            this.btnLine.TabIndex = 2;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = true;
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.IdColor);
            this.groupBoxColor.Controls.Add(this.btnColor);
            this.groupBoxColor.Location = new System.Drawing.Point(619, 228);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(145, 129);
            this.groupBoxColor.TabIndex = 6;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Color";
            // 
            // groupBoxAction
            // 
            this.groupBoxAction.Controls.Add(this.btnRedo);
            this.groupBoxAction.Controls.Add(this.btnUndo);
            this.groupBoxAction.Controls.Add(this.btnClean);
            this.groupBoxAction.Location = new System.Drawing.Point(619, 458);
            this.groupBoxAction.Name = "groupBoxAction";
            this.groupBoxAction.Size = new System.Drawing.Size(145, 152);
            this.groupBoxAction.TabIndex = 7;
            this.groupBoxAction.TabStop = false;
            this.groupBoxAction.Text = "Actions";
            // 
            // btnRedo
            // 
            this.btnRedo.Enabled = false;
            this.btnRedo.Location = new System.Drawing.Point(32, 102);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(80, 30);
            this.btnRedo.TabIndex = 6;
            this.btnRedo.Text = "Redo";
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Enabled = false;
            this.btnUndo.Location = new System.Drawing.Point(32, 66);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(80, 30);
            this.btnUndo.TabIndex = 5;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Control;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(786, 28);
            this.menu.TabIndex = 8;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.polishToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // polishToolStripMenuItem
            // 
            this.polishToolStripMenuItem.Name = "polishToolStripMenuItem";
            this.polishToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.polishToolStripMenuItem.Text = "Polish";
            this.polishToolStripMenuItem.Click += new System.EventHandler(this.polishToolStripMenuItem_Click);
            // 
            // groupBoxSize
            // 
            this.groupBoxSize.Controls.Add(this.sizeBar);
            this.groupBoxSize.Location = new System.Drawing.Point(619, 363);
            this.groupBoxSize.Name = "groupBoxSize";
            this.groupBoxSize.Size = new System.Drawing.Size(145, 89);
            this.groupBoxSize.TabIndex = 9;
            this.groupBoxSize.TabStop = false;
            this.groupBoxSize.Text = "Size";
            // 
            // sizeBar
            // 
            this.sizeBar.Location = new System.Drawing.Point(6, 27);
            this.sizeBar.Minimum = 1;
            this.sizeBar.Name = "sizeBar";
            this.sizeBar.Size = new System.Drawing.Size(133, 56);
            this.sizeBar.TabIndex = 0;
            this.sizeBar.Value = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(786, 646);
            this.Controls.Add(this.groupBoxSize);
            this.Controls.Add(this.groupBoxAction);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.groupBoxShape);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MiniPaint";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgPicture)).EndInit();
            this.groupBoxShape.ResumeLayout(false);
            this.groupBoxColor.ResumeLayout(false);
            this.groupBoxAction.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.groupBoxSize.ResumeLayout(false);
            this.groupBoxSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label IdColor;
        private System.Windows.Forms.GroupBox groupBoxShape;
        private System.Windows.Forms.Button btnEllips;
        private System.Windows.Forms.Button btnSquere;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.GroupBox groupBoxAction;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.PictureBox imgPicture;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.GroupBox groupBoxSize;
        private System.Windows.Forms.TrackBar sizeBar;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polishToolStripMenuItem;
    }
}

