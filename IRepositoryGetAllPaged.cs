﻿namespace Repository
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IRespositoryGetAllPaged<T>
    {
        Task<(IEnumerable<T> result, RepositoryOutcomeAction outcomeAction, object error)> GetAllPagedAsync(Page page, Sort sort, CancellationToken cancellationToken = default(CancellationToken));
    }
}
