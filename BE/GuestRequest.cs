using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class GuestRequest // public?
    {
        // הרשאות גישה
        int GuestRequestKey;
        string PrivateName;
        string FamilyName;
        string MailAddress;
        string Status;
        DateTime RegistrationDate;
        DateTime EntryDate;
        DateTime ReleaseDate;
        string Area;
        string Type;
        int Adults;
        int Children;
        string Pool;
        string Jacuzzi;
        string ChildrenAttractions;
        string privateSite;
        string Cashroot;
        string Shul;
        int Cribs;
        // pool cosher
        int MaxPrice;
        public override string ToString()
        {
            return "";
        }
    }
}
