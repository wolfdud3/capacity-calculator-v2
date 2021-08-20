using System;

namespace CapacityCalcV2
{
    class Program
    {
        static void CubeCalc()
        {
            Console.WriteLine("CUBE");

            Console.WriteLine("Please insert X:");
            string cubeXstring = Console.ReadLine();
            int cubeX = Convert.ToInt32(cubeXstring);

            int cubeVolume = cubeX * cubeX * cubeX;
            Console.WriteLine(cubeVolume);
        }

        static void CuboidCalc()
        {
            Console.WriteLine("CUBIOD");

            //x
            Console.WriteLine("Please insert X:");
            string cubiodXstring = Console.ReadLine();
            int cubiodX = Convert.ToInt32(cubiodXstring);

            //y
            Console.WriteLine("Please insert Y:");
            string cubiodYstring = Console.ReadLine();
            int cubiodY = Convert.ToInt32(cubiodYstring);

            //z
            Console.WriteLine("Please insert Z:");
            string cubiodZstring = Console.ReadLine();
            int cubiodZ = Convert.ToInt32(cubiodZstring);

            //x*y*z
            int cubiodVolume = cubiodX * cubiodY * cubiodZ;
            Console.WriteLine(cubiodVolume);
        }

        static void SphereCalc()
        {
            Console.WriteLine("NOT WORKING CURRENTLY BECAUSE I AM LAZY");
        }

        static void Main(string[] args)
        {

            ConsoleKeyInfo cki;
            Console.WriteLine("Welcome to Capacity Calculator V2 by Wolfdud3");
            do
            {
                Console.WriteLine("-----");
                Console.WriteLine("1 - Cube");
                Console.WriteLine("2 - Cuboid");
                Console.WriteLine("3 - Sphere");
                Console.WriteLine("Press esc to quit.");


                cki = Console.ReadKey();
                Console.WriteLine("");

                //switch to decide between calcs
                switch(cki.Key)
                {
                    //square
                    case ConsoleKey.D1:
                        CubeCalc();
                        break;

                    //rectangle
                    case ConsoleKey.D2:
                        CuboidCalc();
                        break;

                    //circle
                    case ConsoleKey.D3:
                        SphereCalc();
                        break;
                }    
            }
            while (cki.Key != ConsoleKey.Escape);
            {
                //exit application
            }
        }
    }
}
