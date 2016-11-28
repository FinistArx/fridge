using SR3._2.Models.Device;
using SR3._2.Models.Interfaces;
using System.Collections.Generic;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.SessionState;

namespace SR3._2.Controllers
{
    public class ValuesController : ApiController
    {
        public IDictionary<int, AbstractDevice> Get()
        {
            IDictionary<int, AbstractDevice> SmartHome;
            var Session = SessionStateUtility.GetHttpSessionStateFromContext(HttpContext.Current);


            if (Session["Device"] == null)
            {
                SmartHome = new SortedDictionary<int, AbstractDevice>();
                SmartHome.Add(1, new TV(false, 100, 50));
                SmartHome.Add(2, new MC(false, 100, 50));
                SmartHome.Add(3, new Boiler(false, 15));
                SmartHome.Add(4, new Conditioner(false, 18));
                SmartHome.Add(5, new Fridge(false, 0, false));
                Session["Device"] = SmartHome;
                Session["NextId"] = 6;
            }
            else
            {
                SmartHome = (SortedDictionary<int, AbstractDevice>)Session["Device"];
            }

            SelectListItem[] devicemenu = new SelectListItem[5];
            devicemenu[0] = new SelectListItem { Text = "Телик", Value = "tvset" };
            devicemenu[1] = new SelectListItem { Text = "Контробасс", Value = "musik" };
            devicemenu[2] = new SelectListItem { Text = "Грелко", Value = "boiler" };
            devicemenu[3] = new SelectListItem { Text = "Студилко", Value = "cond" };
            devicemenu[4] = new SelectListItem { Text = "Едасхрон", Value = "fridge" };



            return SmartHome;
        }
        public void PutIncrtemp(int id)
        {
            var Session = SessionStateUtility.GetHttpSessionStateFromContext(HttpContext.Current);
            IDictionary<int, AbstractDevice> SmartHome = (SortedDictionary<int, AbstractDevice>)Session["Device"];
            ((IRegulatorTemp)SmartHome[id]).IncreaseTemp();

        }
        public void PutDecrtemp(int id)
        {
            var Session = SessionStateUtility.GetHttpSessionStateFromContext(HttpContext.Current);
            IDictionary<int, AbstractDevice> SmartHome = (SortedDictionary<int, AbstractDevice>)Session["Device"];
            ((IRegulatorTemp)SmartHome[id]).IncreaseTemp();
        }
        public void Delete(int id)
        {
            var Session = HttpContext.Current.Session;
            IDictionary<int, AbstractDevice> SmartHome = (SortedDictionary<int, AbstractDevice>)Session["Device"];
            SmartHome.Remove(id);
        }
    }
}
