using Amazon.Lambda.Core;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Net;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace LambdaTest;

public class LambdaHandler 
{
    public void handleRequest()
    {
        Console.WriteLine("Hello World, Lambda here");
    }
}
// namespace New_CS
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello, World!");
//         }
//     }
// }