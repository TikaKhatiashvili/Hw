namespace HwSeven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region პირველი
            Human hum1 =new Human("Tika", "Khatiashvili", 28, "12331321212", "577000000", "Tika.Khatiashvili@gmail.com");
            hum1.DisplayInfoInConsole();
            Human hum2 = new Human("Tika2", "Khatiashvili2", 25, "12331321262", "577050000", "Tika.Khatiashvili2@gmail.com");
            hum2.DisplayInfoInConsole();
            Human hum3 = new Human("Tika3", "Khatiashvili3", 26, "12331351212", "577000050", "Tika.Khatiashvili3@gmail.com");
            hum3.DisplayInfoInConsole();
            #endregion

            #region მეორე 

            var account1 = new Account("1234567890123456789012", "GEL", 1000);
            var account2 = new Account("9876543210987654321098", "GEL", 500);

            var client1 = new Client("Tika", "Khatiashvili", "12331321212", account1);
            var client2 = new Client("Tika2", "Khatiashvili2", "22331321212", account2);

            client1.DisplayInfo();
            client2.DisplayInfo();

            client1.Account.Deposit(200);

            client2.Account.Withdraw(100);

            client1.Account.Transfer(client2.Account, 300);

            client1.DisplayInfo();
            client2.DisplayInfo();

            #endregion
        }
    }
}
