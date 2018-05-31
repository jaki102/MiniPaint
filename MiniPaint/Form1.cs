using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Resources;

namespace MiniPaint
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private Point p = Point.Empty;
        private Pen pen;
        Stack<Bitmap> undoStack = new Stack<Bitmap>();
        Stack<Bitmap> redoStack = new Stack<Bitmap>();

        public Form1()
        {
            InitializeComponent();
            imgPicture.Image = new Bitmap(570, 580);
            g = Graphics.FromImage(imgPicture.Image);
            pen = new Pen(Color.Black);
        }

        private void imgPicture_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                p = e.Location;
        }

        private void imgPicture_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pen = new Pen(pen.Color, sizeBar.Value);
                g.DrawLine(pen, p, e.Location);
                p = e.Location;

                imgPicture.Refresh();
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Bitmap bmap = new Bitmap(570, 580);
            imgPicture.Image = bmap;
            g = Graphics.FromImage(imgPicture.Image);
            imgPicture.Refresh();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = IdColor.BackColor;
            dialog.ShowDialog();
            IdColor.BackColor = dialog.Color;
            pen.Color = dialog.Color;
        }

        private void imgPicture_MouseUp(object sender, MouseEventArgs e)
        {
            Bitmap image = new Bitmap(imgPicture.Image);
            undoStack.Push(image);
            btnUndo.Enabled = true;
        }

        private void btnSquere_Click(object sender, EventArgs e)
        {

        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if(undoStack.Count != 0) { 
                Bitmap undoImage = undoStack.Pop();
                imgPicture.Image = undoImage;
                redoStack.Push(undoImage);
                btnRedo.Enabled = true;
                g = Graphics.FromImage(imgPicture.Image);
                imgPicture.Refresh();
            }
            else
            {
                btnUndo.Enabled = false;
            }

        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            if (redoStack.Count != 0)
            {
                Bitmap redoImage = redoStack.Pop();
                imgPicture.Image = redoImage;
                undoStack.Push(redoImage);
            }
            else
            {
                btnRedo.Enabled = false;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Bitmaps|*.bmp|jpeps|*.jpg";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imgPicture.Image = Bitmap.FromFile(openFileDialog.FileName);
                g = Graphics.FromImage(imgPicture.Image);
                imgPicture.Refresh();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Bitmaps|*.bmp|jpeps|*.jpg";
            dialog.ShowDialog();
            if (dialog.FileName != "")
            {
                imgPicture.Image.Save(dialog.FileName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void polishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assembly a = Assembly.Load("MiniPaint");
            ResourceManager rm = new ResourceManager("MiniPaint.Lang.langResourcePl", a);
            fileToolStripMenuItem.Text = rm.GetString("fileToolStripMenuItem");
            languageToolStripMenuItem.Text = rm.GetString("languageToolStripMenuItem");
            openToolStripMenuItem.Text = rm.GetString("open");
            saveToolStripMenuItem.Text = rm.GetString("save");
            exitToolStripMenuItem.Text = rm.GetString("exit");
            polishToolStripMenuItem.Text = rm.GetString("polish");
            englishToolStripMenuItem.Text = rm.GetString("english");
            groupBoxAction.Text = rm.GetString("action");
            groupBoxShape.Text = rm.GetString("shape");
            groupBoxColor.Text = rm.GetString("color");
            groupBoxSize.Text = rm.GetString("size");
            btnColor.Text = rm.GetString("color");
            btnUndo.Text = rm.GetString("undo");
            btnRedo.Text = rm.GetString("redo");
            btnClean.Text = rm.GetString("clean");
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assembly b = Assembly.Load("MiniPaint");
            ResourceManager rm = new ResourceManager("MiniPaint.Lang.langResource", b);
            fileToolStripMenuItem.Text = rm.GetString("fileToolStripMenuItem");
            languageToolStripMenuItem.Text = rm.GetString("languageToolStripMenuItem");
            openToolStripMenuItem.Text = rm.GetString("open");
            saveToolStripMenuItem.Text = rm.GetString("save");
            exitToolStripMenuItem.Text = rm.GetString("exit");
            polishToolStripMenuItem.Text = rm.GetString("polish");
            englishToolStripMenuItem.Text = rm.GetString("english");
            groupBoxAction.Text = rm.GetString("action");
            groupBoxShape.Text = rm.GetString("shape");
            groupBoxColor.Text = rm.GetString("color");
            groupBoxSize.Text = rm.GetString("size");
            btnColor.Text = rm.GetString("color");
            btnUndo.Text = rm.GetString("undo");
            btnRedo.Text = rm.GetString("redo");
            btnClean.Text = rm.GetString("clean");
        }
    }
}
