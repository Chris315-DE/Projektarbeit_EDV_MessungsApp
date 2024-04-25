using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbeit_EDV_Messung_Lib.Models
{
    public class MessungsModel
    {
        [PrimaryKey, AutoIncrement]
        public int MessungsID { get; set; }

        public string GeräteNummer { get; set; }
        public float RPE { get; set; }
        public string RISO { get; set; } = "> 9";
        public float IEA { get; set; }

        public string Ergebniss { get; set; }






        /// <summary>
        /// Ermittelt ob das Gerät die Messung Bestanden hat anhand der Gesetzlichen Messwerte (RPE < 0.30 und IEA < 0.80) dazu wird die Benutzereingabe überprüft
        /// ob der Messwert als komma wert eingegeben wurde oder nicht 
        /// </summary>
        /// <returns></returns>
        public bool SetzeErgebniss()
        {
            if (RPE % 1 != 0)
            {
                if (RPE >= 0.30)
                {
                    return false;
                }
            }
            if (RPE >= 30)
            {
                return false;
            }
            if (IEA % 1 != 0)
            {
                if (IEA >= 0.50)
                {
                    return false;
                }
            }
            if (IEA >= 50)
            {
                return false;
            }
            return true;
        }
    }
}
