namespace SolidPrinciples._5_DIP;

public class AggregateLogger : ILogger
{
  private readonly FileLogger _fileLogger;
  private readonly DatabaseLogger _databaselogger;
  public AggregateLogger(FileLogger fileLogger, DatabaseLogger databaseLogger)
  {
    _fileLogger = fileLogger ?? throw new ArgumentNullException(nameof(fileLogger));
    _databaselogger = databaseLogger ?? throw new ArgumentNullException(nameof(databaseLogger));
  }

  public void Info(string message)
  {
    _fileLogger.Info(message);
    _databaselogger.Info(message);
  }
}
