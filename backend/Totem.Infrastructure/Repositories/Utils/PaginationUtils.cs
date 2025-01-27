using System.Data.Entity;
using Totem.Domain;

namespace Totem.Infrastructure.Repositories.Utils
{
    public static class PaginationUtils
    {
        public static IQueryable<T> Paginate<T, TPaginationSearchParams>(this IQueryable<T> query, TPaginationSearchParams paginationSearchParams)
            where TPaginationSearchParams : PaginationParams
        {
            if (!paginationSearchParams.ItemsByPage.HasValue)
                return query;

            if (paginationSearchParams.PageIndex.HasValue && paginationSearchParams.PageIndex > 1)
                query = query.Skip(paginationSearchParams.ItemsByPage.Value *
                                   (paginationSearchParams.PageIndex.Value - 1));

            query = query.Take(paginationSearchParams.ItemsByPage.Value);

            return query;
        }
    }
}
