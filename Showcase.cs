using System.Drawing;
using System.Windows.Forms;

namespace Diary
{
    public partial class Showcase : Form
    {
        public Showcase()
        {
            InitializeComponent();
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void Showcase_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = Location;
        }

        private void Showcase_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Showcase_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Logout_Click(object sender, System.EventArgs e)
        {
            new Logout().ShowDialog();
        }
    }
}