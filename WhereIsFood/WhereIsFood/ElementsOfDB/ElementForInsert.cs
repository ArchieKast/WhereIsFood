using System.Runtime.Serialization;

namespace WhereIsProduct.ElementsOfDB
{
    public abstract class ElementForInsert
    {
        #region Fields
        protected string _commandText;
        #endregion

        #region Properties
        public string CommandText { get { return _commandText; } }
        #endregion
    }
}