using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawTree
{
    internal class draw
    {
        public int stammhohe { set; get; }
        public int stammbreite { set; get; }
        public int kronenhohe { set; get; }

        public string krone(int stammhohe, int stammbreite, int kronenhohe)
        {
            string resualt = "";
            for (int j = 0; j < stammbreite; j++)
            {

                for (int i = 0; i < stammbreite; i++)
                {
                    if (i - j != 0)
                    {
                        resualt += "*";
                    }
                    else
                    {
                        resualt += " ";
                    }
                    
                }
                resualt += Environment.NewLine;
            }
            return resualt;
        }
    }
}
/*if (int.TryParse(input, out int length) == true)
            {
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        if (i - j != 0)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine("\t");
                }
}*/