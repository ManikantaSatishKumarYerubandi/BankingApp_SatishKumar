using System.Threading.Channels;
using BankingAPP.Entities;



#region Local Variables 

bool continueBanking = true;

Account acc = new Account()
{
    AccountNo = 101,
    AccountName = "Satish",
    AccountBalance = 130000,
    AccountIsActive = true,
    AccountType = "Current"

};
#endregion

while(continueBanking)
{
    Console.Clear();

    #region Display Menu
    Console.WriteLine("!!~~~~~~~~~~~~~~~~~~~Welcome to MyBank ~~~~~~~~~~~~~~~~~~~~!!");
    Console.WriteLine("1. View Account");
    Console.WriteLine("2. Withdraw");
    Console.WriteLine("3. Deposit");
    Console.WriteLine("4. Update account");
    Console.WriteLine("5. Close account");
    Console.WriteLine("6. Transfer Funds");
    Console.WriteLine("7. Exit"); 
    
    int choice = Convert.ToInt32(Console.ReadLine());
    #endregion

    #region Switch Case
    switch (choice)
    {
        #region View Account Info
        case 1:
            Console.WriteLine("Account No:"+acc.AccountNo);
            Console.WriteLine("Account Name:" + acc.AccountName);
            Console.WriteLine("Account Balance:" + acc.AccountBalance);
            Console.WriteLine("Account IsActive:" + acc.AccountIsActive);
            Console.WriteLine("Account Type:" + acc.AccountType);


            break;
        #endregion

        #region WithDraw Account
        case 2:
            Console.WriteLine("Please enter the amount to withdraw");
            int w_amount = Convert.ToInt32(Console.ReadLine());
            acc.withdraw(w_amount);
            Console.WriteLine("Withdrawal successful, Available balance:" + acc.AccountBalance);
            break;
        #endregion
        #region Deposit Account
        case 3:
            Console.WriteLine("Please enter the amount to Deposit");
            int d_amount = Convert.ToInt32(Console.ReadLine());
            acc.Deposit(d_amount);
            Console.WriteLine("Deposit successful, Available balance:" + acc.AccountBalance);
            break;
        #endregion
        #region Update Account Details
        case 4:
            Console.WriteLine("Please enter new account name: ");
            acc.AccountName = Console.ReadLine();
            Console.WriteLine("Enter Account Type:");
            acc.AccountType = Console.ReadLine();
            Console.WriteLine("Account details updated ");
            break;
        #endregion
        #region Close Account
        case 5:
            Console.WriteLine("Are you sure you want to discontinue the account? ");
            Console.WriteLine("1.Yes");
            Console.WriteLine("2. No");
            int deactivateAccount = Convert.ToInt32(Console.ReadLine());
            if(deactivateAccount==1)
            {
                acc.AccountIsActive = false;
                Console.WriteLine("Account is closed");
            }
            break;
        #endregion
        case 6:
            Console.WriteLine("Feature 6 coming soon ");
            break;
        case 7:
            continueBanking = false;
            Console.WriteLine("Thank you for Banking with us, see you again");
            break;
        default:
            Console.WriteLine("Sorry Invalid Option ");
            break;
    }
    #endregion
    #region ask for continuation
    Console.WriteLine("Do you wish to continue Banking:");
    Console.WriteLine("1.Yes");
    Console.WriteLine("2. No");

    int continuemore = Convert.ToInt32(Console.ReadLine());
    if (continuemore != 1)
    {
        continueBanking = false;
    }
    #endregion

}