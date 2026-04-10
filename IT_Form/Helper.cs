using System;
using System.Collections.Generic;
using System.Text;

namespace IT_Form
{
    public static class Helper
    {
        public static bool tcknKontrol(string tckn)
        {
            double tcknInt = double.Parse(tckn);
            int oddNum = 0;
            int evenNum = 0;
            if (tcknInt < 0) { return false; }
            else if (tcknInt > 99999999999) { return false; }
            else if (tckn.Length != 11) { return false; }
            if (tckn[0] == '0') { return false; }
            for (int i = 0; i < tckn.Length - 2; i++)
            {
                if (i % 2 == 0)
                {
                    oddNum += int.Parse(tckn[i].ToString());
                }
                else
                {
                    evenNum += int.Parse(tckn[i].ToString());
                }
            }

            if (((oddNum * 7) - evenNum) % 10 != int.Parse(tckn[9].ToString())) { return false; }

            if ((((oddNum + evenNum) + int.Parse(tckn[9].ToString())) % 10 != int.Parse(tckn[10].ToString()))) { return false; }
            return true;
        }

    }
}
