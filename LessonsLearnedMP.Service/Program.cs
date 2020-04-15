using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using Suncor.LessonsLearnedMP.Service;

namespace Suncor.LessonsLearnedMP.Service
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] servicesToRun = new ServiceBase[] 
                                              { 
                                                  new UserRefresh() 
                                              };
            ServiceBase.Run(servicesToRun);
        }
    }
}
