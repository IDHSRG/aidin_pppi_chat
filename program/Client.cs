using Cryptography

public class Client
{
  long busy, size;
  
  public Client()
  {
    CreateSystemConfig();
    //Настройка клиента, подготовка к работе
  }

  public void CreateSystemConfig()
  {
    if (!File.Exists("systemconfig.con") // Если приложение запускается впервые
      {
        //Анализ устройства
        //Подбор оптимальных параметров для работы
        //Подбор портов
        //Определение рабочего диска
        //т.д.
      }
  }
  
  public bool Connect()
  {
    //Попытка подключиться к серверу
  }
  public bool Login(string phone)
  {
    //Попытка авторизации
    //Ожидание от сервера подтверждения
    //Подтверждение может появиться когда пользователь введёт в интерфейсе код, пришедший на СМС по данному номеру телефона
  }
  public void Leave(string phone)
  {
    //Выход из аккаунта и отсоединение от сервера
  }

  public uint ThreadFunc()
  {
    while (true)
    {
      try
      {
      //Потоковая функция для постоянного ожидания сигналов, данных и т.д
      //Принимает сигналы от сервера и обрабатывает их у себя
      //Периодически отвечает на пинг от сервера и отправляет ему сигнал об активности
      }
      catch(/*Исключение*/)
      {
        //Обработка исключения
      }
      catch(/*Необрабатываемое исключение*/)
      {
        //Сообщение
        //Прерывание сессий
        return -1;
      }
    }
  }

  public bool SendDeleteSignal(Account reciever, Message ms, bool isClear)
  {
    //Отправка сигнала о том, что сообщение удалено у клиента
    //Если isClear = true, то данное сообщение должно быть удалено и у получателя
  }
  
  public bool SendReadedSignal(Account sender, Account reciever, Message ms)
  {
    //Отправка сигнала о том, что сообщение было прочитано
  }
  
  public bool SendRecievedSignal(Account sender, Account reciever, Message ms)
  {
    //Отправка сигнала о том, что сообщение было загружено клиентом
  }

  public void SendMessage(Message msg, byte[] key)
  {
    Сryptography.EncryptMessage(msg, key); //шифрование письма перед отправкой
    //Отправка сообщения на сервер
  }

  public bool KeyExchange()
  {
    Cryptography.CreateKey(true);
    //Обмен ключами ассиметричного алгоритма для передачи ключей симметричного алгоритма для шифрования/расшифрования данных
  }

  public void Store()
  {
    //Сохранение загруженных в клиент в виде кэша для последующей загрузки локально
  }

  public void OfflineGet()
  {
    //Пока не произошло подключение к серверу и авторизация, старый кэш будет подгружен вместо обновления
  }

   public void ClearOld()
  {
    if (busy > maxSize) // если кэш превышает максимальную выделенную память
    {
      // Удаление самых старых записей в кэше
    }
  }
}
