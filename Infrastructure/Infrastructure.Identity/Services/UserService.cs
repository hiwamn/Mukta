using Infrastructure.Identity.Domain.Models;
using Infrastructure.Identity.Domain.Repositories;
using System.Threading.Tasks;
using Utility.Tools.Auth;
using Utility.Tools.Exceptions;

namespace Infrastructure.Identity.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IEncrypter _encrypter;
        private readonly IJwtHandler _jwtHandler;

        public UserService(IUserRepository repository,
            IEncrypter encrypter,
            IJwtHandler jwtHandler)
        {
            _repository = repository;
            _encrypter = encrypter;
            _jwtHandler = jwtHandler;
        }

        public async Task RegisterAsync(string email, string password, string name)
        {
            var user = await _repository.GetAsync(email);
            if (user != null)
            {
                throw new CustomException("email_in_use",
                    $"Email: '{email}' is already in use.");
            }
            user = new User(email, name);
            user.SetPassword(password, _encrypter);
            await _repository.AddAsync(user);
        }

        public async Task<JsonWebToken> LoginAsync(string email, string password)
        {
            var user = await _repository.GetAsync(email);
            if (user == null)
            {
                throw new CustomException("invalid_credentials",
                    $"Invalid credentials.");
            }
            if (!user.ValidatePassword(password, _encrypter))
            {
                throw new CustomException("invalid_credentials",
                    $"Invalid credentials.");
            }

            return _jwtHandler.Create(user.Id);
        }

       
    }
}