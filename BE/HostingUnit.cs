using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class HostingUnit
    {
        int HostingUnitKey;
        Host Owner;
        string HostingUnitName;
        bool[,] Diary=new bool[12,31]; // array??
        bool IsPool;
        bool IsJacuzzi;
        bool IsChildrenAtrraction;
        string Area;
        int Rooms;
        bool IsShul;
        int Cribs;
        bool Cashroot;
        // privatSite?
        int pricePerDay;
        public override string ToString()
        {
            return "";
        }
    }
}
