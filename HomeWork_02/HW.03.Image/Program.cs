using System;
using System.IO;

namespace HW._03.Image
{
    /* Algoritm
     * 1) Прочитать исходный файл.
     * 2) Записать считанные данные в переменную.
     * 3) Создать массив строк, который будет хранить считанные данные в ячейках по 8 символов.
     * 4) Создать массив байт такой же длины, как массив в шаге 3.
     * 5) Выбрать первый элемент массива.
     * 6) Конвертировать выбранный элемент массива строк в битовый формат.
     * 7) Записать результат в соответствующую ячейку массива байт.
     * 8) ЕСЛИ элементы массива ещё есть , ТО перейти к следующему элементу массива строк и повторить алгоритм с шага 6, ИНАЧЕ перейти к шагу 9.
     * 9) Записать массив байт в новый файл.
     */
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader textReader = new StreamReader(@"C:\Temp\image.txt", true);
            string textReaderResult = textReader.ReadToEnd();
            textReader.Dispose();
            string[] arrayOfTextResult = textReaderResult.Split(' ');
            byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];
            for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
            {
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
                imageBytes[i] = binary;
            }
            File.WriteAllBytes(@"C:\Temp\image.png", imageBytes);
        }
    }
}
