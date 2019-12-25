using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Host
    {
        int HostKey;
        string PrivateName;
        string FamilyName;
        int FhoneNumber;
        string MailAddress;
        BankBranch BankBranchDetails;
        int BankAccountNumber;
        bool CollectionClearance;

        public override string ToString()
        {
            return "";
        }
    }
}
