using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Dal_imp : Idal
    {
        // public function?
        void addRequest(BE.GuestRequest g)
        {
            BE.GuestRequest e=(DS.G).FirstOrDefault(m => g.GuestRequestKey == m.GuestRequestKey);
            if(e!=null)
            {
                throw new Exception("הבקשה כבר קיימת במערכת");
            }
            DS.G.Add(e.Clone()); // clone???
        }
        void updateRequest(int requestKey, string myStatus);
        void addUnit(BE.HostingUnit u);
        void eraseUnit(int unitKey);
        void updateUnit(BE.HostingUnit u);
        void addOrder(BE.Order o);
        void updateOrder(int orderKey);
        IEnumerable<BE.HostingUnit> getUnits();
        IEnumerable<BE.GuestRequest> getRequests();
        IEnumerable<BE.Order> getOrders();
        IEnumerable<BE.BankBranch> getBranches();
    }
}
