namespace PortfolioUI.Services.GoogleCaptcha
{
    public interface IGoogleCaptchaService
    {
        Task<bool> VerifyToken(string token);
    }
}