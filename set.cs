using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
     
        
    class Program
    {
        static void Main(string[] args)
        {
            ////Задача 1
            //var set1 = new HashSet<int>() { 11, 13, 48, 6, 78, 34 };
            //var set2 = new HashSet<int>() { 63, 11, 13, 7, 23, 78 };
            ////1.1
            //var intersect = new HashSet<int>(set1);
            //intersect.IntersectWith(set2);
            //Console.WriteLine(string.Join(",", intersect));
            ////1.2
            //var symmer = new HashSet<int>(set1);
            //symmer.SymmetricExceptWith(set2);
            //Console.WriteLine(string.Join(",", symmer));
            ////1.3
            //var union = new HashSet<int>(set1);
            //union.UnionWith(set2);
            //Console.WriteLine(string.Join(",", union));
            ////1.3
            //var exept = new HashSet<int>(set1);
            //exept.ExceptWith(set2);
            //Console.WriteLine(string.Join(",", exept));

            //4.4. Создайте новый массив с использованием вашей функции и примените к ней две ваши функции для фильтрации
            int[] new_array = unique_integer_array();
            Console.WriteLine("Массив от 1 до 100:");
            foreach (var item in new_array)
                Console.Write(item + " ");
            Console.WriteLine("\nМассив без четных чисел:");
            foreach (var item in filtr_even_number(new_array))
                Console.Write(item + " ");
            Console.WriteLine("\nМассив без кратных трем:");
            foreach (var item in multiple_of_three(new_array))
                Console.Write(item + " ");
            
           
        }
        //Задача 3
        public static (int, int) MinMaxSet(HashSet<int> arr1)
        {
            int max = int.MaxValue;
            int min = int.MinValue;
            foreach (int item in arr1)
            {
                if (item < min)
                {
                    min = item;
                }
                else if (item > max)
                {
                    max = item;
                }
            }
            return (max, min);
        }

        //Задача 4
        //4.1. Вам нужно создать функцию для фильтрации переданного в неё массива.Функция должна возвращать новый массив без четных чисел.
        public static int[] filtr_even_number(int[] arr)
        {
            var new_arr = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] % 2 == 1)
                {
                    new_arr.Add(arr[i]);
                }
            }
            arr = new_arr.ToArray();
            return arr;
        }
        //4.2. Создайте еще одну функцию, которая будет возвращать массив без чисел, кратных трем.
        public static int[] multiple_of_three(int[] arr)
        {
            var new_arr = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 3 != 0)
                {
                    new_arr.Add(arr[i]);
                }
            }
            arr = new_arr.ToArray();
            return arr;
        }
        //4.3. Создайте функцию для создания массива, который содержит в себе уникальные целочисленные элементы от 0 до 100. Верните этот массив с неупорядаченными элементами.
        public static int[] unique_integer_array()
        {
            int[] array = Enumerable.Range(1,100).ToArray();
            int number = 0;
            var rnd = new Random();
            for (int i = 0; i < array.Length; ++i)
            {
                int random_index = rnd.Next(array.Length);
                int temp = array[random_index];
                array[random_index] = array[i];
                array[i] = temp;
                
                
            }
            return array;
        }
    }
    //Задача 2
    class Transformations
    {
        public HashSet<T> toSet<T>(T[] arr)
        {
            var set = new HashSet<T>(arr);
            return set;
        }
    }
}

