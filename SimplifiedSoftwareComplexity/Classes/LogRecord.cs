using SimplifiedSoftwareComplexity.Fundamentals;
using SimplifiedSoftwareComplexity.Fundamentals.Interfaces;
using SimplifiedSoftwareComplexity.Interfaces;

namespace SimplifiedSoftwareComplexity.Classes
{
    public class LogRecord : ILogRecord
    {
        public LogRecord(string? methodName = "DefaultMethodName", string? className = "DefaultClassName", string? namespaceName = "DefaultNamespaceName", object? beginningParameters = null)
        {
            MethodName = methodName;
            ClassName = className;
            NamespaceName = namespaceName;
            BeginningParameters = beginningParameters;
        }
        public string? ClassName
        {
            get
            {
                if (ClassName != null && ClassName != "")
                {
                    return ClassName;
                }
                else
                {
                    ClassName = "DefaultClassName";
                    return ClassName;
                }
            }
            set => ClassName = value;
        }
        public string? MethodName
        {
            get
            {
                if (MethodName != null && MethodName != "")
                {
                    return MethodName;
                }
                else
                {
                    MethodName = "DefaultMethodName";
                    return MethodName;
                }
            }
            set => MethodName = value;
        }
        public string? NamespaceName
        {
            get
            {
                if (NamespaceName != null && NamespaceName != "")
                {
                    return NamespaceName;
                }
                else
                {
                    NamespaceName = "DefaultNamespaceName";
                    return NamespaceName;
                }
            }
            set => NamespaceName = value;
        }
        public object? BeginningParameters { get; set; } //TODO: implement explicit display logic. Should probably be LogWriter though. //TODO: Maybe add null checker here.
        public object? EndingParameters { get; set; } //TODO: implement explicit display logic. Should probably LogWriter though.
        public bool IsCurrentMessageString { get; set; }

        public StringOrObject? CurrentMessage { get; set; }
        public bool ExistsCurrentMessage()
        {
            bool result = (CurrentMessage != null && CurrentMessage.isString != null) && (CurrentMessage.Str != null || CurrentMessage.Obj != null);
            return result;
        }

        public void SetCurrentMessage(string? currentMessage = null) //TODO: This does not need logic to check if a CurrentMessage already exists. Use LogWriter.
        {
            if (currentMessage != null)
            {
                CurrentMessage.Obj = null;
                CurrentMessage.Str = currentMessage;
                CurrentMessage.isString = true;
            }
            else
            {
                StringOrObject result = new StringOrObject("ExcelReadingApp.Classes namespace, LogRecord class, SetCurrentMessage(string) method, currentMessage parameter was set to null.");
                result.isString = true;
                CreateOrUpdatePreviousMessages(result);
            }

        }
        public void SetCurrentMessage(object? currentMessage = null)
        {
            if (currentMessage != null)
            {
                CurrentMessage.Str = null;
                CurrentMessage.Obj = currentMessage;
                CurrentMessage.isString = false;
            }
            else
            {
                StringOrObject result = new StringOrObject("LogRecord class, SetCurrentMessage(object) method, currentMessage parameter was set to null.");
                result.isString = true;
                PreviousMessages.Add(result);
            }
        }

        public void AddToPreviousMessages(StringOrObject lastCurrentMessage)
        {
            if (lastCurrentMessage.isString != null)
            {
                if (lastCurrentMessage.Str != null || lastCurrentMessage.Obj != null)
                {
                    PreviousMessages.Add(lastCurrentMessage);
                }
                else
                {
                    StringOrObject result = new StringOrObject("LogRecord class, AddToPreviousMessages method, StringOrObject class had nulls set for both the string and object parameters. Instantiate this class correctly.");
                    result.isString = true;
                    PreviousMessages.Add(result);
                }
            }
            else
            {
                StringOrObject result = new StringOrObject("LogRecord class, AddToPreviousMessages method, the isString parameter was null from the StringOrObject class. Instantiate this class correctly.");
                result.isString = true;
                PreviousMessages.Add(result);
            }
        }

        public List<StringOrObject>? PreviousMessages
        {
            get
            {
                if (PreviousMessages != null && PreviousMessages.Count > 0)
                {
                    return PreviousMessages;
                }
                else
                {
                    return null;
                }
            }
            set => PreviousMessages = value;
        }

        public int EndIncrement { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool OnMethodEndCalled { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsMethodEnd { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<string> AllMessages { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SessionIdSource { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SessionId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime StartTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime EndTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public TimeSpan Duration { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public long RelateId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool ExistsPreviousMessages()
        {
            bool result = PreviousMessages != null && PreviousMessages.Count > 0;
            return result;
        }
        public void CreateOrUpdatePreviousMessages(StringOrObject message)
        {
            if (ExistsPreviousMessages())
            {
                PreviousMessages.Add(message);
            }
            else
            {
                PreviousMessages = new List<StringOrObject>();
                PreviousMessages.Add(message);
            }
        }

        public bool Write(dynamic toWrite)
        {
            throw new NotImplementedException();
        }

        public bool WriteFailure(dynamic toWrite)
        {
            throw new NotImplementedException();
        }

        public void NotifyWriteFailure(dynamic wasWrite)
        {
            throw new NotImplementedException();
        }
    }
}
