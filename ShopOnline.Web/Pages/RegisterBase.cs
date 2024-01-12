using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using ShopOnline.Models.Dtos;
using ShopOnline.Web.Services.Contracts;
using static ShopOnline.Web.Services.Contracts.IAuthService;

namespace ShopOnline.Web.Pages
{
    public class RegisterBase : ComponentBase
    {
        [Inject]
        protected IAuthService AuthService { get; set; }

        [Inject]
        protected NavigationManager Navigation { get; set; }

        // Initialize RegisterModel here
        protected RegisterModel RegisterModel { get; set; } = new RegisterModel();
        protected bool RegistrationSuccess { get; set; }
        protected string ErrorMessage { get; set; }

        protected async Task RegisterUserBase()
        {
            try
            {
                var result = await AuthService.Register(RegisterModel);

                if (result)
                {
                    RegistrationSuccess = true;

                    // Delay redirection for 3 seconds
                    await Task.Delay(3000);

                    Navigation.NavigateTo("/login");
                }
                else
                {
                    Navigation.NavigateTo("/register");
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }

        private bool IsValidLocalRegistration(LocalUser localUser)
        {
            if (string.IsNullOrWhiteSpace(localUser.UserName))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(localUser.Email) || !IsValidEmail(localUser.Email))
            {
                // Validation failed - invalid email
                return false;
            }

            if (string.IsNullOrWhiteSpace(localUser.Password) || localUser.Password.Length < 6)
            {
                // Validation failed - password too short
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            // Sample simple email address validation
            return email.Contains("@") && email.Length > 5;
        }

        // Class for storing information about the local user
        public class LocalUser
        {
            public string UserName { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
        }
    }
}