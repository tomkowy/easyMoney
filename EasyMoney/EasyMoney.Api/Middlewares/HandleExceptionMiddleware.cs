using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace EasyMoney.Api.Middlewares
{
    public class HandleExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        public HandleExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
