namespace Interface
{
    /// <summary>
    /// Класс, представляющий эмодзи
    /// </summary>
    public class Emoji
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="path">Путь к файлу изображения эмодзи</param>
        public Emoji(string path)
        {
            BitMap small;
            if (/*Размер файла больше нужного*/)
                small = Compress(path);
            //Создание эмодзи по пути к изображению
        }

        /// <summary>
        /// Сжатия файла изображения до размера эмодзи
        /// </summary>
        /// <param name="path">Путь к файлу изображения</param>
        /// <returns>Уменьшенное изображение для эмодзи</returns>
        public static BitMap Compress(string path)
        {
            //Сжатие до размера эмодзи указанного в пути изображения
        }
    }
}