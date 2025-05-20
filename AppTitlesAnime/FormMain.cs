namespace AppTitlesAnime
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void BtnShowTypes_Click(object sender, EventArgs e)
        {
            //создаем экземпл€р формы formListTypes
            //и дл€ него вызываем метод .Show
            FormListTypes formListTypes = new FormListTypes();
            formListTypes.Show();
        }

        private void BtnShowGenres_Click(object sender, EventArgs e)
        {
            //создаем экземпл€р формы formListGenres
            //и дл€ него вызываем метод .Show
            FormListGenres formListGenres = new FormListGenres();
            formListGenres.Show();
        }

        private void BtnShowStatus_Click(object sender, EventArgs e)
        {
            //создаем экземпл€р формы FormListStatus
            //и дл€ него вызываем метод .Show
            FormListStatus formListStatus = new FormListStatus();
            formListStatus.Show();
        }
    }
}
