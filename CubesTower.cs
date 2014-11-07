using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cubes
{
    class CubesTower
    {
        private static int MaxCubes = 100;
        private int numOfCubes;
        private Cube[] cubes;

        public static int GetMaxCubes()
        {
            return CubesTower.MaxCubes;
        }

        public int GetNumOfCubes()
        {
            return this.numOfCubes;
        }
        public void SetNumOfCubes(int noc)
        {
            this.numOfCubes = noc;
        }

        public Cube[] GetCubes()
        {
            return this.cubes;
        }
        public void SetCubes(Cube[] c)
        {
            this.cubes = c;
        }

        public CubesTower(int noc, Cube[] cbs)
        {
            this.numOfCubes = noc;
            this.cubes = cbs;
        }
        public CubesTower()
        {
            this.numOfCubes = 0;
            this.cubes = new Cube[CubesTower.MaxCubes];
        }

        public void AddCube(Cube c)
        {
            if (this.numOfCubes >= CubesTower.MaxCubes)
            {
                Console.WriteLine("Full, can't add no more");
            }
            else
            {
                this.cubes[this.numOfCubes] = c;
                this.numOfCubes++;
            }
        }

        public void RemoveCube()
        {
            if (this.numOfCubes <= 0)
            {
                Console.WriteLine("Empty, can't remove");
            }
            else
            {
                this.cubes[this.numOfCubes - 1] = null;
                this.numOfCubes--;
            }
        }

        public bool isEmpty()
        {
            if (this.numOfCubes >= 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool isFull()
        {
            if (numOfCubes >= CubesTower.MaxCubes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            string s = "Tower of cubes with MaxCubes = " + CubesTower.MaxCubes + " and has " + this.numOfCubes + " cubes:\n";
            for (int i = 0; i < this.numOfCubes; i++)
            {
                s += this.cubes[i].ToString();
            }

            return s;
        }


        public override bool Equals(object obj)
        {
            CubesTower other = (CubesTower)obj;
            if (this.numOfCubes != other.numOfCubes)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < this.numOfCubes; i++)
                {
                    if (!this.cubes[i].Equals(other.cubes[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
        }

    }
}
