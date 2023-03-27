namespace PortfolioUI.Services.Email
{
    public interface IEmailService
    {
        Task<bool> SendEmail(string name, string phoneNumber, string email, string message);
    }
}