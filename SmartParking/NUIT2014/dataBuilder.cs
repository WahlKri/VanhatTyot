using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUIT2014
{
    class dataBuilder
    {


        public string buildDataLicense(string data) {

            string placeHolder = data.ToUpper();
            string[] array = placeHolder.Trim().Split(':');
            return array[1].TrimStart(' ');
        }

        public string buildDataTime(string data) {

            string placeHolder = data.ToUpper();
            string[] array = placeHolder.Trim().Split(' ');
            return array[4] +":"+ array[5].TrimEnd(',');
        
        }


    }
}
