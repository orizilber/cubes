using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cubes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating 2 cubes");
            Cube c1 = new Cube(6, "Red");
            Console.WriteLine(c1.ToString());

            Cube c2 = new Cube(8, "White");
            Console.WriteLine(c2.ToString());

            Console.WriteLine("Creating cubes tower with both cubes");
            CubesTower ct = new CubesTower();
            ct.AddCube(c1);
            ct.AddCube(c2);

            Console.WriteLine(ct.ToString());

            Console.WriteLine("Removing last cube");
            ct.RemoveCube();

            Console.WriteLine(ct.ToString());
            Console.WriteLine("IsEmpty = " + ct.isEmpty());

            Console.WriteLine("Removing another cube");
            ct.RemoveCube();

            Console.WriteLine(ct.ToString());
            Console.WriteLine("IsEmpty = " + ct.isEmpty());

            Console.WriteLine("IsFull = " + ct.isFull());

            Console.WriteLine("Filling up the tower till explodes");
            for (int i = 0; i < CubesTower.GetMaxCubes(); i++)
            {
                ct.AddCube(c1);
            }

            Console.WriteLine(ct.ToString());
            Console.WriteLine("IsFull = " + ct.isFull());
        }
    }
}
