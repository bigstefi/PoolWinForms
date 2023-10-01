namespace PoolWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Point _lineStart = new Point(0,0);
        private Point _lineEnd = new Point(100,100);

        /// <summary>
        ///  Clean up any resources being used.
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

        private void DrawLine(Point start, Point end)
        {
            Pen pen = new Pen(Color.FromArgb(255, 50, 100, 200));
            pen.Width = 5;

            this.CreateGraphics().DrawLine(pen, start.X, start.Y, end.X, end.Y);
        }

        private void DrawCircle(Point origin, int radius)
        {
            Pen pen = new Pen(Color.FromArgb(255, 200, 100, 50));
            pen.Width = 5;

            this.CreateGraphics().DrawEllipse(pen, origin.X, origin.Y, radius, radius);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 460);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

            this.MouseDown += Form1_OnMouseDown;
            this.MouseUp += Form1_OnMouseUp;

        }

        private void Form1_OnMouseDown(object sender, MouseEventArgs e)
        {
            _lineStart = e.Location;
        }

        private void Form1_OnMouseUp(object sender, MouseEventArgs e)
        {
            _lineEnd = e.Location;

            DrawLine(_lineStart, _lineEnd);

            int radius = 20;
            DrawCircle(new Point((_lineStart.X + _lineEnd.X)/2 - radius/2, (_lineStart.Y + _lineEnd.Y)/2 - radius/2), radius);
        }
        #endregion
    }
}