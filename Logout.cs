using System.Windows.Forms;

namespace Diary
{
    public partial class Logout : Form
    {
        public Logout()
        {
            InitializeComponent();
        }

        private void Yes_Click(object sender, System.EventArgs e)
        {
                for (int index = Application.OpenForms.Count - 1; index >= 0; index--)
                {
                    if (Application.OpenForms[1].Name == "Showcase")
                    {
                        Application.OpenForms[1].Close();
                    }
                }
            Close();
        }

        private void No_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
