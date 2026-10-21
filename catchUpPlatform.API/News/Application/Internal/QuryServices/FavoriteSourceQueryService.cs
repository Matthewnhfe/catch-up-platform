using catchUpPlatform.API.News.Application.Services;
using catchUpPlatform.API.News.Domain.Model.Aggregates;
using catchUpPlatform.API.News.Domain.Model.Queries;
using catchUpPlatform.API.News.Domain.Repositories;

namespace catchUpPlatform.API.News.Application.Internal.QuryServices;

public class FavoriteSourceQueryService(IFavoriteSourceRepository favoriteSourceRepository) : IFavoriteSourceQueryService
{
    public async Task<IEnumerable<FavoriteSource>> Handle(GetAllFavoriteSourcesByNewsApiKeyQuery query, CancellationToken cancellationToken = default)
    {
        return await favoriteSourceRepository.FindByNewsApiKeyAsync(query.ApiKey, cancellationToken);
    }

    public async Task<FavoriteSource?> Handle(GetFavoriteSourceByNewsApiKeyAndSourceIdQuery query, CancellationToken cancellationToken = default)
    {
        return await favoriteSourceRepository.FindByNewsApiKeyAndSourceIdAsync(query.NewsApiKey, query.SourceId, cancellationToken);
    }

    public async Task<FavoriteSource?> Handle(GetFavoriteSourceByIdQuery query, CancellationToken cancellationToken = default)
    {
        return await favoriteSourceRepository.FindByIdAsync(query.Id, cancellationToken);
    }
}