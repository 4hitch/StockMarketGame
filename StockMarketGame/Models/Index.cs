namespace StockMarketGame.Models
{
    internal class Index : IIndex
    {
        private readonly string Name;
        private readonly string ClearName;

        public Index(string name, string clearName) => (Name, ClearName) = (name, clearName);

        
        public override bool Equals(object obj)
        {
            return obj is not Index ? false : !(obj as Index).Name.Equals(Name);
        }

        public override int GetHashCode() => Name.GetHashCode();

        public string GetName() => Name;

        public static bool operator ==(Index i, object obj) => i.Equals(obj);
        public static bool operator !=(Index i, object obj) => !i.Equals(obj);

       
        
    }
}
