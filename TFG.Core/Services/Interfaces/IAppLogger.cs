namespace TFG.Core.Services.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using NLog;

    public interface IAppLogger
    {
        void Log(LogLevel level, string message);
        void LogException(LogLevel level, Exception ex);
        void LogException(LogLevel level, Exception ex, string message);
    }
}
