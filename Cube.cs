using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cubes
{
    class Cube
    {
        private int length;
        private string color;

        public Cube()
        {
            this.length = 0;
            this.color = "";
        }
        public Cube(int len, string col)
        {
            this.length = len;
            this.color = col;
        }

        public int GetLength()
        {
            return this.length;
        }
        public string GetColor()
        {
            return this.color;
        }
        public void SetLength(int len)
        {
            this.length = len;
        }
        public void SetColor(string col)
        {
            this.color = col;
        }

        public override string ToString()
        {
            return "This is a cube with length=" + this.length + " and color=" + this.color + "\n";
        }
        public override bool Equals(object obj)
        {
            Cube other = (Cube)obj;
            if (this.length == other.length && this.color == other.color)
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
