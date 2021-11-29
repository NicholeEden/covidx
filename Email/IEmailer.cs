namespace Utility.Email
{
    public interface IEmailer
    {
        bool SendEmail(ClientType client, string toEmail, string subject, string body);
    }
}