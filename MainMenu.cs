using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniverseIsALie
{
    class MainMenu
    {
        public static string selection;
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Witaj w grze WSZECHŚWIAT NIE JEST PRAWDZIWY 5868\n===========================================\n1:      Nowa gra\n2:      Wczytaj prolog\n3:      Opis postaci\n4:      Wyjdź z gry");
            selection = Console.ReadLine();

            if (selection == "1")
            {
                //NewGame();
            }
            else if(selection == "2")
                
            {
                //ReadPrologue();
            }
            else if(selection == "3")
            {
                //CharDescription();
            }
            else if(selection == "4")
            {
                QuitGame();
            }
        }

        public static void QuitGame()
        {
            Console.Clear();
            Console.WriteLine("Czy na pewno chcesz wyjść?\n===========================================\n1      Tak\n2      :Nie");
            selection = Console.ReadLine();

            if (selection == "1")
            {
                Environment.Exit(0);
            }

            else if (selection == "2");
            {
                Menu();
            }
        }
    }
}
