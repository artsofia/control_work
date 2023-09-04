using System.ComponentModel;

namespace task;
class Program
{
    static void Main(string[] args)
    {
        string InputStr(string text)
            {
                Console.Write(text);
                return Console.ReadLine();
            }


        int InputInt(string text)
            {
                Console.Write(text);
                return Convert.ToInt32(Console.ReadLine());
            }


        string[] FillArray()
            { 
                int sizeArray = InputInt("Введите колличество элементов в массиве: ");
                string[] array = new string[sizeArray];
                
                for (int i = 0; i < sizeArray; i++)
                {
                    array[i] = InputStr("Введите элемент массива: ");
                }

                return array;
            }


        void NewArray(string[] array)
        {     
            if (array.Length <= 3)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.Write("[");

                for (int i = 3; i < array.Length; i++)
                    {
                        Console.Write(array[i] + ", ");
                    }

                Console.Write("\b\b");
                Console.Write("]");
            }
        }

        Console.Clear();
        string[] array = FillArray();
        NewArray(array);
    }   
}