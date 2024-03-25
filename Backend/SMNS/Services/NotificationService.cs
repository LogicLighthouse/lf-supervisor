using SMNS.Models;
using System;
using System.Threading.Tasks;

namespace SMNS.Services
{
    public class NotificationService : INotificationService
    {
        public async Task ProcessNotificationRequestAsync(NotificationRequest request)
        {
            Console.WriteLine(
                $"Processing notification request: {request.FirstName} {request.LastName}, Email: {request.Email}, Phone: {request.PhoneNumber}, Supervisor: {request.Supervisor}"
            );
        }
    }
}
