using catchUpPlatform.API.News.Domain.Model.ValueObjects;

namespace catchUpPlatform.API.News.Domain.Model.Commands;

public record CreateFavoriteSourceCommand(NewsApiKey NewsApiKey, SourceId SourceId);