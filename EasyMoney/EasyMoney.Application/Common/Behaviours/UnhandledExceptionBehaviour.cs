using EasyMoney.Application.Common.Exceptions;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
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

                throw ex;
            }
        }

        private string GetFullLogMessage(TRequest request)
        {
            var requestType = typeof(TRequest);

            var requestFullName = requestType.FullName;
            //var values = GetRequestValues(request, requestType);
            //if (values.Count == 0)
            //{
            //    return GetMessage(requestFullName, "No parameters");
            //}
            var displayValue = string.Join(Environment.NewLine, request.ToString());

            return GetMessage(requestFullName, displayValue);
        }

        private Dictionary<string, string> GetRequestValues(TRequest request, Type requestType)
        {

            var dictionary = new Dictionary<string, string>();
            MapToDictionaryInternal(dictionary, request);

            //var values = requestType.GetProperties().ToDictionary(x => x.Name, y => y.GetValue(request).ToString());
            return dictionary;
        }


        private void MapToDictionaryInternal(Dictionary<string, string> dictionary, object obj)
        {
            if (obj == null)
            {
                return;
            }
            var objType = obj.GetType();
            if (objType.Namespace == "System")
            {
                dictionary.Add(objType.Name, obj.ToString());
                return;
            }

            var properties = objType.GetProperties();
            foreach (var property in properties)
            {
                object propValue = property.GetValue(obj, null);
                var elems = propValue as IList;
                if (elems != null)
                {
                    foreach (var item in elems)
                    {
                        MapToDictionaryInternal(dictionary, item);
                    }
                }
                else
                {
                    // This will not cut-off System.Collections because of the first check
                    if (property.PropertyType.Assembly == objType.Assembly)
                    {
                        Console.WriteLine("{0}:", property.Name);

                        MapToDictionaryInternal(dictionary, propValue);
                    }
                    else
                    {
                        Console.WriteLine("{0}: {1}", property.Name, propValue);
                        dictionary.Add(property.Name, propValue.ToString());
                    }
                }
            }
            //var values = requestType.GetProperties().ToDictionary(x => x.Name, y => y.GetValue(request).ToString());
            //MapToDictionaryInternal(values, request, requestType);
        }

        private string GetMessage(string fullname, string requestParams)
        {
            return $"Unhandled Exception for Request {fullname}. \nParams:\n{requestParams}";
        }
    }
}
