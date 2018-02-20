namespace PoloniexSharp.Entities
{
    public class CurrencyDetails
    {
        public string CurrencySymbol { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public double TxFee { get; set; }
        public int MinConf { get; set; }
        public string DepositAddress { get; set; }
        public bool Disabled { get; set; }
        public bool Delisted { get; set; }
        public bool Frozen { get; set; }
    }
}
