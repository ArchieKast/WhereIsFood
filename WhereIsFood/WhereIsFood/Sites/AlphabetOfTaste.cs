using HtmlAgilityPack;
using System.Collections.Generic;
using WhereIsProduct.ElementsOfDB;

namespace WhereIsProduct.Sites
{
    public class AlphabetOfTaste : Site
    {
        #region Constructors
        public AlphabetOfTaste(string site)
        {
            ProductsReferences = new List<string>();
            ShopsReferences = new List<string>();

            var web = new HtmlWeb();
            var doc = new HtmlDocument();
            doc = web.Load(site);
            var productsNodes = doc.DocumentNode.SelectNodes("//a[@class='b-header-new-menu__level-item-link']");
            foreach (var node in productsNodes)
            {
                string page = node.Attributes["href"].Value.Replace(site, "");
                if (!page.Contains("javascript:void(0)"))
                {
                    ProductsReferences.Add(site + page);
                }
            }

            site += "/shops/";
            ShopsReferences.Add(site);
        }
        #endregion

        #region Properties
        public List<string> ProductsReferences { get; }
        public List<string> ShopsReferences { get; }
        #endregion

        #region Methods
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            var web = new HtmlWeb();
            var doc = new HtmlDocument();
            foreach (var reference in ProductsReferences)
            {
                doc = web.Load(reference);
                var nextPage = "https://av.ru";
                while (nextPage != null)
                {
                    var nodes = doc.DocumentNode.SelectNodes("//div[@class='b-grid__item']/div");
                    if (nodes != null)
                    {
                        foreach (var node in nodes)
                        {
                            var product_name = node.SelectSingleNode(".//a[@class='b-product__title js-list-prod-open']").InnerText;
                            var cost = node.Attributes["data-unit-price"].Value;
                            var category = node.Attributes["data-category-name"].Value;
                            products.Add(new Product(product_name, cost, category));
                        }
                        try
                        {
                            nextPage = "https://av.ru" + doc.DocumentNode.SelectSingleNode("//a[@class='b-pager__btn b-pager__btn_next']").Attributes["href"].Value.Replace("amp;", "");
                            doc = web.Load(nextPage);
                        }
                        catch
                        {
                            nextPage = null;
                        }
                    }
                    else
                    {
                        nextPage = null;
                    }
                }
            }
            return products;
        }

        public List<Shop> GetShops()
        {
            List<Shop> shops = new List<Shop>();
            var web = new HtmlWeb();
            var doc = new HtmlDocument();
            foreach (var reference in ShopsReferences)
            {
                doc = web.Load(reference);
                var nodes = doc.DocumentNode.SelectNodes("//ul[@class='shops_menu general']/li/a");
                foreach (var node in nodes)
                {
                    var adress = node.InnerText;
                    shops.Add(new Shop("Азбука вкуса", adress, "Москва и Московская область"));
                }
                
            }
            return shops;
        }
        #endregion
    }
}