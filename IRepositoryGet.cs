namespace Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IRepositoryGet<T>
    {
        Task<(IEnumerable<T> result, RepositoryOutcomeAction outcomeAction, object error)> GetAsync(Expression<Func<T, bool>> filter, Page page, Sort sort, CancellationToken cancellationToken = default(CancellationToken));
    }
}
