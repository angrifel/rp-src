namespace Repository
{
    using System;

    public class Page
    {
        public Page(int size, int index)
        {
            if (size < 0) throw new ArgumentOutOfRangeException(nameof(size), size, "size cannot be negative");
            this.Size = size;
            this.Index = index;
        }
        
        public int Size { get; private set; }

        public int Index { get; private set; }
    }
}
