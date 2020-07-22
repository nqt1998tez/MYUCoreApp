using MYUCoreApp.Infrastructure.Enums;

namespace MYUCoreApp.Infrastructure.Interfaces
{
    public interface ISwitchable
    {
        Status Status { get; set; }
    }
}
