namespace BankApplication.Models
{
    public class BankAccountModel
    {
        public int Id_Account { get; set; }
        public double Amount { get; set; }


        public int Id_User { get; set; }
        public UserModel UserModel { get; set; }
    }
}
