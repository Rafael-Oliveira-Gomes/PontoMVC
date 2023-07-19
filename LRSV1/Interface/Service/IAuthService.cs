using LRSV1.Models.Dto;
using LRSV1.Models;

namespace LRSV1.Interface.Service
{
    public interface IAuthService
    {
        Task<List<ApplicationUser>> ListUsers();
        Task<ApplicationUser> GetUserById(string userId);
        Task<int> UpdateUser(ApplicationUser user);
        Task<bool> DeleteUser(string userId);
        Task<ApplicationUser> GetCurrentUser();
        Task<bool> SignUp(SignUpDTO signUpDTO);
        Task<bool> SignIn(SignInDTO signInDTO);
    }
}
