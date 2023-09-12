using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Threading;



namespace console_Tetris
{
    class Tite
    {
        public void t()
        {
            Console.WriteLine("                                                                                                             ");
            Console.WriteLine("                                                                                                             ");
            Console.WriteLine("  TTTTTTTTTTTTTTTTTTTTTTT                         tttt                              iiii                     ");
            Console.WriteLine("  T:::::::::::::::::::::T                      ttt:::t                             i::::i                    ");
            Console.WriteLine("  T:::::::::::::::::::::T                      t:::::t                              iiii                     ");
            Console.WriteLine("  T:::::TT:::::::TT:::::T                      t:::::t                                                       ");
            Console.WriteLine("  TTTTTT  T:::::T  TTTTTTeeeeeeeeeeee    ttttttt:::::ttttttt   rrrrr   rrrrrrrrr  iiiiiii     ssssssssss     ");
            Console.WriteLine("          T:::::T      ee::::::::::::ee  t:::::::::::::::::t   r::::rrr:::::::::r i:::::i   ss::::::::::s    ");
            Console.WriteLine("          T:::::T     e::::::eeeee:::::eet:::::::::::::::::t   r:::::::::::::::::r i::::i ss:::::::::::::s   ");
            Console.WriteLine("          T:::::T    e::::::e     e:::::etttttt:::::::tttttt   rr::::::rrrrr::::::ri::::i s::::::ssss:::::s  ");
            Console.WriteLine("          T:::::T    e:::::::eeeee::::::e      t:::::t          r:::::r     r:::::ri::::i  s:::::s  ssssss   ");
            Console.WriteLine("          T:::::T    e:::::::::::::::::e       t:::::t          r:::::r     rrrrrrri::::i    s::::::s        ");
            Console.WriteLine("          T:::::T    e::::::eeeeeeeeeee        t:::::t          r:::::r            i::::i       s::::::s     ");
            Console.WriteLine("          T:::::T    e:::::::e                 t:::::t    ttttttr:::::r            i::::i ssssss   s:::::s   ");
            Console.WriteLine("        TT:::::::TT  e::::::::e                t::::::tttt:::::tr:::::r           i::::::is:::::ssss::::::s  ");
            Console.WriteLine("        T:::::::::T   e::::::::eeeeeeee        tt::::::::::::::tr:::::r           i::::::is::::::::::::::s   ");
            Console.WriteLine("        T:::::::::T    ee:::::::::::::e          tt:::::::::::ttr:::::r           i::::::i s:::::::::::ss    ");
            Console.WriteLine("        TTTTTTTTTTT      eeeeeeeeeeeeee            ttttttttttt  rrrrrrr           iiiiiiii  sssssssssss      ");
            Console.WriteLine("                                                                                                             ");
            Console.WriteLine("                                                                                                             ");
            Console.WriteLine("                                                                                                             ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            TETRISSCREEN NewSC = new TETRISSCREEN(10, 15, true);
            ACCSCREEN NewASC = new ACCSCREEN(NewSC);
            Block NewBlock = new Block(NewSC, NewASC);
            
            while (true)
            {
                Thread.Sleep(100);
                Console.Clear();
                
                NewSC.Render();
                NewSC.Clear();
                NewASC.Render();
                NewASC.DestroyCheck();
                NewBlock.Move();

            }

        }
    }
}
