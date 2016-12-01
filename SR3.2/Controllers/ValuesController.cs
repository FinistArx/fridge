using SR3._2.Models.Contex;
using SR3._2.Models.Device;
using SR3._2.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;


namespace SR3._2.Controllers
{
    public class ValuesController : ApiController
    {
        private SmartHomeContex bb = new SmartHomeContex();
        private TemperatureContex tc = new TemperatureContex();
        private VolumeContex vc = new VolumeContex();
        private ChennelContex cc = new ChennelContex();
        public IEnumerable<AbstractDevice> GetIndex()
        {
            IList<AbstractDevice> list = new List<AbstractDevice>();

            foreach (AbstractDevice item in bb.Devices.ToList())
            {
                list.Add(item);
            }
            return bb.Devices;      
         
        }
    
       
        public void Delete(int id)
        {
            AbstractDevice b = bb.Devices.Find(id);
            if (b != null)
            {
                bb.Devices.Remove(b);
                bb.SaveChanges();
            }
        }

        [HttpPut]
        public void PutOpenClose(int id)
        {
            Fridge opcl = bb.Fredges.Find(id);
            if (opcl != null)
            {
                opcl.OpCl();
                bb.SaveChanges();
            }
        }

        [HttpPut]
        public void PutIncrtemp (int id)
        {
            Temperature newtemp = tc.Tempes.Find(id);
            if (newtemp != null)
            {
                switch (id)
                {
                    case 1:
                        newtemp.IncreaseTemp();
                        break;
                    case 2:
                        newtemp.IncreaseTemp();
                        break;
                    default:
                        newtemp.IncreaseTemp();
                        break;
                }
                bb.SaveChanges();
            }
        }

        [HttpPut]
        public void PutDecrtemp(int id)
        {
            Temperature newtemp = tc.Tempes.Find(id);
            if (newtemp != null)
            {
                switch (id)
                {
                    case 1:
                        newtemp.DecreaseTemp();
                        break;
                    case 2:
                        newtemp.DecreaseTemp();
                        break;
                    default:
                        newtemp.DecreaseTemp();
                        break;
                }
                bb.SaveChanges();
            }
        }

        [HttpPut]
        public void PutVolumeIncr(int id)
        {
            if (id == 4)
            {
                IVolume newvol = bb.MCs.Find(id);
                newvol.IncreaseVolume();
            }
            if (id == 5)
            {
                IVolume newvol2 = bb.TVs.Find(id);
                newvol2.IncreaseVolume();
            }
            bb.SaveChanges();
        }

        public void EditVolumeDecr(int id)
        {
            if (id == 4)
            {
                IVolume newvol = bb.MCs.Find(id);
                newvol.DecreaseVolume();
            }
            if (id == 5)
            {
                IVolume newvol2 = bb.TVs.Find(id);
                newvol2.DecreaseVolume();
            }
            bb.SaveChanges();
        }



        //public ActionResult NextChenell(int id)
        //{
        //    if (id == 4)
        //    {
        //        IChangeChennel newvol = bb.MCs.Find(id);
        //        newvol.NextChennel();
        //    }
        //    if (id == 5)
        //    {
        //        IChangeChennel newvol2 = bb.TVs.Find(id);
        //        newvol2.NextChennel();
        //    }
        //    bb.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //public ActionResult PrevChenell(int id)
        //{
        //    if (id == 4)
        //    {
        //        IChangeChennel newvol = bb.MCs.Find(id);
        //        newvol.PreviusChennel();
        //    }
        //    if (id == 5)
        //    {
        //        IChangeChennel newvol2 = bb.TVs.Find(id);
        //        newvol2.PreviusChennel();
        //    }
        //    bb.SaveChanges();
        //    return "Index";
        //}
    }
}
