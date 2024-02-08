public class Account
{
  private long userID;
  public string Name, Surname;
  public string PhoneNumber;
  public string Status;
  
  public Account(string phone, string name, string surname)
  {
    //Создание аккаунта
  }

  public override operator==(Account ac1, Account ac2)
  {
    //Сравнение аккаунтов по их ID, потому что остальные данные могут меняться
  }
}
