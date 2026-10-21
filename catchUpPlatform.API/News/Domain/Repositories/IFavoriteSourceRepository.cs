using catchUpPlatform.API.News.Domain.Model.Aggregates;
using catchUpPlatform.API.News.Domain.Model.ValueObjects;
using catchUpPlatform.API.Shared.Domain.Repositories;

namespace catchUpPlatform.API.News.Domain.Repositories;

public interface IFavoriteSourceRepository : IBaseRepository<FavoriteSource>
{
    Task<IEnumerable<FavoriteSource>> FindByNewsApiKeyAsync(NewsApiKey newsApiKey, CancellationToken cancellationToken = default);
    Task<FavoriteSource?> FindByNewsApiKeyAndSourceIdAsync(NewsApiKey newsApiKey, SourceId sourceId, CancellationToken cancellationToken = default);
    
}