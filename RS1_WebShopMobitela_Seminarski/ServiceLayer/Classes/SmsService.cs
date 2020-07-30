using Nexmo.Api.Messaging;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;


using Nexmo.Api.Request;
using ServiceLayer.Classes.Helper;
using Microsoft.Extensions.Configuration;
using RepositoryLayer;
using Microsoft.Extensions.Options;

namespace ServiceLayer.Classes
{
    public class SmsService : ISmsService
    {
        private IRepository<SmsLog> smsRepository { get; set; }
        private SmsSettings smsSettings { get; set; }

        public SmsService(IRepository<SmsLog> smsRepository, IOptions<SmsSettings> smsSettings)
        {
            this.smsRepository = smsRepository;
            this.smsSettings = smsSettings.Value;
        }

        public string SendSms(SmsModel entity)
        {
            

            var credentials = Credentials.FromApiKeyAndSecret(smsSettings.NEXMO_API_KEY, smsSettings.NEXMO_API_SECRET);
            var client = new SmsClient(credentials);
            var request = new SendSmsRequest { To = entity.To, From = smsSettings.BROJ_MOBITELA, Text = entity.Text };
            var response = client.SendAnSms(request);

            // if we sent the sms succesfully save the details to database.
            if(response != null) { 
                SmsLog log = new SmsLog { Broj = entity.To, Poruka = entity.Text, Dodatnisadrzaj = response.Messages[0].MessageId };
                smsRepository.Insert(log);
                return response.Messages[0].MessageId;
            }

            return null;
        }
    }
}
