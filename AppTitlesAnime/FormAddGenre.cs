using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTitlesAnime
{
    public partial class FormAddGenre : Form

    {
        public FormAddGenre()
        {
            InitializeComponent();
        }

        private void FormAddGenre_Load(object sender, EventArgs e)
        {

        }
        private void flowLayoutPanelBottom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBoxGenre_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxGenre.Text))
            {
                errorProviderGenre.SetError(textBoxGenre, "Поле не может быть пустым");
                btnSaveChanges.Enabled = false;
            }
            else
            {
                errorProviderGenre.Clear();
                btnSaveChanges.Enabled = true;
            }
        }

        private void textBoxGenre_Validating_1(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxGenre.Text))
            {
                errorProviderGenre.SetError(textBoxGenre, "Поле не может быть пустым");
                btnSaveChanges.Enabled = false;
            }
            else
            {
                errorProviderGenre.Clear();
                btnSaveChanges.Enabled = true;
            }
        }
    }
}
