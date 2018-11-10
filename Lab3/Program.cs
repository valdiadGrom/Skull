using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Point
    {
        int x;
        int y;
        char sym;

        public void SetX(int x)
        {
            if (x >= 0)
                this.x = x;
            else
                this.x = 0;
        }
        public void SetY(int y)
        {
            if (y >= 0)
                this.y = y;
            else
                this.y = 0;
        }
        public void SetSym(char symbol)
        {
            sym = symbol;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point line = new Point();
            line.SetX(9);
            line.SetY(1);
            line.SetSym('-');
            line.Draw();

            line.SetX(10);
            line.Draw();

            line.SetX(11);
            line.Draw();

            line.SetX(12);
            line.Draw();

            line.SetX(13);
            line.Draw();

            line.SetX(14);
            line.Draw();

            line.SetX(15);
            line.Draw();

            line.SetX(16);
            line.Draw();

            line.SetX(17);
            line.Draw();

            line.SetX(7);
            line.SetY(2);
            line.Draw();

            line.SetX(8);
            line.Draw();

            line.SetX(18);
            line.SetY(2);
            line.Draw();

            line.SetX(19);
            line.Draw();

            line.SetX(6);
            line.SetY(3);
            line.Draw();

            line.SetX(5);
            line.SetY(4);
            line.Draw();

            line.SetX(4);
            line.SetY(5);
            line.Draw();

            line.SetX(3);
            line.SetY(6);
            line.Draw();

            line.SetX(20);
            line.SetY(3);
            line.Draw();

            line.SetX(21);
            line.SetY(4);
            line.Draw();

            line.SetX(22);
            line.SetY(5);
            line.Draw();

            line.SetX(23);
            line.SetY(6);
            line.Draw();

            /////////////////

            line.SetX(3);
            line.SetY(7);
            line.SetSym('|');
            line.Draw();

            line.SetY(8);
            line.Draw();

            line.SetY(9);
            line.Draw();

            line.SetY(10);
            line.Draw();

            line.SetY(11);
            line.Draw();

            //////////////////

            line.SetX(23);
            line.SetY(7);
            line.Draw();


            line.SetY(8);
            line.Draw();

            line.SetY(9);
            line.Draw();

            line.SetY(10);
            line.Draw();

            line.SetY(11);
            line.Draw();

            ////////////////////////

            line.SetX(4);
            line.SetY(12);
            line.Draw();

            line.SetX(5);
            line.SetY(13);
            line.Draw();

            line.SetY(14);
            line.Draw();

            line.SetX(4);
            line.SetY(15);
            line.Draw();

            line.SetY(16);
            line.Draw();

            line.SetSym('-');
            line.SetX(5);
            line.SetY(17);
            line.Draw();

            line.SetX(6);
            line.SetY(17);
            line.Draw();

            line.SetX(7);
            line.SetY(16);
            line.Draw();

            line.SetX(8);
            line.SetY(16);
            line.Draw();

            line.SetSym('|');
            line.SetX(9);
            line.SetY(15);
            line.Draw();

            line.SetY(16);
            line.Draw();

            line.SetY(17);
            line.Draw();

            line.SetY(18);
            line.Draw();

            line.SetY(19);
            line.Draw();

            line.SetY(20);
            line.Draw();

            line.SetX(10);
            line.SetY(21);
            line.SetSym('-');
            line.Draw();

            line.SetX(12);
            line.Draw();

            line.SetX(14);
            line.Draw();

            line.SetX(16);
            line.Draw();

            line.SetSym('|');
            line.SetX(11);
            line.SetY(16);
            line.Draw();

            line.SetY(17);
            line.Draw();

            line.SetY(18);
            line.Draw();

            line.SetY(19);
            line.Draw();

            line.SetY(20);
            line.Draw();

            ////////

            line.SetX(13);
            line.SetY(16);
            line.Draw();

            line.SetY(17);
            line.Draw();

            line.SetY(18);
            line.Draw();

            line.SetY(19);
            line.Draw();

            line.SetY(20);
            line.Draw();

            /////

            line.SetX(15);
            line.SetY(16);
            line.Draw();

            line.SetY(17);
            line.Draw();

            line.SetY(18);
            line.Draw();

            line.SetY(19);
            line.Draw();

            line.SetY(20);
            line.Draw();

            //////
            line.SetX(17);
            line.SetY(15);
            line.Draw();

            line.SetX(17);
            line.SetY(16);
            line.Draw();

            line.SetY(17);
            line.Draw();

            line.SetY(18);
            line.Draw();

            line.SetY(19);
            line.Draw();

            line.SetY(20);
            line.Draw();

            ////////////

            line.SetSym('-');
            line.SetY(16);
            line.SetX(18);
            line.Draw();

            line.SetX(19);
            line.Draw();

            line.SetY(17);
            line.SetX(20);
            line.Draw();

            line.SetX(21);
            line.Draw();

            //////////
            
            line.SetSym('|');
            line.SetX(22);
            line.SetY(16);
            line.Draw();

            line.SetY(15);
            line.Draw();

            line.SetX(21);
            line.SetY(14);
            line.Draw();

            line.SetY(13);
            line.Draw();

            line.SetX(22);
            line.SetY(12);
            line.Draw();


            ///////////

            line.SetSym('*');
            line.SetX(6);
            line.SetY(10);
            line.Draw();

            line.SetY(9);
            line.Draw();

            line.SetY(11);
            line.Draw();

            line.SetX(7);
            line.SetY(10);
            line.Draw();

            line.SetY(9);
            line.Draw();

            line.SetY(11);
            line.Draw();

            line.SetX(8);
            line.SetY(10);
            line.Draw();

            line.SetY(9);
            line.Draw();

            line.SetY(11);
            line.Draw();

            line.SetX(7);
            line.SetY(12);
            line.Draw();

            line.SetX(8);
            line.Draw();

            line.SetX(9);
            line.Draw();

            line.SetX(10);
            line.Draw();

            line.SetX(11);
            line.Draw();

            line.SetX(12);
            line.Draw();

            line.SetX(9);
            line.SetY(11);
            line.Draw();

            line.SetX(10);
            line.SetY(11);
            line.Draw();

            line.SetX(13);
            line.SetY(13);
            line.Draw();

            line.SetX(12);
            line.SetY(14);
            line.Draw();

            line.SetX(14);
            line.SetY(14);
            line.Draw();

            line.SetY(14);
            line.Draw();

            line.SetX(14);
            line.SetY(12);
            line.Draw();

            line.SetX(15);
            line.Draw();

            line.SetX(16);
            line.Draw();

            line.SetX(17);
            line.Draw();

            line.SetX(18);
            line.Draw();

            line.SetX(19);
            line.Draw();

            //////////

            line.SetY(11);
            line.Draw();

            line.SetX(16);
            line.Draw();

            line.SetX(17);
            line.Draw();

            line.SetX(18);
            line.Draw();

            line.SetX(19);
            line.Draw();

            line.SetX(20);
            line.Draw();

            line.SetY(10);
            line.SetX(18);
            line.Draw();

            line.SetX(19);
            line.Draw();

            line.SetX(20);
            line.Draw();

            line.SetY(9);
            line.SetX(18);
            line.Draw();

            line.SetX(19);
            line.Draw();

            line.SetX(20);
            line.Draw();
            Console.ReadKey();

        }
    }
}
