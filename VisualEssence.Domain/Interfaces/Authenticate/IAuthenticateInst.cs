﻿using VisualEssence.Domain.Models;

namespace VisualEssence.Domain.Interfaces.Authenticate
{
    public interface IAuthenticateInst
    {
        Task<bool> AuthenticateAsync(string email, string senha);
        Task<bool> UserExists(string email);
        public string GenerateToken(Guid id, string email);
        public Task<UserInst> GetUserByEmail(string email);
    }
}
