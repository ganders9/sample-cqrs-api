namespace Sample.CQRS.Core.Common
{
    public interface IQueryHandler<TReturn, TQuery> where TQuery : IQuery
    {
        TReturn Handle(TQuery query);
    }
}