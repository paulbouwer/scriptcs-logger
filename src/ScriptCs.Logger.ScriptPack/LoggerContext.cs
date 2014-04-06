using System;
using System.Linq;

namespace ScriptCs.Logger.ScriptPack
{
  public class LoggerContext
  {
    public string[] Arguments { get; set; }

    public LogLevel GetLogLevel()
    {
      // Look for following pattern "-loglevel level". Example: -loglevel info
      if (Arguments.Count() == 2 && Arguments[0].Equals("-loglevel") && !String.IsNullOrEmpty(Arguments[1]))
      {
        LogLevel logLevel;
        if (Enum.TryParse(Arguments[1], true, out logLevel))
        {
          return logLevel;
        }
      }
      return LogLevel.Error;
    }
  }
}
