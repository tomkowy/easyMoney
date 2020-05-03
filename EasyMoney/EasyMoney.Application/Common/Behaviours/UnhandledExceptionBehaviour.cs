using EasyMoney.Application.Common.Exceptions;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EasyMoney.Application.Common.Behaviours
{
    public class UnhandledExceptionBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly ILogger<TRequest> _logger;

        public UnhandledExceptionBehaviour(ILogger<TRequest> logger)
        {
            _logger = logger;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            try
            {
                return await next();
            }
            catch (BusinessException)
            {
                throw;
            }
            catch (Exception ex)
            {
                var message = GetFullLogMessage(request);
                _logger.LogError(ex, message);

                throw;
            }
        }

        private string GetFullLogMessage(TRequest request)
        {
            var requestType = typeof(TRequest);

            var requestFullName = requestType.FullName;
            var values = GetRequestValues(request, requestType);
            if (values.Count == 0)
            {
                return GetMessage(requestFullName, "No parameters");
            }
            var displayValue = string.Join(Environment.NewLine, values);

            return GetMessage(requestFullName, displayValue);
        }

        private Dictionary<string, string> GetRequestValues(TRequest request, Type requestType)
        {
            var values = requestType.GetProperties().ToDictionary(x => x.Name, y => y.GetValue(request).ToString());
            return values;
        }

        private string GetMessage(string fullname, string requestParams)
        {
            return $"Unhandled Exception for Request {fullname}. \nParams:\n{requestParams}";
        }
    }
}
