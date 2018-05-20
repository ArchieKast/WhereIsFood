namespace WhereIsProduct.ElementsOfDB
{
    public class Purchase : ElementForInsert
    {
        #region Constructors
        public Purchase()
        {
            _commandText = "insert into purchases(purchase_id) values(default);";
        }
        #endregion
    }
}