/* This class get a token of cognitive service api.
 * http://docs.microsofttranslator.com/oauth-token.html
 * Get access token sample code from Microsoft.
 * https://github.com/MicrosoftTranslator/GetAzureToken/blob/master/AzureAuthToken.cs
 * Special thanks to @beachside
 * Cognitive Services でのAPIの 認証 処理 ( Microsoft Cognitive Services ) - BEACHSIDE BLOG
 * http://beachside.hatenablog.com/entry/2017/01/27/123000
 */
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NetStandardLibrary
{
    public class AuthenticationToken : IDisposable
    {
        private const string TokenUri = @"https://api.cognitive.microsoft.com/sts/v1.0/issueToken";
        private static readonly HttpClient Client;

        static AuthenticationToken()
        {
            Client = new HttpClient();
        }

        public static async Task<string> GetBearerTokenAsync(string apiKey)
        {
            var token = await GetTokenAsync(apiKey);
            //"Bearer "を付与してリターンしてます。
            return $"Bearer {token}";
        }

        private static async Task<string> GetTokenAsync(string apiKey)
        {
            Client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", apiKey);
            var resuponse = await Client.PostAsync(TokenUri, new StringContent(string.Empty));
            return await resuponse.Content.ReadAsStringAsync();
        }

        public void Dispose()
        {
            //TODO Dispose support !
        }
    }
}
