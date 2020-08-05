using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBHLufthavn
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new testEntities())
            {
                airport kbh = new airport { iata_code = "KBH", name = "Copenhagen airport" };
                airport la = new airport { iata_code = "LAX", name = "Los Angeles airport" };
                airline airline = new airline { name = "SAS" };
                airline airline2 = new airline { name = "ASA" };
                air_route route = new air_route { airline = airline, airline1 = airline2, airport = new List<airport> { la, kbh } };
                ctx.air_route.Add(route);
                ctx.SaveChanges();
            }
        }
    }
}
