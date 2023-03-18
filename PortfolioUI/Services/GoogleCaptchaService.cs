using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace PortfolioUI.Services;

public class GoogleCaptchaService
{
    //Post request to Web API with token in query
    public async Task<bool> VerifyToken(string token)
    {
        try
        {
            using (var client = new HttpClient())
            {
                var url = $"https://localhost:7295/api/recaptcha?token={token}";

                var httpResult = await client.GetAsync(url);
                if (httpResult.StatusCode != HttpStatusCode.OK)
                {
                    return false;
                }

                var responseString = await httpResult.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<bool>(responseString);

                return result;
            }
        }
        catch (Exception ex)
        {
            return false;
        }
    }
}