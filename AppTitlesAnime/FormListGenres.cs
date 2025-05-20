using AppTitlesAnime.Models; // Подключение пространства имен для моделей приложения
using Microsoft.EntityFrameworkCore; // Подключение пространства имен для работы с Entity Framework Core
using System; // Подключение базовых классов
using System.Collections.Generic; // Подключение пространства имен для работы с коллекциями
using System.ComponentModel; // Подключение пространства имен для компонентов и управления событиями
using System.Data; // Подключение пространства имен для работы с данными
using System.Drawing; // Подключение пространства имен для работы с графикой
using System.Linq; // Подключение пространства имен для LINQ
using System.Text; // Подключение пространства имен для работы со строками
using System.Threading.Tasks; // Подключение пространства имен для работы с асинхронными задачами
using System.Windows.Forms; // Подключение пространства имен для Windows Forms
using AppContext = AppTitlesAnime.Models.AppContext; // Псевдоним для контекста базы данных
using Type = AppTitlesAnime.Models.Type; // Псевдоним для модели Type

namespace AppTitlesAnime // Определение пространства имен для приложения
{
    // Определение класса формы для отображения списка жанров
    public partial class FormListGenres : Form
    {
        private AppContext db; // Переменная для хранения контекста базы данных

        // Конструктор формы
        public FormListGenres()
        {
            InitializeComponent(); // Инициализация компонентов формы
        }

        // Обработчик события загрузки формы
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e); // Вызов базового метода
            this.db = new AppContext(); // Инициализация контекста базы данных
            this.db.Genres.Load(); // Загрузка жанров из базы данных
            // Установка источника данных для DataGridView
            this.dataGridViewGenres.DataSource = this.db.Genres.Local.OrderBy(o => o.GenreName).ToList();

            // Скрытие столбцов, которые не нужны для отображения
            dataGridViewGenres.Columns["Id"].Visible = false;
            dataGridViewGenres.Columns["TitlesGenres"].Visible = false;

            // Изменение названий заголовков столбцов
            dataGridViewGenres.Columns["GenreName"].HeaderText = "Жанр аниме";
        }

        // Обработчик события закрытия формы
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e); // Вызов базового метода

            this.db?.Dispose(); // Освобождение ресурсов контекста базы данных, если он существует
            this.db = null; // Установка контекста базы данных в null
        }

        // Обработчик события нажатия кнопки обновления жанра
        private void btnUpdateGenre_Click(object sender, EventArgs e)
        {
            // Проверка, выбрана ли строка в DataGridView
            if (dataGridViewGenres.SelectedRows.Count == 0)
                return; // Если нет выбранных строк, выход из метода

            int index = dataGridViewGenres.SelectedRows[0].Index; // Получение индекса выбранной строки
            short id = 0; // Переменная для хранения идентификатора жанра
            // Попытка преобразовать значение идентификатора из строки в short
            bool converted = Int16.TryParse(dataGridViewGenres[0, index].Value.ToString(), out id);
            if (!converted)
                return; // Если преобразование не удалось, выход из метода

            // Поиск жанра по идентификатору
            Genre genre = db.Genres.Find(id);
            FormAddGenre formAddGenre = new(); // Создание формы для добавления/редактирования жанра
            formAddGenre.textBoxGenre.Text = genre.GenreName; // Установка текста текстового поля

            // Отображение формы и ожидание результата
            DialogResult result = formAddGenre.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return; // Если пользователь отменил, выход из метода

            // Обновление имени жанра
            genre.GenreName = formAddGenre.textBoxGenre.Text;
            db.Genres.Update(genre); // Обновление жанра в контексте базы данных
            db.SaveChanges(); // Сохранение изменений в базе данных

            MessageBox.Show("Объект изменен"); // Уведомление пользователя об успешном изменении

            // Обновление источника данных для DataGridView
            this.dataGridViewGenres.DataSource = this.db.Genres.Local.OrderBy(o => o.GenreName).ToList();
        }

        // Обработчик события нажатия кнопки удаления жанра
        private void BtnDeleteGenre_Click(object sender, EventArgs e)
        {
            // Проверка, выбрана ли строка в DataGridView
            if (dataGridViewGenres.SelectedRows.Count == 0)
                return; // Если нет выбранных строк, выход из метода

            // Запрос подтверждения удаления у пользователя
            DialogResult result = MessageBox.Show(
                "Вы уверены что хотите удалить строку? \nВсе связанные данные будут удалены.",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (result == DialogResult.No)
                return; // Если пользователь ответил "Нет", выход из метода

            int index = dataGridViewGenres.SelectedRows[0].Index; // Получение индекса выбранной строки
            short id = 0; // Переменная для хранения идентификатора жанра
            // Попытка преобразовать значение идентификатора из строки в short
            bool converted = Int16.TryParse(dataGridViewGenres[0, index].Value.ToString(), out id);
            if (!converted)
                return; // Если преобразование не удалось, выход из метода

            // Поиск жанра по идентификатору
            Genre genre = db.Genres.Find(id);
            db.Genres.Remove(genre); // Удаление жанра из контекста базы данных
            db.SaveChanges(); // Сохранение изменений в базе данных

            MessageBox.Show("Объект удален"); // Уведомление пользователя об успешном удалении

            // Обновление источника данных для DataGridView
            this.dataGridViewGenres.DataSource = this.db.Genres.Local.OrderBy(o => o.GenreName).ToList();
        }

        // Обработчик события нажатия кнопки добавления жанра
        private void BtnAddGenre_Click(object sender, EventArgs e)
        {
            FormAddGenre formAddGenre = new(); // Создание формы для добавления жанра
            DialogResult result = formAddGenre.ShowDialog(this); // Отображение формы и ожидание результата

            if (result == DialogResult.Cancel)
                return; // Если пользователь отменил, выход из метода

            Genre genre = new Genre(); // Создание нового объекта жанра
            genre.GenreName = formAddGenre.textBoxGenre.Text; // Установка имени жанра

            db.Genres.Add(genre); // Добавление нового жанра в контекст базы данных
            db.SaveChanges(); // Сохранение изменений в базе данных

            MessageBox.Show("Новый объект добавлен"); // Уведомление пользователя об успешном добавлении

            // Обновление источника данных для DataGridView
            this.dataGridViewGenres.DataSource = this.db.Genres.Local.OrderBy(o => o.GenreName).ToList();
        }
    }
}
