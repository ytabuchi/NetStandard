/* .NET Core does not support code page 932 a.k.a. Shift_JIS as default.
 * Please install "System.Text.Encoding.CodePages 4.3.0" from NuGet.
 */
using System;
using System.Xml.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace NetCoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //コンソールの入力をUTF8で受け取る？
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            Console.WriteLine("文章を入力してください：");
            var rowConsoleText = Console.ReadLine();

            var translatedText = DoTranslate(rowConsoleText).Result;
            Console.WriteLine(translatedText);
        }

        private static async Task<string> DoTranslate(string rowText)
        {
            var translatedText = await NetStandardLibrary.TranslateLib.TranslateTextAsync(rowText);
            return translatedText;
        }
    }
}