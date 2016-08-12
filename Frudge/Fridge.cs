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
        private readonly int min;
        private readonly int max;
        private int current;
        public Fridge(bool state, bool stateopenclose, int min, int max, int current)
        {
            this.state = state;
            this.stateopenclose = stateopenclose;
            this.current = current;
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

        public int Min
        {
            get
            {
                return min;
            }
        }

        public int Max
        {
            get
            {
                return max;
            }
        }

        public int Current
        {
            get
            {
                return current;
            }
            set
            {
                 
                if (value <= max && value >= min)
                {
                    current = value;
                }
            }
        }

        public void Increase()
        {
            Current++;
        }

        public void Decrease()
        {
            Current--;
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

            return "  Cостояние холодильника: " + state + ", температура:  " + Current + ", дверь " + stateopenclose;
        }
    }
    
}