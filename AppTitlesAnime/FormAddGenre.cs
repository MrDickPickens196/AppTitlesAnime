using System; // Подключение пространства имен для базовых классов
using System.Collections.Generic; // Подключение пространства имен для работы с коллекциями
using System.ComponentModel; // Подключение пространства имен для компонентов и управления событиями
using System.Data; // Подключение пространства имен для работы с данными
using System.Drawing; // Подключение пространства имен для работы с графикой
using System.Linq; // Подключение пространства имен для LINQ
using System.Text; // Подключение пространства имен для работы со строками
using System.Threading.Tasks; // Подключение пространства имен для работы с асинхронными задачами
using System.Windows.Forms; // Подключение пространства имен для Windows Forms

namespace AppTitlesAnime // Определение пространства имен для приложения
{
    // Определение класса формы для добавления жанра
    public partial class FormAddGenre : Form
    {
        // Конструктор формы
        public FormAddGenre()
        {
            InitializeComponent(); // Инициализация компонентов формы
        }

        // Обработчик события загрузки формы
        private void FormAddGenre_Load(object sender, EventArgs e)
        {
            // Здесь можно добавить код, который будет выполняться при загрузке формы
        }

        // Обработчик события рисования нижней панели
        private void flowLayoutPanelBottom_Paint(object sender, PaintEventArgs e)
        {
            // Здесь можно добавить код для кастомизации рисования нижней панели
        }

        // Обработчик события изменения текста в текстовом поле для жанра
        //Этот метод вызывается каждый раз, когда изменяется текст в текстовом поле для ввода жанра.
        private void TextBoxGenre_TextChanged(object sender, EventArgs e)
        {
            // Проверка, пустое ли текстовое поле
            // IsNullOrEmpty = Нулевой или пустой
            if (String.IsNullOrEmpty(textBoxGenre.Text))
            {
                // Установка сообщения об ошибке, если поле пустое
                errorProviderGenre.SetError(textBoxGenre, "Поле не может быть пустым");
                btnSaveChanges.Enabled = false; // Отключение кнопки сохранения изменений
            }
            else
            {
                // Очистка сообщения об ошибке, если поле не пустое
                errorProviderGenre.Clear();
                btnSaveChanges.Enabled = true; // Включение кнопки сохранения изменений
            }
        }

        // Обработчик события валидации текстового поля для жанра
        // Validating, которое срабатывает при вводе пользователя и призвано управлять валидацией вода
        // В обработчике события Validating мы смотрим на введенный текст
        private void textBoxGenre_Validating_1(object sender, CancelEventArgs e)
        {
            // Проверка, пустое ли текстовое поле
            if (String.IsNullOrEmpty(textBoxGenre.Text))
            {
                // Установка сообщения об ошибке, если поле пустое
                errorProviderGenre.SetError(textBoxGenre, "Поле не может быть пустым");
                btnSaveChanges.Enabled = false; // Отключение кнопки сохранения изменений
            }
            else
            {
                // Очистка сообщения об ошибке, если поле не пустое
                errorProviderGenre.Clear();
                btnSaveChanges.Enabled = true; // Включение кнопки сохранения изменений
            }
        }
    }
}

