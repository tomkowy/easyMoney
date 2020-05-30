namespace Common.Configuration
{
    public class Authentication
    {
        public string JwtSecret { get; set; }
        public int JwtExpireDays { get; set; }
    }
}
