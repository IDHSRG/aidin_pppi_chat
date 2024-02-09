public class Cryptography
{
  public static byte[][] CreateKey(bool isAsym)
  {
    byte[][] keys;
    //Создание пары ключей симметричного алгоритма, если isAsym = false 
    //Создание пары ключей асимметричного алгоритма, если isAsym = true
    return keys;
  }

  public static byte[] EncryptFile(string path, byte[] key)
  {
    //Чтение и шифрование прикрепляемого файла с помощью указанного ключа шифрования
  }

  public static byte[] EncryptMessage(Message msg, byte[] key)
  {
    //Шифрование информации внутри объекта msg указанным ключом
  }

  public static byte[] DecryptFile(byte[] file, byte[] key)
  {
    //Дешифрование прикрепляемого файла с помощью указанного ключа шифрования
  }

  public static byte[] DecryptMessage(Message msg, byte[] key)
  {
    //Дешифрование информации внутри объекта msg указанным ключом
  }

  public static byte[] EncryptSymKey(byte[][] key, byte[] asymKey)
  {
    //Шифрование ключей симметричного алгоритма ключом ассиметричного алгоритма для обмена клиента с сервером
  }
}
