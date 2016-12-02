
using System.Runtime.Serialization;

namespace SR3._2.Models.Device
{
    [DataContract]
    public abstract class AbstractDevice
    {
        public int Id { get; set; }
        public bool state;
        public AbstractDevice() { }
        public void OnOff()
        {
            state = !state;
        }
        [DataMember]

        public bool State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }
    }

}