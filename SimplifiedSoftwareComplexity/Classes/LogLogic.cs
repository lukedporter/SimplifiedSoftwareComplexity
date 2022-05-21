using SimplifiedSoftwareComplexity.Fundamentals;
using SimplifiedSoftwareComplexity.Fundamentals.Interfaces;
using SimplifiedSoftwareComplexity.Interfaces;

namespace SimplifiedSoftwareComplexity.Classes
{
    public class LogLogic : ILogLogic
    {
        //TODO: Need unit tests against this.
        //TODO: Enable decorators to hook into code context?
        //TODO: Implement async patterns.
        // It is the LogLogic's responsibility to retrieve LogLogicRecords, write to logging system, display Record properties and possibly translate them externally
        // to an IDisplay, and to implement basic textual informational as exception alerting and possibly handling.
        readonly string space = " ";
        readonly string comma = ",";
        readonly string period = ".";

        public bool Initializing { get; set; }

        public ILogLogicRecord LogLogicRecord { get; set; }

        public LogLogic(string methodName = "DefaultMethodName", string className = "DefaultClassName", string namespaceName = "DefaultNamespaceName", object? beginningParameters = null)
        {
            Initializing = true;
            LogLogicRecord = new LogLogicRecord();
            LogLogicRecord.LogRecord = new LogRecord(methodName, className, namespaceName, beginningParameters);
            string result = "Starting Method Name: " + LogLogicRecord.LogRecord.MethodName + comma + space + "Class Name: " + LogLogicRecord.LogRecord.ClassName + comma + space + "Namespace Name: " + LogLogicRecord.LogRecord.NamespaceName + comma + space + "Beginning Parameters: " + LogLogicRecord.LogRecord.BeginningParameters + period;
            OnNewMessage(result);
            Initializing = false;
        }
        public bool Write(string? message)
        {
            DateTime timestamp = DateTime.UtcNow;
            Console.WriteLine(timestamp + space + message);
            return true;
        }
        public bool Write(object? message)
        {
            DateTime timeNow = DateTime.UtcNow;
            dynamic? result = new object(); //TODO: Test this.
            result.Timestamp = timeNow;
            result.ObjectRecord = message;
            Console.WriteLine(result);
            return true;
        }
        public bool WriteFailure(dynamic? toWrite)
        {
            throw new NotImplementedException();
        }

        public void NotifyWriteFailure(dynamic? wasWrite)
        {
            throw new NotImplementedException();
        }

        public void OnNewMessage(string? newMessage = null)
        {
            if(newMessage != null)
            {
                LogLogicRecord.LogRecord.IsCurrentMessageString = false;
                Write(newMessage);
                if (!Initializing)
                {
                    LogLogicRecord.LogRecord.AddToPreviousMessages(LogLogicRecord.LogRecord.CurrentMessage);
                }
                LogLogicRecord.LogRecord.IsCurrentMessageString = true;
                LogLogicRecord.LogRecord.SetCurrentMessage(newMessage);
            }
            else
            {
                string result = "ExcelReadingApp.Classes namespace, LogWriter class, OnNewMessage(string?) method, newMessage parameter was set to null.";
                OnNewMessage(result);
            }
        }
        public void OnNewMessage(object? newMessage = null)
        {
            if (newMessage != null)
            {
                LogLogicRecord.LogRecord.IsCurrentMessageString = false;
                Write(newMessage);
                if (!Initializing)
                {
                    LogLogicRecord.LogRecord.AddToPreviousMessages(LogLogicRecord.LogRecord.CurrentMessage);
                }
                LogLogicRecord.LogRecord.IsCurrentMessageString = false;
                LogLogicRecord.LogRecord.SetCurrentMessage(newMessage);
            }
            else
            {
                string result = "ExcelReadingApp.Classes namespace, LogWriter class, OnNewMessage(object?) method, newMessage parameter was set to null.";
                OnNewMessage(result);
            }
        }

        public bool OnEndLog(object? endingParameters = null) // Do not call this logic after it has been called once.
        {
            LogLogicRecord.LogRecord.EndIncrement += 1;
            LogLogicRecord.LogRecord.EndingParameters = endingParameters;
            string result = "Ending Class Name: " + LogLogicRecord.LogRecord.ClassName + comma + space + "Method Name: " + LogLogicRecord.LogRecord.MethodName + comma + space + "Ending Parameters: " + LogLogicRecord.LogRecord.EndingParameters + period;
            OnNewMessage(result);
            LogLogicRecord.LogRecord.OnMethodEndCalled = true;

            DisplayAllRecordsToConsole();

            bool isArchived = false;
            bool isClean = false;

            isArchived = ArchiveRecord();
            if (isArchived)
            {
                isClean = Cleanup();
            }
            else
            {
                isArchived = HandleArchiveFailure();
            }
            if(isClean && isArchived)
            {
                LogLogicRecord.LogRecord.IsMethodEnd = true;
            }
            else
            {
                LogLogicRecord.LogRecord.IsMethodEnd = false;
            }
            return LogLogicRecord.LogRecord.IsMethodEnd;
        }

        public void DisplayAllRecordsToConsole() // TODO: Save this for IDisplay potentially.
        {

        }

        public bool ArchiveRecord()
        {
            return true;
        }
        public bool HandleArchiveFailure() // Dead letter pattern.
        {
            return true;
        }

        public bool Cleanup()
        {
            return true;
        }
    }
}
