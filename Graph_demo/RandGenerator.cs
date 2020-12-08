using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_demo
{
    static class RandGenerator
    {
        static private Random rand = new Random();
        static public string GenerateWord()
        {
            int len = rand.Next(3, 7);
            StringBuilder s = new StringBuilder();
            for (int i =0; i< len; i++)
            {
                char letter = (char)rand.Next(65, 91);
                int choice = rand.Next(0, 2);
                if (choice == 0)
                    s.Append(letter.ToString().ToUpper());
                else
                    s.Append(letter.ToString().ToLower());
            }

            return s.ToString();
        }

        static public KeyValuePair<int,int> GeneratePoint(int field_x, int field_y, int width, int height)
        {
            int x = rand.Next(field_x, field_x + width);
            int y = rand.Next(field_y, field_y + height);

            return new KeyValuePair<int, int>(x, y);
        }
    }
}
