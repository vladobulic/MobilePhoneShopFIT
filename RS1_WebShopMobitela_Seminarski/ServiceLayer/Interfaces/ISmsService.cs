using Microsoft.Extensions.Configuration;
using ServiceLayer.Classes.Helper;


namespace ServiceLayer.Interfaces
{
    public interface ISmsService
    {
        string SendSms(SmsModel entity);
    }
}
