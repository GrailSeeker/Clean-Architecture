using StudentManagementDemo.Core.Application.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementDemo.Core.Application.Common.Interfaces
{
    public interface INotificationService
    {
        Task Notify(MessageDto message);
    }
}
