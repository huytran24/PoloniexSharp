namespace PoloniexSharp.Entities
{
    using System.Collections.Generic;

    public class LoanOrderResponse
    {
        public List<LoanOrderDetails> Offers { get; set; }
        public List<LoanOrderDetails> Demands { get; set; }
    }
}
