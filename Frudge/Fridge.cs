using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frudge
{
    class Fridge
    {
        public bool state;
        public bool stateopenclose;
        int temp;
        public Fridge(bool state, bool stateopenclose, int temp)
        {
            this.state = state;
            this.stateopenclose = stateopenclose;
            this.temp = temp;
        }


        public bool StateOpenClose
        {
            get
            {
                return stateopenclose;
            }
            set
            {
                stateopenclose = value;
            }
        }

        public void Open()
        {
            stateopenclose = true;
        }

        public void Close()
        {
            stateopenclose = false;
        }


        
        public void On()
        {
            state = true;
        }

        public void Off()
        {
            state = false;
        }


        int min = -20;
        int max = 10;
        public  int SetTemp()
        {
            Console.WriteLine("Введите температуру");
            string t = Console.ReadLine();
            int value = Convert.ToInt32(t);
            if (value <= max && value >= min)
            {
                 temp = value;
            }
            return temp;
        }

        public int DecreaseTemp()
        {
            if ( temp < max && temp > min)
            { temp--; }
            return temp; 
        }

        public int IncreaseTemp()
        {
            if (temp < max)
            { temp++; }
            return temp;
        }

        public override string ToString()
        {
            string state;
            if (this.state)
            {
                state = "включен";
            }
            else
            {
                state = "выключен";
            }


            string stateopenclose;
            if (this.stateopenclose)
            {
                stateopenclose = "открыта";
            }
            else
            {
                stateopenclose = "закрыта";
            }

            return "  Cостояние холодильника: " + state + ", температура:  " + temp + ", дверь " + stateopenclose;
        }

    
}
}

