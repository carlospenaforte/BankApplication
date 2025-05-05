namespace BankApplication.Models
{
    public class TransfersModel
    {
        public int Id_Transfer { get; set; }

        public int Id_Account_From { get; set; }
        public BankAccountModel Account_From { get; set; }

        public int Id_Account_To { get; set; }
        public BankAccountModel Account_To { get; set; }

        public decimal Amount { get; set; }
        public DateTime TransferDate { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
