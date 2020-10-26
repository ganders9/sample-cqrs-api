namespace Sample.CQRS.Core.Common
{
    public interface IQueryProcessor
    {
        TReturn Process<TReturn,TQuery>(TQuery query) where TQuery : IQuery;
    }
}