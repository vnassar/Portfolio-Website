namespace Portfolio_Website.Models
{
    public record ProfileResponse(
    Guid UserId,
    string Email,
    string Nickname,
    string AvatarUrl,
    string? Bio,
    int Mmr,
    string RankName,
    int Wins,
    int Losses
    );

    public record UpdateProfileRequest(
        string Nickname,
        string? Bio
    );

}
