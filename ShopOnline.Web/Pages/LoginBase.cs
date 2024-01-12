using Microsoft.AspNetCore.Components;
using ShopOnline.Web.Services.Contracts;
using static ShopOnline.Web.Services.Contracts.IAuthService;

namespace ShopOnline.Web.Pages
{
    public class LoginBase : ComponentBase
    {
        [Inject]
        protected IAuthService AuthService { get; set; }

        [Inject]
        protected NavigationManager Navigation { get; set; }

        // Initialize LoginModel here
        protected LoginModel LoginModel { get; set; } = new LoginModel();
        protected bool LoginSuccess { get; set; }
        protected string ErrorMessage { get; set; }

        protected async Task LoginUserBase()
        {
            try
            {
                var loginResult = await AuthService.Login(LoginModel);

                if (loginResult)
                {
                    LoginSuccess = true;

                    await Task.Delay(3000);

                    Navigation.NavigateTo("/ShoppingCart"); 
                }
                else
                {
                    Navigation.NavigateTo("/login");
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }
    }
}