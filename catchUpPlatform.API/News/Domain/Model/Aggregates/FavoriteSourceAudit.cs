using catchUpPlatform.API.Shared.Domain.Model;

namespace catchUpPlatform.API.News.Domain.Model.Aggregates;

public partial class FavoriteSource : IAuditableEntity
{
    public DateTimeOffset? CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}