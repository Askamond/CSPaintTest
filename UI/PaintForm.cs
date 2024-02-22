using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVP.Model;
using MVP.Presentation.Common;
using MVP.Presentation.Presenters;
using MVP.Presentation.Views;

namespace MVP.UI
{
    public partial class PaintForm : Form, IPaintView
    {

        private readonly ApplicationContext _context;

        //Variables for drawiing
        Bitmap bitmap;
        Graphics graphics;
        bool isPaint;
        Point pointX, pointY, startPoint, endPoint;
        Pen pen, eraser;
        DrawType drawType;


        public Point LastClick { get; set; }


        ColorDialog colorDialog;
        Color newColor;


        public PaintForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();

            colorDialog = new ColorDialog();

            this.Width = 1000;
            this.Height = 750;
            bitmap = new Bitmap(paintSpace.Width, paintSpace.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            paintSpace.Image = bitmap;
            isPaint = false;
            pen = new Pen(Color.Black, 1);
            eraser = new Pen(Color.White, 10);
            drawType = DrawType.Pen;

            curColor.BackColor = pen.Color;
        }

        public new void Show()
        {
            _context.MainForm = this;
            Application.Run(_context);
        }

        private void Invoke(Action action)
        {
            action?.Invoke();
        }

        public event Action FetchColor;

        public PictureBox GetPaletImage()
        { return pictureBox1; }

        #region OnClick drawing change
        private void pencilButton_Click(object sender, EventArgs e)
        {
            drawType = DrawType.Pen;
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            drawType= DrawType.Ellipse;
        }

        private void buttonRect_Click(object sender, EventArgs e)
        {
            drawType = DrawType.Rect;
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            drawType = DrawType.Line;
        }

        private void buttonEraser_Click(object sender, EventArgs e)
        {
            drawType = DrawType.Eraser;
        }


        #endregion

        #region Mouse Behaviour

        private void paintSpace_MouseDown(object sender, MouseEventArgs e)
        {
            isPaint = true;
            pointY = startPoint = e.Location;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            paintSpace.Image = bitmap;
            drawType = DrawType.Pen;
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            SetPenColor(colorDialog.Color);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            LastClick = e.Location;
            Invoke(FetchColor);
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            var saveFileDialogue = new SaveFileDialog();
            saveFileDialogue.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";
            if (saveFileDialogue.ShowDialog() == DialogResult.OK)
            {
                Bitmap _bitmap = bitmap.Clone(new Rectangle(0,0,paintSpace.Width,paintSpace.Height), bitmap.PixelFormat);
                _bitmap.Save(saveFileDialogue.FileName, ImageFormat.Jpeg);
                MessageBox.Show("Image Saved!");
            }

        }

        private void paintSpace_MouseUp(object sender, MouseEventArgs e)
        {
            isPaint = false;

            if (drawType == DrawType.Ellipse)
                graphics.DrawEllipse(pen, startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y);
            else if (drawType == DrawType.Rect)
                graphics.DrawRectangle(pen, startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y);
            else if (drawType == DrawType.Line)
                graphics.DrawLine(pen, startPoint, endPoint);
        }

        private void paintSpace_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPaint)
                if (drawType == DrawType.Pen) {
                    pointX = e.Location;
                    graphics.DrawLine(pen, pointX, pointY);
                    pointY = pointX;
                }
                else if (drawType == DrawType.Eraser) {
                    pointX = e.Location;
                    graphics.DrawLine(eraser, pointX, pointY);
                    pointY = pointX;
                }

            endPoint = e.Location;

            paintSpace.Refresh();

        }

        #endregion

        private void paintSpace_Paint(object sender, PaintEventArgs e)
        {
            Graphics _graphics = e.Graphics;
            
            if (isPaint)
                if (drawType == DrawType.Ellipse)
                    _graphics.DrawEllipse(pen, startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y);
                else if (drawType == DrawType.Rect)
                    _graphics.DrawRectangle(pen, startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y);
                else if (drawType == DrawType.Line)
                    _graphics.DrawLine(pen, startPoint, endPoint);
        }

        public void SetPenColor(Color color) 
        {
            curColor.BackColor = color;
            pen.Color = color;
        }


    }
}
