using Final_Project_2024.DTOs;
using static Final_Project_2024.Responses.CustomResponses;

namespace Final_Project_2024.Repos
{
    public interface IAccount
    {
        Task<RegistationResponses> RegistationAsync(RegisterDTO model);
        Task<LoginResponses> LoginAsync(LoginDTO model);
    }
}
