using Fantasy.Backend.Repositories.Interfaces;
using Fantasy.Backend.UnitsOfWork.Interfaces;
using Fantasy.Shared.DTOs;
using Fantasy.Shared.Entities;
using Fantasy.Shared.Responses;
using Microsoft.AspNetCore.Identity;

namespace Fantasy.Backend.UnitOfWork.Implementations;

public class UsersUnitOfWork : IUsersUnitOfWork
{
    private readonly IUsersRepository _usersRepository;

    public UsersUnitOfWork(IUsersRepository usersRepository)
    {
        _usersRepository = usersRepository;
    }

    public async Task<IdentityResult> AddUserAsync(User user, string password) => await _usersRepository.AddUserAsync(user, password);

    public async Task AddUserToRoleAsync(User user, string roleName) => await _usersRepository.AddUserToRoleAsync(user, roleName);

    public async Task CheckRoleAsysnc(string roleName) => await _usersRepository.CheckRoleAsysnc(roleName);

    public async Task<IdentityResult> ConfirmEmailAsync(User user, string token) => await _usersRepository.ConfirmEmailAsync(user, token);

    public async Task<string> GenerateEmailConfirmationTokenAsync(User user) => await _usersRepository.GenerateEmailConfirmationTokenAsync(user);

    public async Task<User> GetUserAsync(string email) => await _usersRepository.GetUserAsync(email);

    public async Task<User> GetUserAsync(Guid userId) => await _usersRepository.GetUserAsync(userId);

    public async Task<bool> IsUserInRoleAsync(User user, string roleName) => await _usersRepository.IsUserInRoleAsync(user, roleName);

    public async Task<SignInResult> LoginAsync(LoginDTO model) => await _usersRepository.LoginAsync(model);

    public async Task LogoutAsync() => await _usersRepository.LogoutAsync();

    Task<IdentityResult> IUsersUnitOfWork.ChangePasswordAsync(User user, string currentPassword, string newPassword)
    {
        throw new NotImplementedException();
    }

    public async Task CheckRoleAsync(string roleName) => await _usersRepository.CheckRoleAsysnc(roleName);

    Task<string> IUsersUnitOfWork.GeneratePasswordResetTokenAsync(User user)
    {
        throw new NotImplementedException();
    }

    Task<ActionResponse<IEnumerable<User>>> IUsersUnitOfWork.GetAsync(PaginationDTO pagination)
    {
        throw new NotImplementedException();
    }

    Task<ActionResponse<int>> IUsersUnitOfWork.GetTotalRecordsAsync(PaginationDTO pagination)
    {
        throw new NotImplementedException();
    }

    Task<IdentityResult> IUsersUnitOfWork.ResetPasswordAsync(User user, string token, string password)
    {
        throw new NotImplementedException();
    }

    Task<IdentityResult> IUsersUnitOfWork.UpdateUserAsync(User user)
    {
        throw new NotImplementedException();
    }
}