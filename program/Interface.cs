using System.Windows.Forms;


namespace Interface
{
    /// <summary>
    /// Цветовая тема интерфейса<br/>
    /// Включает два цвета: задний фон и передний фон
    /// </summary>
    struct Theme
    {
        /// <summary>
        /// Цвет фона
        /// </summary>
        Color background;
        /// <summary>
        /// Цвет пузырьков, окошек и др.
        /// </summary>
        Color foreground;
    }

    /// <summary>
    /// Класс, представляющий собой модуль cервера.<br/>
    /// Ожидает, получает сигналы от клиентов, устанавливает с ними соединение, обрабатывает их сигналы, хранит сообщения и пересылает их клиентам<br/>
    /// Устанавливется отдельно от приложения на устройстве (или сервере) и работает постоянно
    /// </summary>
    struct Font_Style
    {
        /// <summary>
        /// Стиль шрифта
        /// </summary>
        Font fontfamily;
        /// <summary>
        /// Размер шрифта
        /// </summary>
        short fontsize;
        /// <summary>
        /// Жирность шрифта
        /// </summary>
        int fontweight;
        /// <summary>
        /// Цвет шрифта
        /// </summary>
        Сolor сolor;
        /// <summary>
        /// Является ли шрифт курсивом
        /// </summary>
        bool isItalic;
        //Настройки шрифта интерфейса
    }

    /// <summary>
    /// Класс, представляющий интерфейс чата, через который осуществляется управление клиентом и в котором выводятся все сообщения
    /// </summary>
    public class Interface
    {
        /// <summary>
        /// Текущая локализация
        /// </summary>
        string language; // Название файла локализации, расположенного в каталоге "languages", без расширений
        
        /// <summary>
        /// Текущий шрифт
        /// </summary>
        Font_style font;

        /// <summary>
        /// Текущая тема
        /// </summary>
        Theme theme;

        /// <summary>
        /// Настройка автоматического сжатия изображений для меньшего веса отправки
        /// </summary>
        Bool alwaysCompressImages;

        /// <summary>
        /// Максимальный размер хэша данных
        /// </summary>
        uint hashMaxSize;

        /// <summary>
        /// Проверка наличия файла конфигурации интерфейса (тема, шрифт и т.д.)
        /// </summary>
        /// <returns>true - файл конфигурации интерфейса найден<br/>false - файл конфигурации интерфейса повреждён или не найден</returns>
        public bool CheckConfig()
        {
            //Проверить, есть ли файл конфигурации и можно ли из него прочесть все настройки интерфейса
        }

        /// <summary>
        /// Перезаписать данные конфигурации в файл
        /// </summary>
        /// <returns>true - перезапись успешна<br/>false - произошла ошибка записи</returns>
        public bool SaveConfig(Theme t, Font_Style fs)
        {
            //Перезаписать файл конфигурации после изменения настроек
        }

        /// <summary>
        /// Стандартный конструктор интерфейса
        /// </summary>
        public Interface()
        {
            if (check_config())
            {
                //Если есть корректный файл конфигурации - загрузить данные из него
            }
            else
            {
                //Базовые настройки темы, шрифта и т.д.
                //Запускается если нет файла конфигурации или он повреждён
            }
        }

        /// <summary>
        /// Конструктор интерфейса по указанным настройкам (после перенастройки стилей в настройках запускается этот конструктор)
        /// </summary>
        public Interface(Theme t, Font_Style fs, string lang)
        {
            //Создание интерфейса по указанным настройкам.
            //Пересоздание окна при изменении настроек и перезапуска приложения.
        }

        /// <summary>
        /// Добавление контакта в список контактов<br/>
        /// Посылает сигнал серверу о добавлении контакта
        /// </summary>
        /// <returns>true - контакт добавлен<br/>false - неверный номер или другая ошибка при добавлении контакта</returns>
        private bool AddContact(string phone)
        {
            //Добавление нового контакта
        }

        /// <summary>
        /// Прокрутка колесика мыши в истории сообщений с контактом
        /// </summary>
        private void MessageList_MouseWheel(object sender, MouseEventArgs e)
        {
            int delta = e.Delta / 12;
            //Обработка прокрутки колёсиком списка сообщений
        }

        /// <summary>
        /// Прокрутка колесика мыши в списке контактов
        /// </summary>
        private void ContactsList_MouseWheel(object sender, MouseEventArgs e)
        {
            int delta = e.Delta / 12;
            //Обработка прокрутки колёсиком списка контактов
        }

        /// <summary>
        /// Прокрутка колесика мыши в панели с эмодзи
        /// </summary>
        private void EmojiesPanel_MouseWheel(object sender, MouseEventArgs e)
        {
            int delta = e.Delta / 12;
            //Обработка прокрутки колёсиком панели со эмодзи
        }

        /// <summary>
        /// Нажатие кнопки "добавить изображение"
        /// </summary>
        private void AddImageButton_MouseDown(object sender, MouseEventArgs e)
        {
            //Выбор картинки на устройстве
            //Добавление пути к изображению в настройки сообщения
        }

        /// <summary>
        /// Нажатие кнопки "Отправить" или Enter
        /// </summary>
        private void SendButton_MouseDown(object sender, MouseEventArgs e)
        {
            //Формирование сообщения и передача его клиенту для отправки
        }

        /// <summary>
        /// Изменение локализации интерфейса
        /// </summary>
        /// <param name="lang">Язык</param>
        /// <returns>true - язык изменён<br/>false - такого языка нет</returns>
        private bool ChangeLanguage(string lang)
        {
            if (File.Exists("languages//" + lang + ".txt")
                this.language = lang;
            else
                return false;
            return true;
        }

        /// <summary>
        /// Изменение стиля шрифта и сохранение в конфигурации
        /// </summary>
        /// <param name="family">Стиль</param>
        /// <param name="size">Размер</param>
        /// <param name="weight">Жирность</param>
        /// <param name="color">Цвет</param>
        /// <param name="italic">Курсив?</param>
        /// <returns>Новый стиль шрифта</returns>
        private Font_Style ChangeFont(string family, short size, short weight, Color color, bool italic)
        {
            //Изменение настроек текста
            //Сохранение в конфигурации
        }

        /// <summary>
        /// Изменение темы интерфейса на сущесвтующую, сохранение в конфигурации
        /// </summary>
        /// <param name="t">Тема интерфейса</param>
        /// <returns>Новая тема интерфейса</returns>
        private Theme ChangeTheme(Theme t)
        {
            //Изменение темы приложения
            //Сохранение в конфигурации
        }

        /// <summary>
        /// Изменение темы интерфейса на новую, сохранение в конфигурации
        /// </summary>
        /// <param name="back">Задний фон</param>
        /// <param name="fore">Передний фон</param>
        /// <returns>Новая тема интерфейса</returns>
        private Theme ChangeTheme(Сolor back, Color fore)
        {
            //Изменение темы приложения по выбранным пользователем цветами
            //Сохранение в конфигурации
        }

        /// <summary>
        /// Изменение настройки автоматического сжатия изображений перед отправкой
        /// </summary>
        /// <param name="b">true - с автоматическим сжатие<br/> false - без автоматического сжатия</param>
        private void ChangeСompression(bool b)
        {
            //Изменение настройки автоматического сжатия изображения
            //Сохранение изменений в конфигурацию
        }

        /// <summary>
        /// Установка максимального размера кэша сообщений
        /// </summary>
        /// <param name="size">Размер кэша</param>
        private void SetMaxCash(uint size)
        {
            //Изменение максимального размера кэша сообщений;
            //Сохранение изменений в конфигурацию
        }

        /// <summary>
        /// Поиск сообщения по указанным данным<br/>
        /// Данные могут быть NULL - в таком случае поиск по ним не осуществляется
        /// </summary>
        /// <param name="who">Кому</param>
        /// <param name="text">Содержимое</param>
        /// <param name="isImage">Содержит изображение</param>
        /// <param name="fromWhen">С какой даты</param>
        /// <param name="beforeWhen">Перед какой датой</param>
        /// <param name="when">Конкретная дата</param>
        private void Search(string who, string text, bool isImage, DateTime fromWhen, DateTime beforeWhen, DateTime when)
        {
            //Произвести поиск
            //Найти только те сообщения, которые соответствуют (или содержат, для текста) значениям параметров, не равным NULL
        }

        /// <summary>
        /// Фильтрация сообщений по указанным данным<br/>
        /// Данные могут быть NULL - в таком случае фильтрация по ним не осуществляется
        /// </summary>
        /// <param name="who">Кому?</param>
        /// <param name="text">Содержимое</param>
        /// <param name="isImage">Содержит изображение</param>
        /// <param name="fromWhen">С какой даты</param>
        /// <param name="beforeWhen">Перед какой датой</param>
        /// <param name="when">Конкретная дата</param>
        private void Filter(string who, string text, bool isImage, DateTime fromWhen, DateTime beforeWhen, DateTime when)
        {
            //Произвести фильтрацию
            //Выводить только те сообщения, которые соответствуют (или содержат, для текста) значениям параметров, не равным NULL
        }
    }
}
