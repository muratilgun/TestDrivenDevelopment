using System;

namespace xUnitProject
{
    public class GuidGenerator
    {
        public Guid RandomGuid { get; } = Guid.NewGuid();
    }
}