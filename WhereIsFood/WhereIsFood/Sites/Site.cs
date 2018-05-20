using System.Collections.Generic;
using WhereIsProduct.ElementsOfDB;

namespace WhereIsProduct.Sites
{
    public interface Site
    {
        #region Properties
        List<string> ProductsReferences { get; }
        List<string> ShopsReferences { get; }
        #endregion

        #region Methods
        List<Product> GetProducts();
        List<Shop> GetShops();
        #endregion
    }
}