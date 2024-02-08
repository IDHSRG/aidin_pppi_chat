public class Server
{
  public Server() : Form
  {
    //Настройка основных полей аккаунта, подготовка к приемё сигналов
    //Начало фонового потока с функцией ThreadFunc()
  }

  public uint ThreadFunc()
  {

    while (true)
    {
      try
      {
      //Потоковая функция для постоянного ожидания сигналов, данных и т.д
      //Принимает сигналы от клиентов и присваивает их аккаунтам
      //Периодически пингует активные аккаунты и если они не отвечают - ставит статус "не в сети"
      //Если аккаунт отвечает но ничего не посылает далее - ставит статус "отошёл"
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

  public bool SendDeleteSignal(Account sender, Account reciever, Message ms, bool isClear)
  {
    //Отправка сигнала о том, что сообщение должно быть удалено у клиента
    //Если isClear = true, то cигнал об удалении отправляется и для клиента получателя
  }
  
  public bool SendReadedSignal(Account sender, Account reciever, Message ms)
  {
    //Отправка сигнала о том, что сообщение было прочитано получаетелем
  }
  
  public bool SendRecievedSignal(Account sender, Account reciever, Message ms)
  {
    //Отправка сигнала о том, что сообщение было отправлено на клиент получателя
  }

  private void SetStatus(Account acc, string stat)
  {
    //Установка статуса аккаунта
    BroadcastStatus(acc);
  }
  
  public void BroadcastStatus(Account acc)
  {
    //Отправка сигнала о статусе аккаунта (в сети, не в сети)
  }

  public bool Ping(Account acc)
  {
    //Отправка сигнала на клиент для проверки, отвечает тот или нет
  }
}
