using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
public class RequestLoggingMiddleware
{
    private readonly RequestDelegate _next;

    public RequestLoggingMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task Invoke(HttpContext context)
    {
        // Log the request information
        var request = context.Request;
        var requestBodyStream = new MemoryStream();
        var originalRequestBody = request.Body;

        await request.Body.CopyToAsync(requestBodyStream);
        requestBodyStream.Seek(0, SeekOrigin.Begin);
        var requestBodyText = await new StreamReader(requestBodyStream).ReadToEndAsync();
        requestBodyStream.Seek(0, SeekOrigin.Begin);
        request.Body = requestBodyStream;

        // Log the request
        Console.WriteLine($"Request: {request.Method} {request.Path}{request.QueryString}");
        Console.WriteLine($"Request Body: {requestBodyText}");

        // Call the next middleware
        await _next(context);

    }
}