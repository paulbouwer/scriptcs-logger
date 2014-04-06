using ScriptCs.Contracts;

namespace ScriptCs.Logger.ScriptPack
{
  public class LoggerScriptPack : IScriptPack
  {
    private readonly Logger _logger = new Logger();

    public IScriptPackContext GetContext()
    {
      return _logger;
    }

    public void Initialize(IScriptPackSession session)
    {
      var loggerContext = new LoggerContext { Arguments = session.ScriptArgs };
      _logger.SetContext(loggerContext);
    }

    public void Terminate() { }
  }
}
