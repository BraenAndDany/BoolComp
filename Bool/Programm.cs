using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using booling;

namespace console
{

    /*ебать я в начале ахуел от вашего кода, но потом разобрался, если интересно что я там добавил, то читайте комменты и удалите их потом, чуть ниже есть один коммент не лучшего содержания.
    А еще тут есть много визуальных хуен, котрорые хорошо бы пофиксить. 
    Тут код простой, даже без комментов разберетесь, возможно NoAndForThree можно было сделать изящнее, но мне было впадлу ;)*/
    class Program
    {
        public void Auto()
        {
            bool first = false;
            bool second = false;
            bool third = false;
            for (int i = 0; i < 8; i++)
            {

                first = (i & 4) != 0;
                second = (i & 2) != 0;
                third = (i & 1) != 0;

                Console.Write(first);
                Console.Write(second);
                Console.WriteLine(false);
            }
        }
        static void Main(string[] args)
        {
            booli booling =  new booli();

            bool first = false;
            bool second = false;
            bool third = false;
            //Console.WriteLine("Таблица второго задания");
            //Console.Write(" " + "A" + "        ");
            //Console.Write(" " + "B" + "       |");
            //Console.Write("No" + "    ");
            //Console.Write("And" + "    ");
            //Console.Write("Or" + "     ");
            //Console.Write("Xor" + "    ");
            //Console.Write("Xnor" + "   ");
            //Console.Write("Impl" + "   ");
            //Console.Write("NoImpl" + "    ");
            //Console.WriteLine();
            //for (int i = 0; i < 4; i++)
            //{
            //    first = (i & 2) != 0;
            //    second = (i & 1) != 0;

            //    Console.Write(" " + first + "   ");
            //    Console.Write(" " + second + "   |");
            //    booling.No(first);
            //    booling.And(first, second);
            //    booling.Or(first, second);
            //    booling.Xor(first, second);
            //    booling.Xnor(first, second);
            //    booling.Impl(first, second);
            //    booling.NoImpl(first, second);
            //    Console.WriteLine();
            //}
            Console.WriteLine("Первая таблица");
            Console.Write(" " + "A" + "        ");
            Console.Write(" " + "B" + "        ");
            Console.Write(" " + "C" + "       |");
            Console.Write("XAndY" + "    ");
            Console.Write("XAndYAndZ" + "    ");
            Console.WriteLine();
            for (int i = 0; i < 8; i++)
            {
                first = (i & 4) != 0;
                second = (i & 2) != 0;
                third = (i & 1) != 0;
                Console.Write(" " + first + "   ");
                Console.Write(" " + second + "   ");
                Console.Write(" " + third + "     |");
                Console.Write(" " + booling.And(first, second) + "   ");
                Console.Write(" " + booling.And(booling.And(first,second),booling.And(second,third)) + "   ");
                Console.WriteLine();
            }
            Console.WriteLine("Вторая таблица");
            Console.Write(" " + "A" + "        ");
            Console.Write(" " + "B" + "        ");
            Console.Write(" " + "C" + "       |");
            Console.Write("NoY" + "    ");
            Console.Write("XAndNoY" + "    ");
            Console.Write("XAndNoYAndZ" + "    ");
            Console.WriteLine();
            for (int i = 0; i < 8; i++)
            {
                first = (i & 4) != 0;
                second = (i & 2) != 0;
                third = (i & 1) != 0;
                Console.Write(" " + first + "   ");
                Console.Write(" " + second + "   ");
                Console.Write(" " + third + "     |");
                Console.Write(" " + booling.No(second) + "   ");
                Console.Write(" " + booling.And(first, booling.No(second)) + "   ");
                Console.Write(" " + booling.And(booling.And(first, booling.No(second)), booling.And(booling.No(second), third)) + "   ");
                Console.WriteLine();
            }
            Console.WriteLine("Третья таблица");
            Console.Write(" " + "A" + "        ");
            Console.Write(" " + "B" + "        ");
            Console.Write(" " + "C" + "       |");
            Console.Write("XAndY" + "    ");
            Console.Write("NoZ" + "    ");
            Console.Write("XAndYAndNoZ" + "    ");
            Console.WriteLine();
            for (int i = 0; i < 8; i++)
            {
                first = (i & 4) != 0;
                second = (i & 2) != 0;
                third = (i & 1) != 0;
                Console.Write(" " + first + "   ");
                Console.Write(" " + second + "   ");
                Console.Write(" " + third + "     |");
                Console.Write(" " + booling.And(first, second) + "   ");
                Console.Write(" " + booling.No(third) + "   ");
                Console.Write(" " + booling.And(booling.And(first,second), booling.And(second, booling.No(third))) + "   ");
                Console.WriteLine();
            }
            Console.WriteLine("Четвертая таблица");
            Console.Write(" " + "A" + "        ");
            Console.Write(" " + "B" + "        ");
            Console.Write(" " + "C" + "       |");
            Console.Write("NoX" + "    ");
            Console.Write("NoY" + "    ");
            Console.Write("NoXAndNoY" + "    ");
            Console.Write("NoZ" + "    ");
            Console.Write("NoXAndNoYAndNoZ" + "    ");
            Console.WriteLine();
            for (int i = 0; i < 8; i++)
            {
                first = (i & 4) != 0;
                second = (i & 2) != 0;
                third = (i & 1) != 0;
                Console.Write(" " + first + "   ");
                Console.Write(" " + second + "   ");
                Console.Write(" " + third + "     |");
                Console.Write(" " + booling.No(first) + "   ");
                Console.Write(" " + booling.No(second) + "   ");
                Console.Write(" " + booling.And(!first,booling.No(second)) + "   ");
                Console.Write(" " + booling.No(third) + "   ");
                Console.Write(" " + booling.And(booling.And(booling.No(first), booling.No(second)), booling.And(booling.No(second),booling.No(third))) + "   ");
                Console.WriteLine();
            }
            Console.WriteLine("Пятая таблица");
            Console.Write(" " + "A" + "        ");
            Console.Write(" " + "B" + "        ");
            Console.Write(" " + "C" + "       |");
            Console.Write("XOrY" + "    ");
            Console.Write("XOrYOrZ" + "    ");
            Console.WriteLine();
            for (int i = 0; i < 8; i++)
            {
                first = (i & 4) != 0;
                second = (i & 2) != 0;
                third = (i & 1) != 0;
                Console.Write(" " + first + "   ");
                Console.Write(" " + second + "   ");
                Console.Write(" " + third + "     |");
                Console.Write(" " + booling.Or(first, second) + "   ");
                Console.Write(" " + booling.Or(booling.Or(first, second), booling.Or(second,third)) + "   ");
                Console.WriteLine();
            }
            Console.WriteLine("Шестая таблица");
            Console.Write(" " + "A" + "        ");
            Console.Write(" " + "B" + "        ");
            Console.Write(" " + "C" + "       |");
            Console.Write("NoY" + "    ");
            Console.Write("XOrNoY" + "    ");
            Console.Write("XOrNoYOrZ" + "    ");
            Console.WriteLine();
            for (int i = 0; i < 8; i++)
            {
                first = (i & 4) != 0;
                second = (i & 2) != 0;
                third = (i & 1) != 0;
                Console.Write(" " + first + "   ");
                Console.Write(" " + second + "   ");
                Console.Write(" " + third + "     |");
                Console.Write(" " + booling.No(second) + "   ");
                Console.Write(" " + booling.Or(first,booling.No(second)) + "   ");
                Console.Write(" " + booling.Or(booling.Or(first, booling.No(second)), booling.Or(booling.No(second), third)) + "   ");
                Console.WriteLine();
            }
            Console.WriteLine("Седьмая таблица");
            Console.Write(" " + "A" + "        ");
            Console.Write(" " + "B" + "        ");
            Console.Write(" " + "C" + "       |");
            Console.Write("NoZ" + "    ");
            Console.Write("XOrY" + "    ");
            Console.Write("XOrYOrNoZ" + "    ");
            Console.WriteLine();
            for (int i = 0; i < 8; i++)
            {
                first = (i & 4) != 0;
                second = (i & 2) != 0;
                third = (i & 1) != 0;
                Console.Write(" " + first + "   ");
                Console.Write(" " + second + "   ");
                Console.Write(" " + third + "     |");
                Console.Write(" " + booling.Or(first, second) + "   ");
                Console.Write(" " + booling.No(third) + "   ");
                Console.Write(" " + booling.Or(booling.Or(first,second), booling.Or(second,booling.No(third))) + "   ");
                Console.WriteLine();
            }
            Console.WriteLine("Восьмая таблица");
            Console.Write(" " + "A" + "        ");
            Console.Write(" " + "B" + "        ");
            Console.Write(" " + "C" + "       |");
            Console.Write("NoX" + "    ");
            Console.Write("NoY" + "    ");
            Console.Write("NoXOrNoY" + "    ");
            Console.Write("NoZ" + "    ");
            Console.Write("NoXOrNoYOrNoZ" + "    ");
            Console.WriteLine();
            for (int i = 0; i < 8; i++)
            {
                first = (i & 4) != 0;
                second = (i & 2) != 0;
                third = (i & 1) != 0;
                Console.Write(" " + first + "   ");
                Console.Write(" " + second + "   ");
                Console.Write(" " + third + "     |");
                Console.Write(" " + booling.No(first) + "   ");
                Console.Write(" " + booling.No(second) + "   ");
                Console.Write(" " + booling.Or(booling.No(first),booling.No(second)) + "   ");
                Console.Write(" " + booling.No(third) + "   ");
                Console.Write(" " + booling.Or(booling.Or(booling.No(first),booling.No(second)), booling.Or(booling.No(second), booling.No(third))) + "   ");
                Console.WriteLine();
            }

            ////тут почему-то false улетает в таджикистан, можете исправить или забейте
            Console.WriteLine("Девятая таблица");
            Console.Write(" " + "A" + "        ");
            Console.Write(" " + "B" + "        ");
            Console.Write(" " + "C" + "       |");
            Console.Write("XAndY" + "    ");
            Console.Write("XAndYAndZ" + "    ");
            Console.Write("No(XAndYAndZ)" + "    ");
            Console.WriteLine();
            for (int i = 0; i < 8; i++)
            {
                first = (i & 4) != 0;
                second = (i & 2) != 0;
                third = (i & 1) != 0;
                Console.Write(" " + first + "   ");
                Console.Write(" " + second + "   ");
                Console.Write(" " + third + "     |");
                Console.Write(" " + booling.And(first, second) + "   ");
                Console.Write(" " + booling.And(booling.And(first, second), booling.And(second, third)) + "   ");
                Console.Write(" " + booling.No(booling.And(booling.And(first, second), booling.And(second, third)))+"   ");
                Console.WriteLine();
            }
            //тут тоже почему-то false улетает в таджикистан, можете исправить или забейте
            Console.WriteLine("Десятая таблица");
            Console.Write(" " + "A" + "        ");
            Console.Write(" " + "B" + "        ");
            Console.Write(" " + "C" + "       |");
            Console.Write("NoY" + "    ");
            Console.Write("XAndNoY" + "    ");
            Console.Write("XAndNoYAndZ" + "    ");
            Console.Write("No(XAndNoYAndZ)" + "    ");
            Console.WriteLine();
            for (int i = 0; i < 8; i++)
            {
                first = (i & 4) != 0;
                second = (i & 2) != 0;
                third = (i & 1) != 0;
                Console.Write(" " + first + "   ");
                Console.Write(" " + second + "   ");
                Console.Write(" " + third + "     |");
                Console.Write(" " + booling.No(second) + "   ");
                Console.Write(" " + booling.And(first, booling.No(second)) + "   ");
                Console.Write(" " + booling.And(booling.And(first, booling.No(second)), booling.And(booling.No(second), third)) + "   ");
                Console.Write(" " + booling.No(booling.And(booling.And(first, booling.No(second)), booling.And(booling.No(second), third))) + "   ");
                Console.WriteLine();
            }





        }
    }
}
