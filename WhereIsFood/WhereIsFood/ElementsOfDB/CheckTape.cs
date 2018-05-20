namespace WhereIsProduct.ElementsOfDB
{
    public class CheckTape : ElementForInsert
    {
        #region Fields
        private int _purchase_id;
        private int _product_id;
        private int _amount;
        #endregion

        #region Properties
        public int PurchaseId { get { return _purchase_id; } }
        public int ProductId { get { return _product_id; } }
        public int Amount { get { return _amount; } }
        #endregion

        #region Constructors
        public CheckTape(int purchase_id, int product_id, int amount)
        {
            _purchase_id = purchase_id;
            _product_id = product_id;
            _amount = amount;
            _commandText = "insert into check_tape(purchase_id, product_id, amount) values("+ purchase_id + ", " + product_id + ", " + amount + ");";
        }
        #endregion
    }
}