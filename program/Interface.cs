using System.Windows.Forms

namespace Interface
{
  struct Theme
  {
    Color background;
    Color foreground;
    //Цветовая тема интерфейса
  }

  struct Font_Style
  {
    Font font-family;
    short font-size;
    int font-weight;
    bool isItalic;
    //Настройки шрифта интерфейса
  }

  public class Interface
  {
    string language; // Название файла локализации, расположенного в каталоге "languages", без расширений
    Font_style font;
    Theme theme;
    Bool alwaysCompressImages;
    uint cashMaxSize;
     
    public bool CheckConfig()
    {
      //Проверить, есть ли файл конфигурации и можно ли из него прочесть все настройки интерфейса
    }

    public bool SaveConfig(Theme t, Font_Style fs)
    {
      //Перезаписать файл конфигурации после изменения настроек
    }

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

    public Interface(Theme t, Font_Style fs, string lang)
    {
      //Создание интерфейса по указанным настройкам.
      //Пересоздание окна при изменении настроек и перезапуска приложения.
    }

    private bool AddContact(string phone)
    {
      //Добавление нового контакта
    }
    
    private void MessageList_MouseWheel(object sender, MouseEventArgs e) 
    {
      int delta = e.Delta / 12;
      //Обработка прокрутки колёсиком списка сообщений
    }
    private void ContactsList_MouseWheel(object sender, MouseEventArgs e) 
    {
      int delta = e.Delta / 12;
      //Обработка прокрутки колёсиком списка контактов
    }
    private void EmojiesPanel_MouseWheel(object sender, MouseEventArgs e) 
    {
      int delta = e.Delta / 12;
      //Обработка прокрутки колёсиком панели со эмодзи
    }

    private void AddImageButton_MouseDown(object sender, MouseEventArgs e)
    {
      //Выбор картинки на устройстве
      //Добавление пути к изображению в настройки сообщения
    }

    private void SendButton_MouseDown(object sender, MouseEventArgs e)
    {
      //Формирование сообщения и передача его клиенту для отправки
    }

    private bool ChangeLanguage(string lang)
    {
      if (File.Exists("languages//"+lang+".txt")
          this.language = lang;
      else 
          return false;
      return true;
    }

    private Font_Style ChangeFont(string family, short size, short weight, Color color, bool italic)
    {
      //Изменение настроек текста
      //Сохранение в конфигурации
    }

    private Theme ChangeTheme(Theme)
    {
      //Изменение темы приложения
      //Сохранение в конфигурации
    }
          
    private Theme ChangeTheme(Сolor back, Color fore)
    {
      //Изменение темы приложения по выбранным пользователем цветами
      //Сохранение в конфигурации
    }

    private void ChangeСompression(bool b)
    {
      //Изменение настройки автоматического сжатия изображения
      //Сохранение изменений в конфигурацию
    }

    private void SetMaxCash(uint size)
    {
      //Изменение максимального размера кэша сообщений;
      //Сохранение изменений в конфигурацию
    }

    private void Search(string who, string text, bool isImage, DateTime fromWhen, DateTime beforeWhen, DateTime when)
    {
      //Произвести поиск
      //Найти только те сообщения, которые соответствуют (или содержат, для текста) значениям параметров, не равным NULL
    }
          
    private void Filter(string who, string text, bool isImage, DateTime fromWhen, DateTime beforeWhen, DateTime when)
    {
      //Произвести фильтрацию
      //Выводить только те сообщения, которые соответствуют (или содержат, для текста) значениям параметров, не равным NULL
    }
  }
}
