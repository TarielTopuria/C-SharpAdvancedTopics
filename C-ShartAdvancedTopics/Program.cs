using C_ShartAdvancedTopics.Delegates;

namespace C_ShartAdvancedTopics.Generics
{
    public class Program
    {
        static void Main()
        {
            //Console.WriteLine($"Min number from these two is: {NumbersComparator.MaxNumber(10.11, 15)}");
            //NotificationDelegate notification = Delegates.Delegates.AddInConsole;
            //notification += Delegates.Delegates.AddInFile; 
            //notification += delegate (string text) { Console.WriteLine("Text written by anonimous method"); };
            //notification += text => Console.WriteLine("Text written by lambda operator");
            //notification("Text successfully logged");
            
            Account account = new(100);
            account.SetAcountStateHandler(new AccountStateHandler(Account.DisplayInfoInConsole));
            account.SetAcountStateHandler(new AccountStateHandler(Account.DisplayInfoInFile));
            account.Fill(100);
        }
    }   
}