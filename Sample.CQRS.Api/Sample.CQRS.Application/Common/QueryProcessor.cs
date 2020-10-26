using System;
using System.Linq;
using Sample.CQRS.Core.Common;

namespace Sample.CQRS.Application.Common
{
    public class QueryProcessor : IQueryProcessor
    {
        private readonly IServiceProvider _serviceProvider;

        public QueryProcessor(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public TReturn Process<TReturn, TQuery>(TQuery query) where TQuery : IQuery
        {
            var commandHandlerType = typeof(IQueryHandler<TReturn,TQuery>);
            var targetHandlerInterface = AppDomain.CurrentDomain
                .GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .FirstOrDefault(t => commandHandlerType.IsAssignableFrom(t) && t.IsInterface);

            if (targetHandlerInterface is null)
                throw new Exception("Couldn't find TargetHandlerInterface");

            dynamic targetHandler = _serviceProvider.GetService(targetHandlerInterface);
            return targetHandler.Handle(query);
        }
    }
}