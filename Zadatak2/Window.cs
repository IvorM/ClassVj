using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    class Window
    {
        public string naslov, oznaka;
        public int x1, y1, x2, y2;
        public bool aktivan;
        public Boja boja;

        public Window(string naslov)
        {
            this.naslov = naslov;
        }

        public Window()
        {
            this.naslov = "window1";
            this.x1 = 0;
            this.x2 = 10;
            this.y1 = 0;
            this.y2 = 5;
        }

        public string GetInfo()
        {
            return $"{naslov} {oznaka} {aktivan} ({x1},{x2}) ({y1},{y2})";
        }

        public int Width()
        {
            return Math.Abs(x2 - x1);
        }

        public int Height()
        {
            return Math.Abs(y2 - y1);
        }

        public string Draw()
        {
            string povrat = "";
            for (int i = 0; i < Height(); i++)
            {
                for (int j = 0; j < Width(); j++)
                {
                    if (NaRubu(i,j))
                    {
                        povrat += "*";
                    }
                    else
                    {
                        povrat += " ";
                    }
                }

                povrat += "\n";
            }

            return povrat;
        }

        private bool NaRubu(int i,int j)
        {
            if (i == 0)
            {
                return true;
            }
            else if (j == 0)
            {
                return true;
            }
            else if (i==Height()-1)
            {
                return true;
            }
            else if(j==Width()-1)
            {
                return true;
            }
            else return false;
        }


        public override string ToString()
        {
            return $"Naslov:{naslov} \n Oznaka:{oznaka}";
        }
    }
}
