namespace Cryptographi
{
    /// <summary>
    /// Класс, реализующий основные необходимые методы работы с криптографией
    /// </summary>
    public class Cryptography
    {
        /// <summary>
        /// Создания ключей шифрования
        /// </summary>
        /// <returns>Пара ключей шифрования</returns>
        /// <param name="isAsym">true - создание ключей ассиметричного алгоритма<br/>
        /// false - создание ключей симметричного алгоритма</param>
        public static byte[][] CreateKey(bool isAsym)
        {
            byte[][] keys;
            //Создание пары ключей симметричного алгоритма, если isAsym = false 
            //Создание пары ключей асимметричного алгоритма, если isAsym = true
            return keys;
        }

        /// <summary>
        /// Шифрование файла 
        /// </summary>
        /// <returns>Зашифрованный файл в байтовом представлении</returns>
        /// <param name="path">Путь к файлу</param>
        /// <param name="key">Ключ шифрования</param>
        public static byte[] EncryptFile(string path, byte[] key)
        {
            //Чтение и шифрование прикрепляемого файла с помощью указанного ключа шифрования
        }

        /// <summary>
        /// Шифрование сообщения
        /// </summary>
        /// <returns>Зашифрованное сообщение в байтовом представлении</returns>
        /// <param name="msg">Сообщение</param>
        /// <param name="key">Ключ шифрования</param>
        public static byte[] EncryptMessage(Message msg, byte[] key)
        {
            //Шифрование информации внутри объекта msg указанным ключом
        }

        /// <summary>
        /// Расшифровать зашифрованный файл
        /// </summary>
        /// <returns>Расшифрованный файл в байтовом представлении</returns>
        /// <param name="file">Зашифрованный файл</param>
        /// <param name="key">Ключ шифрования</param>
        public static byte[] DecryptFile(byte[] file, byte[] key)
        {
            //Дешифрование прикрепляемого файла с помощью указанного ключа шифрования
        }

        /// <summary>
        /// Расшифровать зашифрованное сообщение
        /// </summary>
        /// <returns>Расшифрованное сообщение</returns>
        /// <param name="msg">Зашифрованное сообщение</param>
        /// <param name="key">Ключ шифрования</param>
        public static Message DecryptMessage(byte[] msg, byte[] key)
        {
            //Дешифрование информации внутри объекта msg указанным ключом
        }

        /// <summary>
        /// Шифрование ключей симметричного алгоритма асимметричным для последующей передачи
        /// </summary>
        /// <returns>Пара зашифрованных ключей</returns>
        /// <param name="asymKey">Ключ шифрования асимметричного алгоритма</param>
        /// <param name="key">Пара ключей симметричного алгоритма</param>
        public static byte[][] EncryptSymKey(byte[][] key, byte[] asymKey)
        {
            //Шифрование ключей симметричного алгоритма ключом ассиметричного алгоритма для обмена клиента с сервером
        }
    }
}