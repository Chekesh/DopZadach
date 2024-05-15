using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DopZadach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Train train_1 = new Train("Москва", 978, "17:45");
            Train train_2 = new Train("Санкт-Петербург", 567, "10:00");
            Train train_3 = new Train("Казань", 43, "20:30");
            Train train_4 = new Train("Волгоград", 111, "23:15");
            Train train_5 = new Train("Абакан", 666, "13:45");
            Train train_6 = new Train("Абакан", 777, "13:35");

            Train[] trains = new Train[] { train_1, train_2, train_3, train_4, train_5, train_6 };
            CombSortNum(trains);

            foreach (var tra in trains)
            {
                Console.WriteLine(tra.number);
            }

            int num = Convert.ToInt32(Console.ReadLine());
            outputTrain(trains, num);

            CombSortDes(trains);

            foreach (var tra in trains)
            {
                Console.WriteLine($"Поезд: {tra.destination}, {tra.number}, {tra.departureTime}");
            }
            Console.Read();
        }

        static public void outputTrain(Train[] array, int num)
        {
            int znach = 0;
            foreach(var el in array)
            {
                if(el.number == num)
                {
                    Console.WriteLine($"Поезд: {el.destination}, {el.number}, {el.departureTime}\n");
                    znach++;
                }
            }
            if (znach == 0)
            {
                Console.WriteLine("Такого поезда нет\n");
            }
        }

        static void CombSortNum(Train[] array)
        {
            double factor = 1.247;
            int step = array.Length;
            while (step > 1)
            {
                step = (int)(step / factor);
                //Console.WriteLine(step);
                for (int i = 0; step + i < array.Length; i++)
                {
                    if (array[i].number > array[i + step].number)
                    {
                        swap(array, i, i + step);
                    }
                }
            }
        }
        static void swap(Train[] array, int x, int y)
        {
            Train temp = array[x];
            array[x] = array[y];
            array[y] = temp;
        }

        static void CombSortDes(Train[] array)
        {
            double factor = 1.247;
            int step = array.Length;
            while (step > 1)
            {
                step = (int)(step / factor);
                //Console.WriteLine(step);
                for (int i = 0; step + i < array.Length; i++)
                {
                    if (Destination(array[i], array[i + step]))//array[i].number > array[i + step].number)
                    {
                        swap(array, i, i + step);
                    }
                }
            }
        }
        
        static bool Destination(Train tr1, Train tr2)
        {
            if (String.Compare(tr1.destination, tr2.destination) > 0)
            {
                return true;
            }
            else if (String.Compare(tr1.destination, tr2.destination) < 0)
            {
                return false;
            }
            else
            {
                if (String.Compare(tr1.departureTime, tr2.departureTime) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
