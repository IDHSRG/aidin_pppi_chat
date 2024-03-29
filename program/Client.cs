using Cryptography;

namespace Clients
{
    /// <summary>
    /// Класс, представляющий собой модуль для связи с сервером (клиент), получения от него сообщений и хранение их в виде кэша
    /// Управляется интерфейсом пользователя и сигналами от сервера.
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Объём занятого кэша
        /// </summary>
        long busy;

        /// <summary>
        /// Максимальный объём хэша
        /// </summary>
        long size;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public Client()
        {
            CreateSystemConfig();
            //Настройка клиента, подготовка к работе
        }

        /// <summary>
        /// Создание файла информации по системе.<br/>
        /// Необходимо для конфигурации работы клиента.<br/>
        /// Производится лишь при отсутствии данного файла (при первом запуске или при повреждении файла)
        /// </summary>
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

        /// <summary>
        /// Подключение к серверу
        /// </summary>
        /// <returns>true если подключение успешно<br/>false если подключения не удалось</returns>
        public bool Connect()
        {
            //Попытка подключиться к серверу
        }

        /// <summary>
        /// Авторизация.<br/> 
        /// Сервер проверяет наличие номера телефона у себя, отправляет на него письмо с кодом и возвращает клиенту, пользователь должен ввести код.
        /// </summary>
        /// <returns>true если авторизация успешна<br/>false если авторизация не успешна</returns>
        public bool Login(string phone)
        {
            //Попытка авторизации
            //Ожидание от сервера подтверждения
            //Подтверждение может появиться когда пользователь введёт в интерфейсе код, пришедший на СМС по данному номеру телефона
        }

        /// <summary>
        /// Выход из учетной записи и отсоединение от сервера
        /// </summary>
        public void Leave()
        {
            //Выход из аккаунта и отсоединение от сервера
        }

        /// <summary>
        /// Потоковая функция обработки поступающих сигналов.<br/>
        /// Стоит в ожидании и ловит сигналы от сервера, обрабатывает их и посылает обратно/сохраняет изменения у себя
        /// Принимает также списки сообщений от сервера и сохраняет на устройстве
        /// </summary>
        /// <returns>Код выполнения работы (-1 в случае сбоя, 0 в случае завершения работы)</returns>
        public int ThreadFunc()
        {
            while (true)
            {
                try
                {
                    //Потоковая функция для постоянного ожидания сигналов, данных и т.д
                    //Принимает сигналы от сервера и обрабатывает их у себя
                    //Периодически отвечает на пинг от сервера и отправляет ему сигнал об активности
                }
                catch (/*Исключение*/)
                {
                    //Обработка исключения
                }
                catch (/*Необрабатываемое исключение*/)
                {
                    //Сообщение
                    //Прерывание сессий
                    return -1;
                }
            }
        }

        /// <summary>
        /// Отправка сигнала серверу об удалении данного сообщения<br/>
        /// Можно удалить сообщение только для себя или для получателя тоже
        /// </summary>
        /// <param name="reciever">Получатель сообщения</param>
        /// <param name="ms">Сообщение, которое надо удалить</param>
        /// <param name="isClear">Если true - удалить и для получателя</param>
        /// <returns>true - сервер ответил на сигнал удовлетворительно<br/>false - cервер не ответил или отказал в обработке сигнала</returns>
        public bool SendDeleteSignal(Account reciever, Message ms, bool isClear)
        {
            //Отправка сигнала о том, что сообщение удалено у клиента
            //Если isClear = true, то данное сообщение должно быть удалено и у получателя
        }

        /// <summary>
        /// Отправка сигнала серверу о прочтении данного письма<br/>
        /// </summary>
        /// <param name="reciever">Учетная запись получателя сообщения</param>
        /// <param name="ms">Сообщение</param>
        /// <param name="sender">Учетная запись отправителя сообщения</param>
        /// <returns>true - сервер ответил на сигнал удовлетворительно<br/>false - cервер не ответил или отказал в обработке сигнала</returns>
        public bool SendReadedSignal(Account sender, Account reciever, Message ms)
        {
            //Отправка сигнала о том, что сообщение было прочитано
        }

        /// <summary>
        /// Отправка сигнала серверу о успешной загрузке данного письма<br/>
        /// </summary>
        /// <param name="reciever">Учетная запись получателя сообщения</param>
        /// <param name="ms">Сообщение</param>
        /// <param name="sender">Учетная запись отправителя сообщения</param>
        /// <returns>true - сервер ответил на сигнал удовлетворительно<br/>false - cервер не ответил или отказал в обработке сигнала</returns>
        public bool SendRecievedSignal(Account sender, Account reciever, Message ms)
        {
            //Отправка сигнала о том, что сообщение было загружено клиентом
        }

        /// <summary>
        /// Отправить сообщение на сервер, предварительно его зашифроваыв<br/>
        /// </summary>
        /// <param name="msg">Сообщение</param>
        /// <param name="key">Ключ для шифрования содержимого сообщения перед отправкой</param>
        public void SendMessage(Message msg, byte[] key)
        {
            Сryptography.EncryptMessage(msg, key); //шифрование письма перед отправкой
                                                   //Отправка сообщения на сервер
        }

        /// <summary>
        /// Отправка сигнала серверу об обмене ключами шифрования<br/>
        /// Отправка ключей шифрования серверу и ожидание получения ключей от сервера
        /// </summary>
        /// <returns>true - сервер ответил на сигнал удовлетворительно<br/>false - cервер не ответил или отказал в обработке сигнала</returns>
        public bool KeyExchange()
        {
            Cryptography.CreateKey(true);
            //Обмен ключами ассиметричного алгоритма для передачи ключей симметричного алгоритма для шифрования/расшифрования данных
        }

        /// <summary>
        /// Сохранение загруженные сообщений от сервера на утройстве в виде кэша
        /// </summary>
        public void Store()
        {
            //Сохранение загруженных в клиент в виде кэша для последующей загрузки локально
        }

        /// <summary>
        /// Подгрузка кэша до возможности обновления
        /// </summary>
        public void OfflineGet()
        {
            //Пока не произошло подключение к серверу и авторизация, старый кэш будет подгружен вместо обновления
        }

        /// <summary>
        /// Очистка старых сообщений, если объём занятого места превышает максимальный для кэша
        /// </summary>
        public void ClearOld()
        {
            if (busy > maxSize) // если кэш превышает максимальную выделенную память
            {
                // Удаление самых старых записей в кэше
            }
        }
    }
}