namespace IdentityMail.Web.DTOs.UserMessageDtos
{
    public class SendMailDto
    {
        public string Subject { get; set; }
        public string ReceiverMail { get; set; }
        public string Body { get; set; }
    }
}
