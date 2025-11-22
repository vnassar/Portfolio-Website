namespace Portfolio_Website.Models
{
    public record RegisterRequest(string Email, string Password, string Nickname);
    public record LoginRequest(string Email, string Password);

    public record AuthResponse(
        string Token,
        Guid UserId,
        string Email,
        string Nickname,
        string AvatarUrl,
        int Mmr,
        string RankName,
        int Wins,
        int Losses
    );
}
