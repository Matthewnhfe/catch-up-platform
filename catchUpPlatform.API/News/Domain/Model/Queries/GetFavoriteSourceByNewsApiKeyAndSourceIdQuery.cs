using catchUpPlatform.API.News.Domain.Model.ValueObjects;

namespace catchUpPlatform.API.News.Domain.Model.Queries;

public record GetFavoriteSourceByNewsApiKeyAndSourceIdQuery(NewsApiKey NewsApiKey, SourceId SourceId);