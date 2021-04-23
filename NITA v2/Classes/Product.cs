using System.Collections.Generic;
using Newtonsoft.Json;

namespace NITA_v2.Classes
{
    public class Product
    {
        public decimal VALUE { get; set; }
        public string NAME { get; set; }
        public string EAN { get; set; }
        public int ID { get; set; }

        public static List<Product> Parse(string json)
        {
            var result = JsonConvert.DeserializeObject<List<Product>>(json);
            return result;
        }

        public Product(int id, string name, string ean, decimal value)
        {
            VALUE = value;
            NAME = name;
            EAN = ean;
            ID = id;
        }

        public static Product GetProductById(List<Product> productList, int id)
        {
            var result = new Product(-1, "Produto não encontrado!", "", 0);
            foreach (var product in productList)
                if (product.ID == id)
                    result = product;
            return result;
        }

        public static Product GetProductByEAN(List<Product> productList, string ean)
        {
            var result = new Product(-1, "Produto não encontrado!", "", 0);
            foreach (var product in productList)
                if (product.EAN == ean)
                    result = product;
            return result;
        }
    }
}
