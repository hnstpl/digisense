using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.Models.GeoLocation;
using AdminPortal.Mvc.DataProvider;
using AdminPortal.Mvc.Models.Dealer;
using System.Reflection.Metadata.Ecma335;

namespace AdminPortal.Mvc.GlobalProvider
{
    public static class Global
    {


        //serialize dealer type
        public static List<Dealer> FormatDealerType(List<Dealer> DealerList)
        {
            DealerList.ForEach(
            x =>
            {
                x.MdealerType_vc = x.MdealerType_vc.ToLower().Replace(",yes,", ", Service, ");
                x.MdealerType_vc = x.MdealerType_vc.ToLower().Replace("yes,", "Sales,");
                x.MdealerType_vc = x.MdealerType_vc.ToLower().Replace("yes,,", "Sales,");
                x.MdealerType_vc = x.MdealerType_vc.ToLower().Replace(", yes", ", Spares");
                x.MdealerType_vc = x.MdealerType_vc.ToLower().Replace(",,yes", ", Spares");
                x.MdealerType_vc = x.MdealerType_vc.ToLower().Replace(",,", "");

                if (x.MdealerType_vc.Substring(0, 1) == ",")
                {
                    x.MdealerType_vc = x.MdealerType_vc.Remove(0, 2);
                }
                if (x.MdealerType_vc.Substring(x.MdealerType_vc.Length - 1) == ",")
                {
                    x.MdealerType_vc = x.MdealerType_vc.Remove(x.MdealerType_vc.Length, 1);
                }
                if (x.MdealerType_vc.Substring(x.MdealerType_vc.Length - 2) == ", ")
                {
                    x.MdealerType_vc = x.MdealerType_vc.Remove(x.MdealerType_vc.Length - 2);
                }
            });

            return DealerList;
        }

    }
}
