namespace VBV3Project.Interfaces
{
    public interface IEmailSender
    {
        Task SendEmailConfirmationAsync(string email, string link);
        Task SendEmailAsync(string email, string subject, string message);
    }
}
