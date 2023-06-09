﻿using System;

namespace XOR_shifr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сообщение:");
            string text = Console.ReadLine();
            Console.WriteLine("Введите ключ:");
            var key = Console.ReadLine();
            string get_key = key;
            int text_len = text.Length;
            while (get_key.Length < text_len)
            {
                get_key += get_key;
            }
            string get_key_sub = get_key.Substring(0, text_len);

            var result = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                result += ((char)(text[i] ^ get_key_sub[i])).ToString();
            }
            Console.WriteLine("Сообщение - " + text);
            Console.WriteLine("Зашифрованное сообщение - " + result);

            int enc_text_len = text.Length;
            while (get_key.Length < enc_text_len)
            {
                get_key += get_key;
            }

            string enc_get_key_sub = get_key.Substring(0, enc_text_len);

            var enc_result = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                enc_result += ((char)(result[i] ^ enc_get_key_sub[i])).ToString();
            }
            Console.WriteLine("Расшифрованное сообщение - " + enc_result);
        }
    }
}
