namespace StockMarketGame.Models
{
    internal abstract class AAdress : IAddress
    {
       private readonly string Address;

        public AAdress(string address) => Address = address;
        public virtual string GetAddress() => Address;

    }
}
