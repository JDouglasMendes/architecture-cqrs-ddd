using DM.Domain.Shared.Events;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace DM.Domain.Shared.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; private set; }
        public ValidationResult ValidationResult { get; set; }

        protected Command() => Timestamp = DateTime.Now;

        public abstract bool IsValid();
    }
}
