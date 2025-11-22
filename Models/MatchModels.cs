namespace Portfolio_Website.Models
{
    public record MatchReportRequest(
        bool Won,
        int Score,
        string GameMode
        );
}
