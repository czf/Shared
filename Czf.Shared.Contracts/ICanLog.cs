using System;

namespace Czf.Shared.Contracts
{
    public interface ICanLog
    {
        void Error(string message);
        void Error(Exception exception, string message = "");
        void Info(string message);
        void Warn(string message);
        void Debug(string message);
    }
}
