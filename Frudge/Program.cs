using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frudge
{
    class Program
    {
        static void Main(string[] args)
        {

            Fridge freeze = new Fridge(false, true, 0);
            while (true)
            {
                Console.Clear();
                Console.WriteLine(freeze.ToString() + "\n");
                Console.WriteLine("Нажмите клавишу для выполнения действия:");
                Console.WriteLine("1 - Включить холодильник");
                Console.WriteLine("2 - Выключить холодильник");
                Console.WriteLine("3 - Открыть холодильник");
                Console.WriteLine("4 - Закрыть холодильник");
                Console.WriteLine("5 - Изменить температуру холодильника");
                Console.WriteLine("6 - Убавить температуру холодильника на 1");
                Console.WriteLine("7 - Добавить температуру холодильника на 1");
                Console.WriteLine("e - Выйти");

                char key = Console.ReadKey().KeyChar;

                switch (key)
                {
                    case '1':
                        freeze.On();
                        break;
                    case '2':
                        freeze.Off();
                        break;
                    case '3':
                        freeze.Open();
                        break;
                    case '4':
                        freeze.Close();
                        break;
                    case '5':
                        freeze.SetTemp();
                        break;
                    case '6':
                        freeze.DecreaseTemp();
                        break;
                    case '7':
                        freeze.IncreaseTemp();
                        break;
                        
                    case 'e':
                        return;

                }
            }
        }
    }
}
    
