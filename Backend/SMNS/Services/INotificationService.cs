using SMNS.Models;
using System.Threading.Tasks;

namespace SMNS.Services
{
    public interface INotificationService
    {
        Task ProcessNotificationRequestAsync(NotificationRequest request);
    }
}
