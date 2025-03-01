namespace Core.Constants
{
    public class AppSettings
    {
        public string JWTKey { get; set; } = string.Empty;

        public string JWTIssuer { get; set; } = string.Empty;

        public int JWTTokenTime { get; set; } = 30;

        public required string ConnectionString { get; set; }

        public string? MaTinhThanhPho { get; set; }
    }
}