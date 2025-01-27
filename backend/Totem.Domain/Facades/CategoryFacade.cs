using Totem.Domain.Entities;
using Totem.Domain.Interfaces;
using Totem.Domain.View;

namespace Totem.Domain.Facades
{
    public class CategoryFacade : ICategoryFacade
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryFacade(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<bool> SaveCategory(Categories category)
        {
            if (await _categoryRepository.SaveCategory(category) > 0)
                return true;

            return false;
        }

        public async Task<PaginationViewModel<Categories>> GetPaginated(PaginationParams paginationParams)
            => await _categoryRepository.GetPaginated(paginationParams);
    }
}
