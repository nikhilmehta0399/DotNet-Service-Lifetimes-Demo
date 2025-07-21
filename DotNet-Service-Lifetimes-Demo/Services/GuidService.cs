
using System;

namespace DotNet_Service_Lifetimes_Demo.Services
{
    public class GuidService : IGuidService
    {
        public Guid Id { get; } = Guid.NewGuid();
    }
}
