using System;

namespace ConsoleApp6
{
    class Program
    {
        public class Vagon
        {
            public string name;
            public int num_beds;
            public int num_sits;
            public int total_number;



            public Vagon(string nam, int num_b, int num_s, int total_num)
            {
                name = nam;
                num_beds = num_b;
                num_sits = num_s;
                total_number = total_num;


            }

        }

        public static void Main(string[] args)
        {


            Vagon[] vagons = new Vagon[] {
                new Vagon("Вагон №1", 54,0,54),
                new Vagon("Вагон №2", 36,0,36),
                new Vagon("Вагон №3", 0,50,50),
                new Vagon("Вагон №4", 36,0,36),
            };

            foreach (var vagon in vagons)
            {
                Console.WriteLine(
                    $"{vagon.name}" +
                    $"  Количество спальных мест:{vagon.num_beds}" +
                    $"  Количество сидячих мест:{vagon.num_sits}" +
                    $"  Общее количество мест в вагоне:{vagon.total_number}"
                    );

            }

            int all_number = 0, all_bed_num = 0, all_sits_num = 0;

            foreach (var vagon in vagons)
            {
                all_number += vagon.total_number;
                all_bed_num += vagon.num_beds;
                all_sits_num += vagon.num_sits;

            }


            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"Общее количество мест:{all_number}");
            Console.WriteLine($"Общее количество спальных мест:{all_bed_num}");
            Console.WriteLine($"Общее количество сидячих мест:{all_sits_num}");

            Console.WriteLine();
            Console.WriteLine();


            int Max_number_vag = 0;

            foreach (var vagon in vagons)
            {

                if (Max_number_vag < vagon.total_number)
                {
                    Max_number_vag += vagon.total_number;
                    Console.WriteLine($"Максимальное число мест в вагоне:{vagon.total_number}");
                }


            }


            Console.WriteLine("Информация о вагоне с максимальным количеством мест:");
            // 
            //
            //
            Console.WriteLine();


            foreach (var vagon in vagons)
            {
                if (Max_number_vag == vagon.total_number)
                {
                    Console.WriteLine(
                    $"{vagon.name}" +
                    $"  Количество спальных мест:{vagon.num_beds}" +
                    $"  Количество сидячих мест:{vagon.num_sits}" +
                    $"  Общее количество мест в вагоне:{vagon.total_number}"
                    );



                }

            }




            Console.ReadKey();




        }




    }

}
