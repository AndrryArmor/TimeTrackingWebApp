namespace TimeTracking.Identity.BL.Impl.Settings
{
    public class JwtSettings
    {
        public string Key { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public double AccessTokenExpirationTime { get; set; }
        public double RefreshTokenExpirationTime { get; set; }
    }
}