using System;

namespace PlateBuilding
{
    class ThrowPlateFromBuilding
    {
        public static void MinTry(int floors)
        {
            Random rand = new Random();
            int plate = 2;
            int square = (int)Math.Sqrt(floors);
            int floor = square;
            int count = 1;

            while (plate != 0 && floor<=floors)
            {
                plate -= rand.Next(0,2);
                if (plate == 1) {
                    for (int i = floor-square+1; i < floor; i++)
                    {
                        count++;
                        plate -= rand.Next(0,2);
                        if (plate == 1)
                        {
                            continue;
                        }
                        else {
                            floor = i;
                            break;
                        }
                    }
                }

                else if (plate == 2)
                {
                    floor += square;
                    count++;
                }
            }
            if (Math.Sqrt(floors) != (int)Math.Sqrt(floors))
            {
                if (plate != 0 && floor > floors)
                {
                    for (int i = floor-square; i <= floors; i++)
                    {
                        count++;
                        plate -= rand.Next(0, 2);
                        if (plate == 0 || plate ==1)
                        {
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }

                }
            }
            Console.WriteLine(count);
        }

        static void Main(string[] args)
        {
            MinTry(100);
        }
    }
}
