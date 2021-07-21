using System;
namespace Data
{
    public class EntityNotTrackedException : InvalidOperationException
    {
        public EntityNotTrackedException(string message)
            : base(message)
        {
        }
    }
}
