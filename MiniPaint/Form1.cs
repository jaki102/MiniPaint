using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPaint
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private Point p = Point.Empty;
        private Pen pen;
        Stack<Bitmap> undoStack = new Stack<Bitmap>();
        Stack<Bitmap> redoStack=new Stack<Bitmap>();

        public Form1()
        {
            InitializeComponent();
            imgPicture.Image = new Bitmap(400, 400);
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
                g.DrawLine(pen, p, e.Location);
                p = e.Location;

                imgPicture.Refresh();
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "bmp|*.bmp";
            dialog.ShowDialog();
            if (dialog.FileName != "") { 
                imgPicture.Image.Save(dialog.FileName);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Bitmaps|*.bmp|jpeps|*.jpg";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imgPicture.Image = Bitmap.FromFile(openFileDialog.FileName);
            }
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
    }
}
