using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Account_Management
{
    public class Model_class
    {
        public List<Stock1TCS> stock1TCS;
        public List<Stock2HDFC> stock2HDFC;
        public List<Stock3Infosys> stock3Infosys;

    }

    public class Stock1TCS
    {

         public string sharename;
         public int Numberofshare;
         public int Priceofshare;
    }
    public class Stock2HDFC
    {
        public string sharename;
        public int Numberofshare;
        public int Priceofshare;

    }
    public class Stock3Infosys
    {
        public string sharename;
        public int Numberofshare;
        public int Priceofshare;

    }



}
