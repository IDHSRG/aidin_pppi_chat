/// <summary>
/// Класс, представляющий учётную запись пользователя
/// </summary>
public class Account
{
    /// <summary>
    /// Уникальный код пользователя, который присваивается ему при регистрации в мессенджере
    /// </summary>
    private long userID;

    /// <summary>
    /// Имя пользователя, указанное в аккаунте
    /// </summary>
    private string Name;

    /// <summary>
    /// Фамилия пользователя, указанная в аккаунте
    /// </summary>
    private string Surname;

    /// <summary>
    /// Телефонный номер, на который привязан аккаунт
    /// </summary>
    private string PhoneNumber;

    /// <summary>
    /// Текущий статус аккаунта (в сети, отошёл, не в сети и др.)
    /// </summary>
    private string Status;

    /// <summary>
    /// Получает имя пользователя, указанное в учетной записи
    /// </summary>
    /// <returns>Имя из учетки</returns>
    public string GetName()
    {
        //Получить имя аккаунта
    }

    /// <summary>
    /// Получает фамилию пользователя, указанное в учетной записи
    /// </summary>
    /// <returns>Фамилия из учетки</returns>
    public string GetSurname()
    {
        //Получить фамилию аккаунта
    }

    /// <summary>
    /// Получает фамилию пользователя, указанное в учетной записи
    /// </summary>
    /// <returns>Номер телефона из учетки</returns>
    public string GetPhone()
    {
        //Получить номер телефона аккаунта
    }

    /// <summary>
    /// Получает текущий статус учетной записи (в сети, не в сети и др.)
    /// </summary>
    /// <returns>Статус учетки</returns>
    public string GetStatus()
    {
        //Получить статус аккаунта
    }

    /// <summary>
    /// Привязывает новое имя к учетной записи
    /// </summary>
    /// <param name="name">Имя</param>
    public void SetName(string name)
    {
        //Установить имя аккаунта
    }

    /// <summary>
    /// Привязывает новую фамилию к учетной записи
    /// </summary>
    /// <param name="surname">Фамилия</param>
    public void SetSurname(string surname)
    {
        //Установить фамилию аккаунта
    }

    /// <summary>
    /// Привязывает новый номер телефона к учетной записи
    /// </summary>
    /// <param name="phone">Номер телефона</param>
    public void SetPhone(string phone)
    {
        //Установить номер телефона аккаунта
    }
    /// <summary>
    /// Устанавливает статус учетной записи
    /// </summary>
    /// <param name="status">Cтатус</param>
    public void SetStatus(string status)
    {
        //Установить статус аккаунта
    }

    /// <summary>
    /// Конструктор класса учетной записи
    /// </summary>
    /// <param name="phone">Номер телефона</param>
    /// <param name="name">Имя</param>
    /// <param name="surname">Фамилия</param>
    public Account(string phone, string name, string surname)
    {
    //Создание аккаунта
    }

    /// <summary>
    /// Перегрузка оператора равенства.
    /// Аккаунты считаются равными, если их уникальные ID одинаковы (это единственная неизменяемая часть объекта)
    /// </summary>
    /// <param name="ac1">Первый аккаунт</param>
    /// <param name="ac2">Второй аккаунт</param>
    public static override bool operator==(Account ac1, Account ac2)
    {
        //Сравнение аккаунтов по их ID, потому что остальные данные могут меняться
    }

    /// <summary>
    /// Перегрузка оператора неравенства.
    /// Аккаунты считаются неравными, если их уникальные ID не совпадают(это единственная неизменяемая часть объекта)
    /// </summary>
    /// <param name="ac1">Первый аккаунт</param>
    /// <param name="ac2">Второй аккаунт</param>
    public static override bool operator !=(Account ac1, Account ac2)
    {
        //Сравнение аккаунтов по их ID, потому что остальные данные могут меняться
    }
}
