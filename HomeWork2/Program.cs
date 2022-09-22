using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using CaesarCipher;
#region TASK2
//сложение посчитать не получилось

//class Program
//{

//    static int element = 5;
//    static void Main(string[] args)
//    {
//        var mas = new int[element, element];
//        Random rand = new Random();

//        for (int i = 0; i < element; i++)
//        {
//            for (int j = 0; j < element; j++)
//            {
//                mas[i, j] = rand.Next(-100, 100);
//                Console.Write(mas[i, j] + "\t");

//            }
//            Console.WriteLine();
//        }


//        Console.WriteLine("Минимальный элемент: " + GetMin(mas));
//        Console.WriteLine("Максимальный элемент: " + GetMax(mas));

//        Console.ReadLine();



//    }

//    private static int GetMax(int[,] mas)
//    {
//        int result = mas[0, 0];
//        for (int i = 0; i < element; i++)
//            for (int j = 0; j < element; j++)
//                if (result < mas[i, j])
//                    result = mas[i, j];
//        return result;
//    }

//    private static int GetMin(int[,] mas)
//    {
//        int result = mas[0, 0];
//        for (int i = 0; i < element; i++)
//            for (int j = 0; j < element; j++)
//                if (result > mas[i, j])
//                    result = mas[i, j];
//        return result;
//    }

//}
#endregion //TASK2
#region TASK3
//namespace CaesarCipher
//{
//    class ConverToCaesarCipher
//    {
//        static string alph = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

//        public static string Encryption(string text)
//        {
//            var res = new StringBuilder();
//            for (int i = 0; i < text.Length; i++)
//                for (int j = 0; j < alph.Length; j++)
//                    if (text[i] == alph[j]) res.Append(alph[(j + 3) % alph.Length]);

//            return res.ToString();
//        }
//        public static string Decryption(string crypt)
//        {
//            var res = new StringBuilder();
//            for (int i = 0; i < crypt.Length; i++)
//                for (int j = 0; j < alph.Length; j++)
//                    if (crypt[i] == alph[j]) res.Append(alph[(j - 3 + alph.Length) % alph.Length]);

//            return res.ToString();
//        }
//    }

//    class Progress
//    {
//       static void Main(string[] args)
//       {
//            string text;
//    Console.WriteLine("Введите текст:");
//text = Console.ReadLine();
//    string crypt = CaesarCipher.ConverToCaesarCipher.Encryption(text);
//    string decrypt = CaesarCipher.ConverToCaesarCipher.Decryption(crypt);

//    Console.WriteLine("текст: {0},криптограмма: {1}, дешифрованный текст: {2}", text,  crypt, decrypt);

// Console.ReadLine();  
//        }
//    }


//}
#endregion //TASK3

