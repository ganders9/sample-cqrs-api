using System;
using System.Linq;
using Sample.CQRS.Core.Common;

namespace Sample.CQRS.Application.Common
{
    public class CommandProcessor : ICommandProcessor
    {
        private readonly IServiceProvider _serviceProvider;

        public CommandProcessor(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void Process<TCommand>(TCommand command) where TCommand : ICommand
        {
            var commandHandlerType = typeof(ICommandHandler<TCommand>);
            var targetHandlerInterface = AppDomain.CurrentDomain
                .GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .FirstOrDefault(t => commandHandlerType.IsAssignableFrom(t) && t.IsInterface);

            if (targetHandlerInterface is null)
                throw new Exception("Couldn't find TargetHandlerInterface");

            dynamic targetHandler = _serviceProvider.GetService(targetHandlerInterface);
            targetHandler.Handle(command);
        }
    }
}