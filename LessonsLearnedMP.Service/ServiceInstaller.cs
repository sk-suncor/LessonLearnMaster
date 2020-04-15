using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;

namespace Suncor.LessonsLearnedMP.Service
{
    [RunInstaller(true)]
    public partial class ServiceInstaller : Installer
    {
        //private readonly System.ServiceProcess.ServiceProcessInstaller _process;
        //private readonly System.ServiceProcess.ServiceInstaller _userRefreshService;
        private readonly System.Diagnostics.EventLogInstaller _servicesLogInstaller;
        public ServiceInstaller()
        {
            InitializeComponent();
            /**********************************************************************************************
                    Project: Cloud Surge Project
                    Author: Rajib Sikdar
                    Date: 7th April 2020
                    Purpose: Comment out this code can be seen later
                  * **********************************************************************************************

            _process = new System.ServiceProcess.ServiceProcessInstaller { Account = ServiceAccount.LocalSystem };

            _userRefreshService = new System.ServiceProcess.ServiceInstaller
            {
                ServiceName = UserRefreshInfo.WindowsServiceName,
                Description = UserRefreshInfo.WindowsServiceDescription,
                StartType = ServiceStartMode.Automatic
            };

            _servicesLogInstaller = new System.Diagnostics.EventLogInstaller
                                        {
                                            Log = "llmp_service",
                                            Source = "llmpmp_service"
                                        };

            Installers.Add(_process);
            Installers.Add(_servicesLogInstaller);
            Installers.Add(_userRefreshService);
            */
        }
    }
}
