using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public enum zimmerType
    {
        צימר,מלון,חאן,דירת_אירוח
    }
    public enum Area
    {
        גולן,גליל,בקעה,שפלה,נגב,ירושלים,אילת
    }
    public enum orderStatus
    {
        טרם_טופל, נשלח_מייל, נסגר_מחוסר_הענות_לקוח, נסגר_בהענות_לקוח
    }
    public enum requestStatus
    {
        פתוחה,נסגרה_עסקה_באתר,פג_תוקף
    }

}
