﻿using System;
using System.IO;
using System.Collections.Generic;
namespace CursoNelioAula2110
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\ivan.ostorari\Desktop\Formacao_C_Sharp_2_Nelio_Alves\Principal\Projetos\CursoNelioAula211.0\in.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<string> list = new List<string>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
                    }
                    list.Sort();
                    foreach (string str in list)
                    {
                        Console.WriteLine(str);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}