using catchUpPlatform.API.News.Domain.Model.ValueObjects;

namespace catchUpPlatform.API.News.Domain.Model.Queries;

public record GetAllFavoriteSourcesByNewsApiKeyQuery(NewsApiKey ApiKey);