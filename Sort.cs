namespace Repository
{
    using System;
    using System.Collections.Generic;

    public class Sort
    {
        private readonly IEnumerable<SortItem> _items;

        public Sort(IEnumerable<SortItem> items)
        {
            _items = Items ?? throw new ArgumentNullException(nameof(items));
        }

        public IEnumerable<SortItem> Items { get; }
    }
}
