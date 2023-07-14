namespace FileLoggerDisposableApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Use FileLogger and dispose of it properly
            FileLogger logger = new FileLogger("C:\\Users\\promact\\source\\repos\\four-weeks-training\\week-1\\day-5\\exercise-1\\FileLoggerDisposableApp\\Logs.txt");
            logger.Log("First Log!!");
            logger.Log("Second Log!!");
            logger.Log("Disposing!!");
            logger.Dispose();
            Console.ReadLine();
        }
    }

    class FileLogger : IDisposable
    {
        private StreamWriter _writer;
        private bool _disposed = false;
        public FileLogger(string filePath)
        {
            // Initialize StreamWriter instance
            _writer = new StreamWriter(filePath);
        }

        public void Dispose()
        {
            // Implement IDisposable pattern
           // _writer.Dispose();

            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                // TODO: dispose managed state (managed objects).
                _writer?.Dispose();
            }

            // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
            // TODO: set large fields to null.

            _disposed = true;
        }
        public void Log(string message)
        {
            // Write message to the file
            _writer?.WriteLine(message);    
        }
    }
}