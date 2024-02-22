namespace MVP.UI
{
    partial class PaintForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolBar = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.curColor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonTriangle = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.colorButton = new System.Windows.Forms.Button();
            this.pencilButton = new System.Windows.Forms.Button();
            this.buttonRect = new System.Windows.Forms.Button();
            this.buttonEraser = new System.Windows.Forms.Button();
            this.buttonEllipse = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.paintSpace = new System.Windows.Forms.PictureBox();
            this.toolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paintSpace)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.toolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolBar.Controls.Add(this.saveButton);
            this.toolBar.Controls.Add(this.clearButton);
            this.toolBar.Controls.Add(this.pictureBox1);
            this.toolBar.Controls.Add(this.curColor);
            this.toolBar.Controls.Add(this.panel1);
            this.toolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(984, 105);
            this.toolBar.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(861, 10);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 30);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.clearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(861, 55);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(120, 30);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::UI.Properties.Resources.color_palette;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // curColor
            // 
            this.curColor.BackColor = System.Drawing.Color.White;
            this.curColor.Location = new System.Drawing.Point(228, 34);
            this.curColor.Name = "curColor";
            this.curColor.Size = new System.Drawing.Size(42, 35);
            this.curColor.TabIndex = 0;
            this.curColor.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.buttonTriangle);
            this.panel1.Controls.Add(this.buttonLine);
            this.panel1.Controls.Add(this.colorButton);
            this.panel1.Controls.Add(this.pencilButton);
            this.panel1.Controls.Add(this.buttonRect);
            this.panel1.Controls.Add(this.buttonEraser);
            this.panel1.Controls.Add(this.buttonEllipse);
            this.panel1.Location = new System.Drawing.Point(276, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 99);
            this.panel1.TabIndex = 3;
            // 
            // buttonTriangle
            // 
            this.buttonTriangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonTriangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTriangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.buttonTriangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTriangle.ForeColor = System.Drawing.Color.White;
            this.buttonTriangle.Image = global::UI.Properties.Resources.triangle_641;
            this.buttonTriangle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonTriangle.Location = new System.Drawing.Point(496, 10);
            this.buttonTriangle.Name = "buttonTriangle";
            this.buttonTriangle.Size = new System.Drawing.Size(75, 75);
            this.buttonTriangle.TabIndex = 8;
            this.buttonTriangle.Text = "Triangle";
            this.buttonTriangle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTriangle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonTriangle.UseVisualStyleBackColor = false;
            this.buttonTriangle.Click += new System.EventHandler(this.buttonTriangle_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.buttonLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLine.ForeColor = System.Drawing.Color.White;
            this.buttonLine.Image = global::UI.Properties.Resources.line;
            this.buttonLine.Location = new System.Drawing.Point(415, 10);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(75, 75);
            this.buttonLine.TabIndex = 6;
            this.buttonLine.Text = "Line";
            this.buttonLine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLine.UseVisualStyleBackColor = false;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // colorButton
            // 
            this.colorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.colorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton.ForeColor = System.Drawing.Color.White;
            this.colorButton.Image = global::UI.Properties.Resources.color;
            this.colorButton.Location = new System.Drawing.Point(10, 10);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(75, 75);
            this.colorButton.TabIndex = 1;
            this.colorButton.Text = "Color";
            this.colorButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.colorButton.UseVisualStyleBackColor = false;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // pencilButton
            // 
            this.pencilButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pencilButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pencilButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.pencilButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pencilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pencilButton.ForeColor = System.Drawing.Color.White;
            this.pencilButton.Image = global::UI.Properties.Resources.pencil;
            this.pencilButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.pencilButton.Location = new System.Drawing.Point(91, 10);
            this.pencilButton.Name = "pencilButton";
            this.pencilButton.Size = new System.Drawing.Size(75, 75);
            this.pencilButton.TabIndex = 3;
            this.pencilButton.Text = "Pencil";
            this.pencilButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pencilButton.UseVisualStyleBackColor = false;
            this.pencilButton.Click += new System.EventHandler(this.pencilButton_Click);
            // 
            // buttonRect
            // 
            this.buttonRect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.buttonRect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRect.ForeColor = System.Drawing.Color.White;
            this.buttonRect.Image = global::UI.Properties.Resources.rectangle;
            this.buttonRect.Location = new System.Drawing.Point(334, 10);
            this.buttonRect.Name = "buttonRect";
            this.buttonRect.Size = new System.Drawing.Size(75, 75);
            this.buttonRect.TabIndex = 7;
            this.buttonRect.Text = "Rectangle";
            this.buttonRect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRect.UseVisualStyleBackColor = false;
            this.buttonRect.Click += new System.EventHandler(this.buttonRect_Click);
            // 
            // buttonEraser
            // 
            this.buttonEraser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.buttonEraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEraser.ForeColor = System.Drawing.Color.White;
            this.buttonEraser.Image = global::UI.Properties.Resources.eraser;
            this.buttonEraser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEraser.Location = new System.Drawing.Point(172, 10);
            this.buttonEraser.Name = "buttonEraser";
            this.buttonEraser.Size = new System.Drawing.Size(75, 75);
            this.buttonEraser.TabIndex = 4;
            this.buttonEraser.Text = "Eraser";
            this.buttonEraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEraser.UseVisualStyleBackColor = false;
            this.buttonEraser.Click += new System.EventHandler(this.buttonEraser_Click);
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEllipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEllipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.buttonEllipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEllipse.ForeColor = System.Drawing.Color.White;
            this.buttonEllipse.Image = global::UI.Properties.Resources.circle;
            this.buttonEllipse.Location = new System.Drawing.Point(253, 10);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(75, 75);
            this.buttonEllipse.TabIndex = 5;
            this.buttonEllipse.Text = "Circle";
            this.buttonEllipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEllipse.UseVisualStyleBackColor = false;
            this.buttonEllipse.Click += new System.EventHandler(this.buttonEllipse_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 689);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // paintSpace
            // 
            this.paintSpace.BackColor = System.Drawing.Color.White;
            this.paintSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paintSpace.Location = new System.Drawing.Point(0, 105);
            this.paintSpace.Name = "paintSpace";
            this.paintSpace.Size = new System.Drawing.Size(984, 584);
            this.paintSpace.TabIndex = 2;
            this.paintSpace.TabStop = false;
            this.paintSpace.Paint += new System.Windows.Forms.PaintEventHandler(this.paintSpace_Paint);
            this.paintSpace.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paintSpace_MouseDown);
            this.paintSpace.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paintSpace_MouseMove);
            this.paintSpace.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paintSpace_MouseUp);
            // 
            // PaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.paintSpace);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolBar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PaintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geometry Paint";
            this.toolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paintSpace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toolBar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox paintSpace;
        private System.Windows.Forms.Button curColor;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Button pencilButton;
        private System.Windows.Forms.Button buttonRect;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.Button buttonEllipse;
        private System.Windows.Forms.Button buttonEraser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button buttonTriangle;
    }
}

