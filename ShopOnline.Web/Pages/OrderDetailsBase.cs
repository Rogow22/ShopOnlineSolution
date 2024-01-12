using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using ShopOnline.Models.Dtos;
using ShopOnline.Web.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopOnline.Web.Pages
{
    public class OrderDetailBase : ComponentBase
    {
        [Inject]
        public IJSRuntime Js { get; set; }

        [Inject]
        public IShoppingCartService ShoppingCartService { get; set; }

        protected IEnumerable<CartItemDto> ShoppingCartItems { get; set; }
        protected int TotalQty { get; set; }

        protected decimal PaymentAmount { get; set; }

        protected string OrderStatus { get; set; }
        protected DateTime OrderDate { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                ShoppingCartItems = await ShoppingCartService.GetItems(HardCoded.UserId);

                if (ShoppingCartItems != null && ShoppingCartItems.Any())
                {
                    // Simulate an order
                    OrderStatus = "Waiting for Shipment";
                    OrderDate = DateTime.Now;
                    PaymentAmount = ShoppingCartItems.Sum(p => p.TotalPrice);
                    TotalQty = ShoppingCartItems.Sum(p => p.Qty);
                }
            }
            catch (Exception)
            {
                // Log exception
                throw;
            }
        }
    }
}