﻿using SR3._2.Models.Interfaces;
using System.Runtime.Serialization;

namespace SR3._2.Models.Device
{
    [DataContract]

    public class MC : AbstractDevice, IChangeChennel, IVolume
    {
        public MC() { } 
        public MC(bool state, int chennel, int volume)
        {
            this.volume = volume;
            this.chennel = chennel;
        }

        public int chennel;
        public int volume;
        [DataMember]

        public int Chennel
        {
            get { return chennel; }
            set { chennel = value; }
        }
        [DataMember]

        public int Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        public void NextChennel()
        {
            if (Chennel < 200)
            { Chennel++; }
        }

        public void PreviusChennel()
        {
            if (Chennel > 0)
            { Chennel--; }
        }

        public void DecreaseVolume()
        {
            if (Volume > 0)
            { Volume--; }
        }

        public void IncreaseVolume()
        {
            if (Volume < 100) { Volume++; }
        }

        public override string ToString()
        {
            return "Музыкальный центр - состояние: ";
        }
    }
}