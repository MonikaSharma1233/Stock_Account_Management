using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Stock_Account_Management
{
    public class FatchStockAccount
    {
        
        public Model_class Read(string path)
        {


            using (StreamReader file = new StreamReader(path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Model_class>(json);
                }

                catch (Exception e)
                {
                    return null;
                }
            }
        }
        


    }
}
