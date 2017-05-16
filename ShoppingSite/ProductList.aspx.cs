using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoppingSite.Models;
using System.Web.ModelBinding;

namespace ShoppingSite
{
    public partial class ProductList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //to limit results to a specific category, code sets categoryId from the query string
        //value passed to the productlist.aspx page when navigated to. the querystringattribute
        //class in system.web.modelbinding is used to retrieve the value of the query string
        //variable id.
        public IQueryable<Product> GetProducts([QueryString("id")] int? categoryId)
        {
            var _db = new ShoppingSite.Models.ProductContext();
            IQueryable<Product> query = _db.Products;
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoryID == categoryId);
            }
            return query;
        }
    }
}