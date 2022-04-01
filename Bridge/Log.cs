namespace Bridge
{
    public class Log
    {
        protected ILogWriter _logWriter;
        public Log(ILogWriter logWriter)
        {
            _logWriter = logWriter;
        }
        public virtual void LogWrite()
        {
            _logWriter.LogWrite();
        }

    }
}