using System;
using System.Threading.Tasks;
using Realms.Sync;

namespace testVR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Success(user);       
            try
            {
                Login().Wait();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"There was an exception: {ex.ToString()}");
            }
        }


        async static Task Login()
        {
            Console.Write("logging in");
            var credentials = Credentials.UsernamePassword("customer-one", "customer-one", createUser: false);
            var authURL = new Uri("https://htx-dev-sandbox.us1a.cloud.realm.io");
            var user = await User.LoginAsync(credentials, authURL);
            Console.Write(user);
        }
    }

}
