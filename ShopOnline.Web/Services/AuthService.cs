using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ShopOnline.Web.Services.Contracts;
using static ShopOnline.Web.Services.Contracts.IAuthService;
using ShopOnline.Models;
using ShopOnline.Models.Dtos;

public class AuthService : IAuthService
{
    private readonly HttpClient httpClient;

    public AuthService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<bool> Login(LoginModel loginModel)
    {
        try
        {
            var response = await httpClient.PostAsJsonAsync("api/auth/login", loginModel);

            return response.IsSuccessStatusCode;
        }
        catch (Exception)
        {
            // Logowanie wyjątków
            throw;
        }
    }

    public async Task<bool> Register(RegisterModel registerModel)
    {
        try
        {
            var localUser = new LocalUser
            {
                UserName = registerModel.Username,
                Email = registerModel.Email,
                Password = registerModel.Password,
            };

            if (IsValidLocalRegistration(localUser))
            {
                // Tutaj możesz dodać kod do zapisu użytkownika do bazy danych,
                // jeśli to wymagane przez twoją aplikację.

                // Przykładowy kod do zapisu do bazy danych:
                // repository.AddUser(localUser);

                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task Logout()
    {
        // Implementacja wylogowywania
    }

    private bool IsValidLocalRegistration(LocalUser localUser)
    {
        if (string.IsNullOrWhiteSpace(localUser.UserName))
        {
            return false;
        }

        if (string.IsNullOrWhiteSpace(localUser.Email) || !IsValidEmail(localUser.Email))
        {
            // Walidacja nie powiodła się - nieprawidłowy email
            return false;
        }

        if (string.IsNullOrWhiteSpace(localUser.Password) || localUser.Password.Length < 6)
        {
            // Walidacja nie powiodła się - hasło zbyt krótkie
            return false;
        }

        return true;
    }

    private bool IsValidEmail(string email)
    {
        // Przykładowa prosta walidacja adresu email
        return email.Contains("@") && email.Length > 5;
    }
}
