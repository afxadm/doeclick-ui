using Totem.Domain;
using Totem.Domain.Dtos;
using Totem.Domain.Entities;
using Totem.Domain.Interfaces.Facades;
using Totem.Domain.Util;
using Totem.Domain.View;

namespace Totem.Application.UseCases
{
    public class UserUseCase : IUserUseCase
    {
        private readonly IUserFacade _userFacade;
        private readonly IBranchFacade _branchFacade;
        private readonly IPositionFacade _positionFacade;

        public UserUseCase(IUserFacade userFacade, IBranchFacade branchFacade, IPositionFacade positionFacade)
        {
            _userFacade = userFacade;
            _branchFacade = branchFacade;
            _positionFacade = positionFacade;
        }

        public async Task<PaginationViewModel<Users>> GetPaginated(PaginationParams paginationParams)
        => await _userFacade.GetPaginated(paginationParams);

        public async Task<ResponseBase<object>> SaveUser(UserDto user)
        {
            var userFound = await _userFacade.GetUserByCpf(user.Cpf);

            if (userFound != null)
            {
                return new ResponseBase<object>()
                {
                    IsSuccess = false,
                    Data = "Usuário já existe na base."
                };
            }

            var newUser = Users.Of(user);

            newUser.SetCryptPassword(PasswordHelper.HashPassword(user.Password));

            if (user.BranchId.HasValue)
                newUser.Branch = await _branchFacade.GetBranchById(user.BranchId.Value);

            if (user.PositionId.HasValue)
                newUser.Position = await _positionFacade.GetPositionById(user.PositionId.Value);

            var saved = await _userFacade.SaveUser(newUser);

            return new ResponseBase<object>()
            {
                IsSuccess = saved,
                Data = new
                {
                    newUser.Id,
                    newUser.Cpf,
                    newUser.Email
                }
            };
        }
    }
}
