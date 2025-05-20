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
    // Определение класса формы для отображения списка типов аниме
    public partial class FormListTypes : Form
    {
        private AppContext db; // Переменная для хранения контекста базы данных

        // Конструктор формы
        public FormListTypes()
        {
            InitializeComponent(); // Инициализация компонентов формы
        }

        // Обработчик события загрузки формы
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e); // Вызов базового метода
            //this. ссылкa на текущий экземпляр класса
            this.db = new AppContext(); // Инициализация контекста базы данных
            this.db.Types.Load(); // Загрузка типов из базы данных
            // Установка источника данных для DataGridView
            this.dataGridViewTypes.DataSource = this.db.Types.Local.OrderBy(o => o.TypeName).ToList();

            // Скрытие столбцов, которые не нужны для отображения
            dataGridViewTypes.Columns["Id"].Visible = false;
            dataGridViewTypes.Columns["AnimeTitles"].Visible = false;
            // Изменение названий заголовков столбцов
            dataGridViewTypes.Columns["TypeName"].HeaderText = "Тип аниме";
        }

        // Обработчик события закрытия формы
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e); // Вызов базового метода

            this.db?.Dispose(); // Освобождение ресурсов контекста базы данных, если он существует
            this.db = null; // Установка контекста базы данных в null
        }

        // Обработчик события рисования панели (пока не используется)
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        // Обработчик события нажатия на ячейку DataGridView (пока не используется)
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Обработчик события нажатия кнопки добавления типа
        private void BtnAddType_Click(object sender, EventArgs e)
        {
            FormAddType formAddType = new(); // Создание формы для добавления типа
            DialogResult result = formAddType.ShowDialog(this); // Отображение формы и ожидание результата

            if (result == DialogResult.Cancel)
                return; // Если пользователь отменил, выход из метода

            Type type = new Type(); // Создание нового объекта типа
            type.TypeName = formAddType.textBoxTypeName.Text; // Установка имени типа

            db.Types.Add(type); // Добавление нового типа в контекст базы данных
            db.SaveChanges(); // Сохранение изменений в базе данных

            MessageBox.Show("Новый объект добавлен"); // Уведомление пользователя об успешном добавлении

            // Обновление источника данных для DataGridView
            this.dataGridViewTypes.DataSource = this.db.Types.Local.OrderBy(o => o.TypeName).ToList();
        }

        // Обработчик события нажатия кнопки обновления типа
        private void BtnUpdateType_Click(object sender, EventArgs e)
        {
            // Проверка, выбрана ли строка в DataGridView
            if (dataGridViewTypes.SelectedRows.Count == 0)
                return; // Если нет выбранных строк, выход из метода

            int index = dataGridViewTypes.SelectedRows[0].Index; // Получение индекса выбранной строки
            short id = 0; // Переменная для хранения идентификатора типа
            // Попытка преобразовать значение идентификатора из строки в short
            bool converted = Int16.TryParse(dataGridViewTypes[0, index].Value.ToString(), out id);
            if (!converted)
                return; // Если преобразование не удалось, выход из метода

            // Поиск типа по идентификатору
            Type type = db.Types.Find(id);
            FormAddType formAddType = new(); // Создание формы для редактирования типа
            formAddType.textBoxTypeName.Text = type.TypeName; // Установка текста текстового поля

            // Отображение формы и ожидание результата
            DialogResult result = formAddType.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return; // Если пользователь отменил, выход из метода

            // Обновление имени типа
            type.TypeName = formAddType.textBoxTypeName.Text;
            db.Types.Update(type); // Обновление типа в контексте базы данных
            db.SaveChanges(); // Сохранение изменений в базе данных

            MessageBox.Show("Объект изменен"); // Уведомление пользователя об успешном изменении

            // Обновление источника данных для DataGridView
            this.dataGridViewTypes.DataSource = this.db.Types.Local.OrderBy(o => o.TypeName).ToList();
        }

        // Обработчик события нажатия кнопки удаления типа
        private void BtnDeleteType_Click(object sender, EventArgs e)
        {
            // Проверка, выбрана ли строка в DataGridView
            if (dataGridViewTypes.SelectedRows.Count == 0)
                return; // Если нет выбранных строк, выход из метода

            // Запрос подтверждения удаления у пользователя
            DialogResult result = MessageBox.Show(
                "Вы уверены что хотите удалить объект? \nВсе связанные данные будут удалены.",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (result == DialogResult.No)
                return; // Если пользователь ответил "Нет", выход из метода

            int index = dataGridViewTypes.SelectedRows[0].Index; // Получение индекса выбранной строки
            short id = 0; // Переменная для хранения идентификатора типа
            // Попытка преобразовать значение идентификатора из строки в short
            bool converted = Int16.TryParse(dataGridViewTypes[0, index].Value.ToString(), out id);
            if (!converted)
                return; // Если преобразование не удалось, выход из метода

            // Поиск типа по идентификатору
            Type type = db.Types.Find(id);
            db.Types.Remove(type); // Удаление типа из контекста базы данных
            db.SaveChanges(); // Сохранение изменений в базе данных

            MessageBox.Show("Объект удален"); // Уведомление пользователя об успешном удалении

            // Обновление источника данных для DataGridView
            this.dataGridViewTypes.DataSource = this.db.Types.Local.OrderBy(o => o.TypeName).ToList();
        }
    }
}
