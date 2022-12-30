namespace Stock_Account_Management
{
    public class Program
    {
        public static void Main(String[] args)
        {
            string path = "D:\\BridgeLabz\\CSharp\\Stock_Account_Management\\Stock.json";
            FatchStockAccount obj=new FatchStockAccount();

            Model_class mclass =obj.Read(path);
            Console.WriteLine("Stock1TCS");
            for(int i=0;i<mclass.stock1TCS.Count;i++)
            {
                Console.WriteLine("Share Name: "+mclass.stock1TCS[i].sharename);
                Console.WriteLine("Number of Shares: " + mclass.stock1TCS[i].Numberofshare);
                Console.WriteLine("Price of Shares: " + mclass.stock1TCS[i].Priceofshare);
                Console.WriteLine("\n");
            }
            Console.WriteLine("Stock2HDFC");
            for (int i = 0; i < mclass.stock2HDFC.Count; i++)
            {
                Console.WriteLine("Share Name: " + mclass.stock2HDFC[i].sharename);
                Console.WriteLine("Number of Shares: " + mclass.stock2HDFC[i].Numberofshare);
                Console.WriteLine("Price of Shares: " + mclass.stock2HDFC[i].Priceofshare);
                Console.WriteLine("\n");
            }
            Console.WriteLine("Stock3Infosys");
            for (int i = 0; i < mclass.stock3Infosys.Count; i++)
            {
                Console.WriteLine("Share Name: " + mclass.stock3Infosys[i].sharename);
                Console.WriteLine("Number of Shares: " + mclass.stock3Infosys[i].Numberofshare);
                Console.WriteLine("Price of Shares: " + mclass.stock3Infosys[i].Priceofshare);
                Console.WriteLine("\n");
            }

            


        }



        
    }
}