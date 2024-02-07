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

public bool check_config()
{
  //Проверить, есть ли файл конфигурации и можно ли из него прочесть все настройки интерфейса
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

public Interface(Theme t, Font_Style fs)
{
  //Создание интерфейса по указанным настройкам.
  //Пересоздание окна при изменении настроек и перезапуска приложения.
}
