namespace Hare
{
    using System;

    public interface Target
    {
        bool On(Action<VirtualHostTarget> target);
    }
}