using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ShoppingSite.Models
{
    /****************************************
     * CartItem contains the schema that will
     * define each product the user adds to
     * the shopping cart. Primary key for CartItem
     * is CartItemId or ID by default but I set it
     * to ItemID.
     ***************************************/
    public class CartItem
    {
        [Key]
        public string ItemId { get; set; }

        //The ID of the user that is associated with the item to purchase
        public string CartId { get; set; }

        public int Quantity { get; set; }

        public System.DateTime DateCreated { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}