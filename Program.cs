using System;

namespace HomeWorkCourse_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] nxn = new int[5,5];//создаем матрицу
            Random Ran = new Random(2);
            for (int i = 0; i < 5; i++) {//заполняем дефолтными числами
                for (int j = 0; j < 5; j++) {
                    nxn[i, j] = Ran.Next(2);
                    Console.Write(nxn[i,j]);
                }
                Console.WriteLine();
            }
            //-----------------------------
            Console.ReadKey();
            

        }
        public void Meanings(){
            int x, y,value;
            Console.WriteLine("Какую ячейку берем?");
            Console.WriteLine("Какой столбец?");
            x = Convert.ToInt32(Console.Read());
            Console.WriteLine("Какая строка?");
            y = Convert.ToInt32(Console.Read());
            Console.WriteLine("Введите новое значение?");
            value = Convert.ToInt32(Console.Read());
            
        }
    }
}
