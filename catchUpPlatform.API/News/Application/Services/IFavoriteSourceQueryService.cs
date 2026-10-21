using catchUpPlatform.API.News.Domain.Model.Aggregates;
using catchUpPlatform.API.News.Domain.Model.Queries;

namespace catchUpPlatform.API.News.Application.Services;

public interface IFavoriteSourceQueryService
{
    Task<IEnumerable<FavoriteSource>> Handle(GetAllFavoriteSourcesByNewsApiKeyQuery query,
        CancellationToken cancellationToken = default);
    
    Task<FavoriteSource?> Handle(GetFavoriteSourceByNewsApiKeyAndSourceIdQuery query,
        CancellationToken cancellationToken = default);
    
    Task<FavoriteSource?> Handle(GetFavoriteSourceByIdQuery query,
        CancellationToken cancellationToken = default);
}