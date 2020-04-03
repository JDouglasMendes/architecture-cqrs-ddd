using System;
using System.Collections.Generic;
using System.Text;

namespace DM.Domain.Shared.Events
{
    public interface IEventStore
    {
        void Save<T>(T theEvent) where T : Event;
    }
}
