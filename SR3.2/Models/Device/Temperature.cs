using SR3._2.Models.Interfaces;
using System.Runtime.Serialization;

namespace SR3._2.Models.Device
{
    [DataContract]

    public abstract class Temperature : AbstractDevice, IRegulatorTemp
    {
        public int max;
        public int min;
        public int temp;
        public Temperature() { }
        public Temperature( int Temp )
        {         }

        [DataMember]
        public int Temp
        { get; set; }
        public void DecreaseTemp()
        {
            Temp--;
        }

        public void IncreaseTemp()
        {
            Temp++;
        }
 
    }
}