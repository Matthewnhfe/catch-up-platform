using catchUpPlatform.API.News.Application.Errors;
using catchUpPlatform.API.News.Domain.Model.Aggregates;
using catchUpPlatform.API.News.Domain.Model.Commands;
using catchUpPlatform.API.Shared.Application.Patterns;

namespace catchUpPlatform.API.News.Application.Services;

public interface IFavoriteSourceCommandService
{
    Task<Result<FavoriteSource, ECreateFavoriteSourceError>> Handle(
        CreateFavoriteSourceCommand command,
        CancellationToken cancellationToken = default);
}