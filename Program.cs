using System;

namespace CapacityCalcV2
{
    class Program
    {
        static void CubeCalc()
        {
            Console.WriteLine("CUBE");

            Console.WriteLine("Please insert X and press Enter:");
            string cubeXstring = Console.ReadLine();
            int cubeX = Convert.ToInt32(cubeXstring);

            int cubeVolume = cubeX * cubeX * cubeX;
            Console.WriteLine("\r\nThe result is: " + cubeVolume);
        }

        static void CuboidCalc()
        {
            Console.WriteLine("CUBIOD");

            //x
            Console.WriteLine("Please insert X and press Enter:");
            string cubiodXstring = Console.ReadLine();
            int cubiodX = Convert.ToInt32(cubiodXstring);

            //y
            Console.WriteLine("Please insert Y and press Enter:");
            string cubiodYstring = Console.ReadLine();
            int cubiodY = Convert.ToInt32(cubiodYstring);

            //z
            Console.WriteLine("Please insert Z and press Enter:");
            string cubiodZstring = Console.ReadLine();
            int cubiodZ = Convert.ToInt32(cubiodZstring);

            //x*y*z
            int cubiodVolume = cubiodX * cubiodY * cubiodZ;
            Console.WriteLine("\r\nThe result is: " + cubiodVolume);
        }

        static void SphereCalc()
        {
            //diameter
            Console.WriteLine("Please insert the diameter and press Enter:");
            string diameterString = Console.ReadLine();
            double diameter = Convert.ToInt32(diameterString);

            //calc 
            double pi = Math.PI;
            double radius = diameter / 2;
            double radiusCube = radius * radius * radius;

            //calc volume
            double sphereVolume = (4.0f / 3.0f) * pi * radiusCube;
            Console.WriteLine("\r\nThe result is :" + sphereVolume);

        }

        static void Main(string[] args)
        {

            ConsoleKeyInfo cki;
            Console.WriteLine("Welcome to Capacity Calculator V2 by Wolfdud3");
            Console.WriteLine("-----");
            do
            {
                Console.WriteLine("\r\nPLEASE SELECT WHAT YOU WANT TO CALCULATE:\r\n");
                Console.WriteLine("1 - Cube");
                Console.WriteLine("2 - Cuboid");
                Console.WriteLine("3 - Sphere");
                Console.WriteLine("Press esc to quit.");
                Console.WriteLine("-----");


                cki = Console.ReadKey();
                Console.WriteLine("");

                //switch to decide between calcs
                switch(cki.Key)
                {
                    //cube
                    case ConsoleKey.D1:
                        CubeCalc();
                        break;

                    //cuboid
                    case ConsoleKey.D2:
                        CuboidCalc();
                        break;

                    //sphere
                    case ConsoleKey.D3:
                        SphereCalc();
                        break;

                    //CHOICE WITH NUMBER PAD
                    //cube NumPad
                    case ConsoleKey.NumPad1:
                        CubeCalc();
                        break;

                    //cuboid NumPad
                    case ConsoleKey.NumPad2:
                        CuboidCalc();
                        break;

                    //sphere
                    case ConsoleKey.NumPad3:
                        SphereCalc();
                        break;

                }
                Console.WriteLine("\r\n----------");
            }
            while (cki.Key != ConsoleKey.Escape);
            {
                //exit application
            }
        }
    }
}
