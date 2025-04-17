using Fantasy.Shared.Responses;

namespace Fantasy.Backend.Helpers;

public interface IMailHelper
{
    ActionResponse<string> SendEmail(string toName, string toEmail, string subject, string body, string languaje, bool isHtml = true);
}