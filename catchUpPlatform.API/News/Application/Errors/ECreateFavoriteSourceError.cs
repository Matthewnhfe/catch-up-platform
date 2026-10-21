namespace catchUpPlatform.API.News.Application.Errors;

public enum ECreateFavoriteSourceError
{
    InvalidNewsApiKey,
    InvalidSourceId,
    DuplicateFavoriteSource,
    UnexpectedError
}