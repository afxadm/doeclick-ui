using Totem.Domain.Dtos;
using Totem.Domain.Entities;
using Totem.Domain.Interfaces;
using Totem.Domain.Interfaces.Facades;
using Totem.Domain.View;

namespace Totem.Domain.Facades
{
    public class UserFacade : IUserFacade
    {
        private readonly IUserRepository _userRepository;

        public UserFacade(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<PaginationViewModel<Users>> GetPaginated(PaginationParams paginationParams)
            => await _userRepository.GetUsers(paginationParams);

        public async Task<Users?> GetUserByCpf(string cpf)
            => await _userRepository.GetUserByCpf(cpf);

        public async Task<bool> SaveUser(Users user)
        {
            if (await _userRepository.SaveUser(user) > 0)
                return true;

            return false;
        }
    }
}
