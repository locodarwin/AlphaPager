using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AW;

namespace AlphaPager
{
    public partial class Form1
    {

        // Method to get & return citizen number
        private int GetCitnum(string sName)
        {
            _instance.CitizenAttributesByName(sName);
            return _instance.Attributes.CitizenNumber;
        }


        private Coords ConvertCoords(string sCoords)
        {
            Coords cTemp;
            string ns, ew, alt, yaw, q, b;
            int x, y, z, iyaw;

            // Lowercase the input string
            sCoords = sCoords.ToLower();

            // Handle north or south in the string
            if (sCoords.Contains("n") || sCoords.Contains("s"))
            {
                q = sCoords.IndexOf("n");
                if (q > 0)
                {
                    ns = sCoords.Substring(q);
                    z = ExtractSingleCoord(ns);
                }
                else
                {
                    ns = sCoords.Substring("s");
                    z = ExtractSingleCoord(ns);
                    z = z * -1;
                }

            }
            else
            {
                z = 0;
            }

            // Handle eat/west in the string
            if (sCoords.Contains("e") || sCoords.Contains("w"))
            {
                q = sCoords.IndexOf("w");
                if (q > 0)
                {
                    ew = sCoords.Substring(q);
                    x = ExtractSingleCoord(ew);
                }
                else
                {
                    ew = sCoords.Substring("e");
                    x = ExtractSingleCoord(ew);
                    x = x * -1;
                }

            }
            else
            {
                x = 0;
            }

            // Handle altitude
            if (sCoords.Contains("a"))
            {
                q = sCoords.IndexOf("a");
                if (q > 0)
                {
                    alt = sCoords.Substring(q);
                    y = ExtractSingleCoord(alt);
                    y = y / 10;
                }
            }
            else
            {
                y = 0;
            }

            // Handle yaw
            q = sCoords.Length();
            for (j = q; j = 0; j--)
            {
                // string temp = s.Substring(a - 1, b); 
                b = sCoords.Substring(j, 1);
                if (Char.IsDigit(b))
                {
                    yaw = yaw + b;
                }
                else
                {
                    break;
                }

            }
            char[] input = yaw.ToCharArray();
            Array.Reverse(input);
            yaw = new string(input);
            iyaw = Convert.ToInt32(yaw);
            iyaw = iyaw * 10;
            if (iyaw < 0)
            {
                iyaw = 0;
            }
            if (iyaw > 3599)
            {
                iyaw = 0;
            }
            cTemp.x = x;
            cTemp.y = y;
            cTemp.z = z;
            cTemp.yaw = iyaw;

        }

        private int ExtractSingleCoord(string sIn)
        {
            int b;
            for (j = sIn.Length(); j = 0; j--)
            {
                b = sIn.Substring(j, 1);

            }
        }





    }
}
