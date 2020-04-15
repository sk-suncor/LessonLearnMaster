using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using Suncor.LessonsLearnedMP.Business;
using Suncor.LessonsLearnedMP.Framework;

namespace Suncor.LessonsLearnedMP.Service
{
    partial class UserRefresh : ServiceBase
    {
        private Timer _schedulerTimer;
        private static DateTime _lastRefresh;

        public UserRefresh()
        {
            Logger.Info("UserRefresh Service", "Service is starting...");
            InitializeComponent();
            _lastRefresh = DateTime.MinValue;
            base.ServiceName = UserRefreshInfo.WindowsServiceName;
        }

        protected override void OnStart(string[] args)
        {
            int interval = Utility.SafeGetAppConfigSetting("SchedulerPollIntervalInSeconds", 3600);

            TimerCallback timerDelegate = DoWork;
            _schedulerTimer = new Timer(timerDelegate, interval, 1000 * 30, interval * 1000);
        }

        protected override void OnStop()
        {
            Logger.Info("UserRefresh Service", "Service is stopping.");
            _schedulerTimer.Dispose();
        }

        private static void DoWork(object state)
        {
            try
            {
                var refreshAfterTime = new TimeSpan(Utility.SafeGetAppConfigSetting("SchedulerRefreshAfterHour", 1), 0, 0);

                Logger.Info("UserRefresh Service", "Checking if refresh is required...");
                Logger.Info("UserRefresh Service", string.Format("Last Refresh: {0}, Refresh at {1}:00 (24h)", _lastRefresh, refreshAfterTime.Hours));

                if (_lastRefresh == DateTime.MinValue
                    || (_lastRefresh.Day != DateTime.Now.Day //Make sure we only refresh once per day
                    && DateTime.Now.TimeOfDay > refreshAfterTime)) //Only refresh after the specified time (1 AM by default)
                {
                    Logger.Info("UserRefresh Service", "Refresh required, refreshing user table...");

                    _lastRefresh = DateTime.Now;
                    /**********************************************************************************************
                  Project: Cloud Surge Project
                  Author: Rajib Sikdar
                  Date: 14th April 2020
                  Purpose: Need to check runtime error in future
                * **********************************************************************************************/
                    LessonBusiness businessManager = new LessonBusiness();
                    businessManager.RefreshRoleUsersFromActiveDirectory();

                    Logger.Info("UserRefresh Service", "Refresh Completed.");
                }
                else
                {
                    Logger.Info("UserRefresh Service", "Refresh is not required.");
                }
            }
            catch (Exception ex)
            {
                Logger.Error("UserRefresh Service", ex.ToString());
            }
        }
    }
}
