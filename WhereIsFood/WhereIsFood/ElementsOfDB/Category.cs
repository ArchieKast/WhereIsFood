namespace WhereIsProduct.ElementsOfDB
{
    public class Category : ElementForInsert
    {
        #region Fields
        private string _name;
        #endregion

        #region Properties
        public string Name { get { return _name; } }
        #endregion

        #region Constructors
        public Category(string name)
        {
            _name = name;
            _commandText = "insert into categories(category_name) values('" + name + "');";
        }
        #endregion
    }
}