namespace WhereIsProduct.ElementsOfDB
{
    public class Product : ElementForInsert 
    {
        #region Fields
        private string _name;
        private string _cost;
        private string _category;
        #endregion

        #region Properties
        public string Name { get { return _name; } }
        public string Cost { get { return _cost; } }
        public string Category { get { return _category; } }
        #endregion

        #region Constructors
        public Product(string name, string cost, string category)
        {
            _name = name;
            _cost = cost;
            _category = category;
            _commandText = "insert into products(product_id, product_name, cost, category_name) values(default, '" + name + "', " + cost.Replace(',', '.') + ", '" + category + "') returning product_id;";
        }
        #endregion
    }
}