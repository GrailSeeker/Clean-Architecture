using StudentManagementDemo.Core.Application.Common.Interfaces;
using StudentManagementDemo.Core.Application.Notifications;
using System.Threading.Tasks;

namespace StudentManagementDemo.Infrastructure.Services
{
    public class NotificationService : INotificationService
    {
        public Task Notify(MessageDto message)
        {
            return Task.CompletedTask;
        }
    }
}
