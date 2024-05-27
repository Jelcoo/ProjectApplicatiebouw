using System.Drawing.Drawing2D;

namespace ChapeauUI.Components
{
    public class BackgroundPanel : Panel
    {
        public int CornerRadius = 12;
        public Color CornerFill = Color.FromArgb(164, 195, 178);

        public BackgroundPanel()
        {
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Create the path for the rounded rectangle
            GraphicsPath path = new GraphicsPath();
            int radius = CornerRadius;
            int diameter = radius * 2;

            // Add top left arc
            path.AddArc(new Rectangle(0, 0, diameter, diameter), 180, 90);

            // Top right corner
            path.AddLine(radius, 0, this.Width, 0);

            // Bottom right corner
            path.AddLine(this.Width, 0, this.Width, this.Height);

            // Bottom left corner
            path.AddLine(this.Width, this.Height, 0, this.Height);

            // Left edge
            path.AddLine(0, this.Height, 0, radius);

            path.CloseFigure();

            // Draw the path
            Brush brush = new SolidBrush(this.BackColor);
            e.Graphics.FillPath(brush, path);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Fill the entire panel with the background color
            using (Brush brush = new SolidBrush(CornerFill))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}
