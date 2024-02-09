public class Account
{
  private long userID;
  private string Name, Surname;
  private string PhoneNumber;
  private string Status;

  public GetName();
  public GetSurname();
  public GetPhone();
  public GetStatus();
  public SetName();
  public SetSurname();
  public SetPhone();
  public SetStatus();
  
  public Account(string phone, string name, string surname)
  {
    //Создание аккаунта
  }

  public override operator==(Account ac1, Account ac2)
  {
    //Сравнение аккаунтов по их ID, потому что остальные данные могут меняться
  }
}
