using System.Text;

namespace TStore
{
    [Serializable]
    public class Product
    {
        private static int CurrentId = 1;
        public int Id { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }

        public Product(string name, double price)
        {
            Id = CurrentId++;
            Name = name;
            Price = price;
            Price = price;
        }
        public override string ToString()
        {
            return GetType().GetProperties()
                .Select(info => (info.Name, Value: info.GetValue(this, null) ?? "(null)"))
                .Aggregate(
                    new StringBuilder(),
                    (sb, pair) => sb.AppendLine($"{pair.Name}: {pair.Value}"),
                    sb => sb.ToString());
        }
    }
    

}