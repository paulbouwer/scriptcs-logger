using System;
using ScriptCs.Contracts;

namespace ScriptCs.Logger.ScriptPack
{
  public class Logger : IScriptPackContext
  {
    private LogLevel _logLevel = LogLevel.Error;

    public void SetContext(LoggerContext loggerContext)
    {
      if (loggerContext != null)
      {
        _logLevel = loggerContext.GetLogLevel();
      }
    }

    public void Error(string message)
    {
      Write(LogLevel.Error, message, ConsoleColor.DarkRed, ConsoleColor.White);
    }

    public void Warn(string message)
    {
      Write(LogLevel.Warn, message, ConsoleColor.Yellow, ConsoleColor.Black);
    }

    public void Debug(string message)
    {
      Write(LogLevel.Debug, message, ConsoleColor.DarkGreen, ConsoleColor.White);
    }

    public void Info(string message)
    {
      Write(LogLevel.Info, message, ConsoleColor.Blue, ConsoleColor.White);
    }

    private void Write(LogLevel logLevel, string message, ConsoleColor backgroundcolor, ConsoleColor foregroundcolor)
    {
      if (logLevel > _logLevel) return;

      Console.ResetColor();
      Console.Write("[" + DateTime.Now.ToString("s") + "] ");
      Console.BackgroundColor = backgroundcolor;
      Console.ForegroundColor = foregroundcolor;
      Console.Write(" " + (Enum.GetName(typeof(LogLevel), logLevel) ?? "error").ToUpper() + " ");
      Console.ResetColor();
      Console.WriteLine(" " + message);
    }
  }
}
