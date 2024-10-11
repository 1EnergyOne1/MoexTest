using System.Net.Http;
using System.Threading.Tasks;

namespace MyApp
{
    class Program
    {
        static HttpClient client = new HttpClient();
        public static async Task Main()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://iss.moex.com/iss/securities.json?q=MOEX");
            var res = await client.SendAsync(request);
            Console.WriteLine("Эндпоинт https://iss.moex.com/iss/securities.xml?q=MOEX");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            // просматриваем данные ответа
            // статус
            Console.WriteLine($"Status: {res.StatusCode}\n");
            //заголовки
            Console.WriteLine("Headers");
            foreach (var header in res.Headers)
            {
                Console.Write($"{header.Key}:");
                foreach (var headerValue in header.Value)
                {
                    Console.WriteLine(headerValue);
                }
            }
            // содержимое ответа
            Console.WriteLine("\nContent");
            string content = await res.Content.ReadAsStringAsync();
            Console.WriteLine(content);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();



            using HttpRequestMessage requestSber = new HttpRequestMessage(HttpMethod.Get, "https://iss.moex.com/iss/history/engines/stock/markets/shares/boards/TQBR/securities/SBER.json");
            var resSber = await client.SendAsync(requestSber);
            Console.WriteLine("Эндпоинт (Вроде как акции Сбера за какой-то период) https://iss.moex.com/iss/history/engines/stock/markets/shares/boards/TQBR/securities/SBER.json");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            // просматриваем данные ответа
            // статус
            Console.WriteLine($"Status: {resSber.StatusCode}\n");
            //заголовки
            Console.WriteLine("Headers");
            foreach (var header in resSber.Headers)
            {
                Console.Write($"{header.Key}:");
                foreach (var headerValue in header.Value)
                {
                    Console.WriteLine(headerValue);
                }
            }
            // содержимое ответа
            Console.WriteLine("\nContent");
            string contentSber = await resSber.Content.ReadAsStringAsync();
            Console.WriteLine(contentSber);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();



            using HttpRequestMessage requestObligation = new HttpRequestMessage(HttpMethod.Get, "https://iss.moex.com/iss/history/engines/stock/markets/bonds/boards/TQCB/securities.json");
            var resObligation = await client.SendAsync(requestObligation);
            Console.WriteLine("Эндпоинт (Вроде как облигации за какой-то период) https://iss.moex.com/iss/history/engines/stock/markets/bonds/boards/TQCB/securities.json");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            // просматриваем данные ответа
            // статус
            Console.WriteLine($"Status: {resObligation.StatusCode}\n");
            //заголовки
            Console.WriteLine("Headers");
            foreach (var header in resObligation.Headers)
            {
                Console.Write($"{header.Key}:");
                foreach (var headerValue in header.Value)
                {
                    Console.WriteLine(headerValue);
                }
            }
            // содержимое ответа
            Console.WriteLine("\nContent");
            string contentObligation = await resObligation.Content.ReadAsStringAsync();
            Console.WriteLine(contentObligation);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}