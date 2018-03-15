using System;

namespace _01_Exception
{
    class Program
    {
        private static Random rnd;

        public static void Main()
        {
            rnd = new Random();
            //rnd = new Random( );
            Console.Clear();

            int size = rnd.Next(7, 20);
            int[] arr = new int[size];
           
            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(-30, 31);
              
            }
            ShowArr("arr: ", arr);
       

            int val = rnd.Next(-30, 31);
            byte idxStart = 0;
            int idxFound = 0;

            bool isProblem = false; 
            do
            {
                Console.Write("Будемо шукати {0}\nвведiть iндекс початку пошуку( 0-{1} ) : ", val, arr.Length -1);
                try// послідовні блоки try{} catch{}, #1
                {
                    idxStart = Byte.Parse(Console.ReadLine());	// тут може виникнути виключення(Exception)
                    isProblem = false;
                }
                catch (Exception e)	// пишемо один catch на Exception i аналiзуємо тип отриманого виключенн¤
                {
                    Console.Write("Дане невірно введено! ");
                    isProblem = true;
                    if (e.GetType().Name == "FormatException")
                    {
                        Console.Write("Неправильний формат числа.");
                    }
                    else if (e.GetType().Name == "OverflowException")
                    {
                        Console.Write("Число завелике або замале.");
                    }
                    else if (e.GetType().Name == "ArgumentException")
                    {
                        Console.Write("Bведений рядок не є числом.");
                    }
                    Console.WriteLine(" Cпробуйте ще раз\n");

                    continue;

                }
                finally {
                    Console.WriteLine("......................................\n");
                
                }

                try // #2
                {
                    idxFound = Array.IndexOf(arr, val, idxStart);	// також може викинути Exception
                    isProblem = false;
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("Ви  ввели правильне число, але воно за межами розмiрiв масиву.\n");
                    isProblem = true;
                }
                finally
                {
                    Console.WriteLine("**************************************\n");

                }



            } while (isProblem);

            Console.WriteLine("idxFound = {0}\n\n", idxFound);

        }// public static void Main()


        private static void ShowArr(string str, int[] arr)
        {
            Console.Write(str);
            foreach (int val in arr)
            {
                Console.Write(" {0,4}", val);
            }
            Console.WriteLine("");
        }


    }// class Program

}// namespace _01_Exception