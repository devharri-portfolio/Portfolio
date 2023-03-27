using System.Net;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using PortfolioUI.Models;

namespace PortfolioUI.Services.Email;

public class EmailService : IEmailService
{
    public async Task<bool> SendEmail(string name, string phoneNumber, string email, string message)
    {

        Console.WriteLine("Sending email.");
        try
        {
            //Send httpPost to API. Send name, phonenumber, email and message in body
            using (var client = new HttpClient())
            {
                var url = $"https://harrihonkanenportfolioapi.azurewebsites.net/api/email";
                //var url = $"https://localhost:7295/api/email";

                StringContent jsonContent = new(
                    JsonConvert.SerializeObject(new
                    {
                        name = name,
                        email = email,
                        number = phoneNumber,
                        message = message
                    }),
                Encoding.UTF8,
                "application/json");

                var response = await client.PostAsync(url, jsonContent);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    return false;
                }

                var responseString = await response.Content.ReadAsStringAsync();

            }
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
}