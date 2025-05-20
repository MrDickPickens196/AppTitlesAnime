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
    // Определение класса формы для добавления типа аниме
    public partial class FormAddType : Form
    {
        // Конструктор формы
        public FormAddType()
        {
            InitializeComponent(); // Инициализация компонентов формы
        }

        // Обработчик события загрузки формы
        private void FormAddType_Load(object sender, EventArgs e)
        {
            // Здесь можно добавить код, который будет выполняться при загрузке формы
        }

        // Обработчик события рисования панели
        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Здесь можно добавить код для кастомизации рисования панели
        }
        // Обработчик события валидации текстового поля для имени типа
        // Validating, которое срабатывает при вводе пользователя и призвано управлять валидацией вода
        // В обработчике события Validating мы смотрим на введенный текст
        private void TextBoxTypeName_Validating(object sender, CancelEventArgs e)
        {
            // Проверка, пустое ли текстовое поле
            if (String.IsNullOrEmpty(textBoxTypeName.Text))
            {
                // Установка сообщения об ошибке, если поле пустое
                errorProvider.SetError(textBoxTypeName, "Поле не может быть пустым");
                btnSaveChanges.Enabled = false; // Отключение кнопки сохранения изменений
            }
            else
            {
                // Очистка сообщения об ошибке, если поле не пустое
                errorProvider.Clear();
                btnSaveChanges.Enabled = true; // Включение кнопки сохранения изменений
            }
        }

        // Обработчик события изменения текста в текстовом поле для имени типа
        //Этот метод вызывается каждый раз, когда изменяется текст в текстовом поле для ввода жанра
        private void TextBoxTypeName_TextChanged(object sender, EventArgs e)
        {
            // Проверка, пустое ли текстовое поле
            // IsNullOrEmpty = Нулевой или пустой
            if (String.IsNullOrEmpty(textBoxTypeName.Text))
            {
                // Установка сообщения об ошибке, если поле пустое
                errorProvider.SetError(textBoxTypeName, "Поле не может быть пустым");
                btnSaveChanges.Enabled = false; // Отключение кнопки сохранения изменений
            }
            else
            {
                // Очистка сообщения об ошибке, если поле не пустое
                errorProvider.Clear();
                btnSaveChanges.Enabled = true; // Включение кнопки сохранения изменений
            }
        }
    }
}
