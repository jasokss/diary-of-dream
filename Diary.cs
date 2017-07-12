using System;
using System.Windows.Forms;
using System.Drawing;
using Diary.Database;

namespace Diary
{
    public partial class Diario : Form
    {
        public Diario()
        {
            InitializeComponent();
        }

        private bool Bold = false;
        private bool Italic = false;

        private void AddDiaryPage_Click(object sender, EventArgs e)
        {
            if (Title.Text == String.Empty)
            {
                titleError.Text = "Non puoi lasciare il titolo vuoto!";
                return;
            }

            else if (Category.Text == String.Empty || Category.Text != Convert.ToString(Category.SelectedItem))
            {
                categoryError.Text = "Scegli una categoria esistente!";
                return;
            }

            else if (TellYourDream.TextLength < 10)
            {
                tellYourDreamError.Text = "Il tuo sogno deve essere più lungo!";
                return;
            }

            else
            {
                Adapter dbClient = Manager.GetDatabaseManager();
                Showcase Showcase = new Showcase();

                DateTime timeStamp = DateTime.Now;
                int Hour = timeStamp.Hour;
                int Minute = timeStamp.Minute;
                string sqlFormattedDate = timeStamp.Date.ToString("dd/MM/yyyy");

                dbClient.Insert("INSERT INTO `written` (`id`, `title`, `category`, `text`, `date`, `addicted_time`) VALUES ('', '" + Title.Text + "', '" + Category.SelectedItem + "', '" + TellYourDream.Text + TellYourDream.SelectionFont + "', '" + sqlFormattedDate + "', '" + Hour + ":" + Minute + "')");

                Hide();
                Showcase.Show();
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            titleError.Text = String.Empty;
            categoryError.Text = String.Empty;
            tellYourDreamError.Text = String.Empty;
            if (Bold == false)
            {
                Bold = true;
                Italic = false;
                TellYourDream.SelectionFont = new Font(TellYourDream.Font, FontStyle.Bold);
            }

            else
            {
                Bold = false;
                TellYourDream.SelectionFont = new Font(TellYourDream.Font, FontStyle.Regular);
            }
        }

        private void I_Click(object sender, EventArgs e)
        {
            titleError.Text = String.Empty;
            categoryError.Text = String.Empty;
            tellYourDreamError.Text = String.Empty;
            if (Italic == false)
            {
                Italic = true;
                Bold = false;
                TellYourDream.SelectionFont = new Font(TellYourDream.Font, FontStyle.Italic);
            }

            else
            {
                Italic = false;
                TellYourDream.SelectionFont = new Font(TellYourDream.Font, FontStyle.Regular);
            }
        }

        private void Category_MouseClick(object sender, MouseEventArgs e)
        {
            titleError.Text = String.Empty;
            categoryError.Text = String.Empty;
            tellYourDreamError.Text = String.Empty;
        }

        private void TellYourDream_MouseClick(object sender, MouseEventArgs e)
        {
            titleError.Text = String.Empty;
            categoryError.Text = String.Empty;
            tellYourDreamError.Text = String.Empty;
        }

        private void Title_MouseClick(object sender, MouseEventArgs e)
        {
            titleError.Text = String.Empty;
            categoryError.Text = String.Empty;
            tellYourDreamError.Text = String.Empty;
        }
    }
}