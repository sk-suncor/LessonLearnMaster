using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Suncor.LessonsLearnedMP.Service
{
    public static class UserRefreshInfo
    {
        private const string _windowsServiceName = "LessonsLearnedMP User Refresh Manager";
        private const string _windowsServiceDescription = "Management task scheduler for refereshing User information for the Suncor Lessons Learned Application";

        public static string WindowsServiceName
        {
            get { return _windowsServiceName; }
        }

        public static string WindowsServiceDescription
        {
            get { return _windowsServiceDescription; }
        }
    }
}
