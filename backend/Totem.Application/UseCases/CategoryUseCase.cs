using Totem.Domain;
using Totem.Domain.Dtos;
using Totem.Domain.Entities;
using Totem.Domain.Interfaces;
using Totem.Domain.View;

namespace Totem.Application.UseCases
{
    public class CategoryUseCase : ICategoryUseCase
    {
        private readonly ICategoryFacade _categoryFacade;
        public CategoryUseCase(ICategoryFacade categoryFacade)
        {
            _categoryFacade = categoryFacade;
        }

        public async Task<ResponseBase<Categories>> SaveCategory(CategoryDto categoryDto)
        {
            var category = Categories.Of(categoryDto);
            var saved = await _categoryFacade.SaveCategory(category);

            return new ResponseBase<Categories>
            {
                Data = category,
                IsSuccess = saved
            };
        }

        public async Task<PaginationViewModel<Categories>> GetPaginated(PaginationParams paginationParams)
            => await _categoryFacade.GetPaginated(paginationParams);


    }
}

