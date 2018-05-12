using System;
using System.Threading;

namespace Clock
{
    class Numbers
    {
        int y = 0, symbolX = 13, symbolY = 12;
        char fill = '#';

        public void Zero(int position)
        {
            y = 0;
            Console.SetCursorPosition(position, y);
            //Line
            for (int i = 0; i < symbolX; i++)
            {
                Console.Write(fill);
            }                       
            y++;

            //Columns
            while ((symbolY - 2) > y)
            {
                Console.SetCursorPosition(position, y);
                Console.Write(fill);
                Console.SetCursorPosition((position + 12), y);
                Console.Write(fill);
                y++;
            }

            Console.SetCursorPosition(position, y);
            //Line
            for (int i = 0; i <= (symbolX - 1); i++)
            {
                Console.Write(fill);
            }

        }//End of Zero
        public void One(int position)
        {
            y = 0;
            //Column
            while ((symbolY - 1) > y)
            {
                Console.SetCursorPosition((position + 12), y);
                Console.Write(fill);
                y++;
            }

        }//End of One
        public void Two(int position)
        {
            y = 0;
            Console.SetCursorPosition(position, y);
            //Line
            for (int i = 0; i < symbolX; i++)
            {
                Console.Write(fill);
            }
            y++;

            //Column
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition((position + 12), y);
                Console.Write(fill);
                y++;
            }

            //Line
            Console.SetCursorPosition(position, y);
            for (int i = 0; i < symbolX; i++)
            {
                Console.Write(fill);
            }

            //Column
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition((position), y);
                Console.Write(fill);
                y++;
            }

            //Line
            Console.SetCursorPosition(position, y);
            for (int i = 0; i < symbolX; i++)
            {
                Console.Write(fill);
            }

        }//End of Two
        public void Three(int position)
        {
            y = 0;
            Console.SetCursorPosition(position, y);
            //Line
            for (int i = 0; i < symbolX; i++)
            {
                Console.Write(fill);
            }
            y++;

            //Column
            Console.SetCursorPosition((position + 12), y);
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition((position + 12), y);
                Console.Write(fill);
                y++;
            }

            //Line
            Console.SetCursorPosition(position, y);
            for (int i = 0; i < symbolX; i++)
            {
                Console.Write(fill);
            }
            y++;

            //Column
            Console.SetCursorPosition((position + 12), y);
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition((position + 12), y);
                Console.Write(fill);
                y++;
            }

            //Line
            Console.SetCursorPosition(position, y);
            for (int i = 0; i < symbolX; i++)
            {
                Console.Write(fill);
            }

        }//End of Three
        public void Four(int position)
        {
            y = 0;
            //Column
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(position, y);
                Console.Write(fill);
                Console.SetCursorPosition((position + 12), y);
                Console.Write(fill);
                y++;
            }

            //Line
            Console.SetCursorPosition(position, y);
            for (int i = 0; i < symbolX; i++)
            {
                Console.Write(fill);
            }
            y++;

            //Column
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition((position + 12), y);
                Console.Write(fill);
                y++;
            }

        }//End of Four
        public void Five(int position)
        {
            y = 0;
            //Line
            Console.SetCursorPosition(position, y);
            for (int i = 0; i < symbolX; i++)
            {
                Console.Write(fill);
            }
            y++;

            //Column            
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(position, y);
                Console.Write(fill);
                y++;
            }

            //Line
            Console.SetCursorPosition(position, y);
            for (int i = 0; i < symbolX; i++)
            {
                Console.Write(fill);
            }
            y++;

            //Column            
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition((position + 12), y);
                Console.Write(fill);
                y++;
            }

            //Line
            Console.SetCursorPosition(position, y);
            for (int i = 0; i < symbolX; i++)
            {
                Console.Write(fill);
            }

        }//End of Five
        public void Six(int position)
        {
            y = 0;
            Console.SetCursorPosition(position, y);
            //Line
            for (int i = 0; i < symbolX; i++)
            {
                Console.Write(fill);
            }
            y++;

            //Column
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(position, y);
                Console.Write(fill);
                y++;
            }

            //Line
            Console.SetCursorPosition(position, y);
            for (int i = 0; i < symbolX; i++)
            {
                Console.Write(fill);
            }
            y++;

            //Columns
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(position, y);
                Console.Write(fill);
                Console.SetCursorPosition((position + 12), y);
                Console.Write(fill);
                y++;
            }

            //Line
            Console.SetCursorPosition(position, y);
            for (int i = 0; i < symbolX; i++)
            {
                Console.Write(fill);
            }

        }//End of Six
        public void Seven(int position)
        {
            y = 0;
            //Line
            Console.SetCursorPosition(position, y);
            for (int i = 0; i < symbolX; i++)
            {
                Console.Write(fill);
            }
            y++;

            //Column
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition((position + 12), y);
                Console.Write(fill);
                y++;
            }

        }//End of Seven
        public void Eight(int position)
        {
            y = 0;
            //Line
            Console.SetCursorPosition(position, y);
            for (int i = 0; i < symbolX; i++)
            {
                Console.Write(fill);
            }
            y++;

            //Columns
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(position, y);
                Console.Write(fill);
                Console.SetCursorPosition((position + 12), y);
                Console.Write(fill);
                y++;
            }

            //Line
            Console.SetCursorPosition(position, y);
            for (int i = 0; i < symbolX; i++)
            {
                Console.Write(fill);
            }
            y++;

            
            //Columns
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(position, y);
                Console.Write(fill);
                Console.SetCursorPosition((position + 12), y);
                Console.Write(fill);
                y++;
            }

            //Line
            Console.SetCursorPosition(position, y);
            for (int i = 0; i < symbolX; i++)
            {
                Console.Write(fill);
            }

        }//End of Eight
        public void Nine(int position)
        {
            y = 0;
            //Line
            Console.SetCursorPosition(position, y);
            for (int i = 0; i < symbolX; i++)
            {
                Console.Write(fill);
            }
            y++;

            //Columns
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(position, y);
                Console.Write(fill);
                Console.SetCursorPosition((position + 12), y);
                Console.Write(fill);
                y++;
            }

            //Line
            Console.SetCursorPosition(position, y);
            for (int i = 0; i < symbolX; i++)
            {
                Console.Write(fill);
            }
            y++;

            //Column
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition((position + 12), y);
                Console.Write(fill);
                y++;
            }

        }//End of Nine

        public void Colon(int position)
        {
            //Block
            Console.SetCursorPosition((position - 6), 4);
            for (int i = 0; i < 3; i++)
            {
                Console.Write(fill);
            }
            Console.SetCursorPosition((position - 6), 5);
            for (int i = 0; i < 3; i++)
            {
                Console.Write(fill);
            }
        }//End of Colon

        public int NumberPosition(int position)
        {
            switch (position)
            {
                case 1: return 0;
                case 2: return 15;
                case 3: return 37;
                case 4: return 52;
                case 5: return 74;
                case 6: return 89;

            }
            return 0;
        }//End of NumberPosition

        public void NumberConverter(char number, int position)
        {
            switch (number)
            {
                case '0': Zero(NumberPosition(position)); break;
                case '1': One(NumberPosition(position)); break;
                case '2': Two(NumberPosition(position)); break;
                case '3': Three(NumberPosition(position)); break;
                case '4': Four(NumberPosition(position)); break;
                case '5': Five(NumberPosition(position)); break;
                case '6': Six(NumberPosition(position)); break;
                case '7': Seven(NumberPosition(position)); break;
                case '8': Eight(NumberPosition(position)); break;
                case '9': Nine(NumberPosition(position)); break;
            }
        }// End of NumberConverter
    }//End of Numbers

    class Program
    {
        static void Main(string[] args)
        {
            Numbers numbs = new Numbers();

            const int ConsoleX   = 102, ConsoleY = 12;
            Console.WindowWidth  = ConsoleX;
            Console.WindowHeight = ConsoleY;          

            while (true)
            {
                string currentTime = DateTime.Now.ToString("HH:mm:ss");
                string hour = currentTime.Substring(0, 2);
                string minute = currentTime.Substring(3, 2);
                string second = currentTime.Substring(6, 2);

                numbs.NumberConverter(hour[0], 1);
                numbs.NumberConverter(hour[1], 2);

                numbs.Colon(numbs.NumberPosition(3));

                numbs.NumberConverter(minute[0], 3);
                numbs.NumberConverter(minute[1], 4);

                numbs.Colon(numbs.NumberPosition(5));

                numbs.NumberConverter(second[0], 5);
                numbs.NumberConverter(second[1], 6);

                Thread.Sleep(500);
                Console.Clear();
            }            
        }
    }//End of Program
}//End of namespace