namespace Data
{
    using System;

    public class EmptyEntityException : InvalidOperationException
    {
        public EmptyEntityException()
            : base("Entity cannot be empty.")
        {
        }
    }
}
