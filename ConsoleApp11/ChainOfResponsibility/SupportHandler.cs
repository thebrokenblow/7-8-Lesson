namespace ConsoleApp11.ChainOfResponsibility;

public abstract class SupportHandler : ISupportHandler
{
    protected ISupportHandler _nexHandler;

    public abstract void HandlerRequest(SupportRequest supportRequest);

    public ISupportHandler SetNextHandler(ISupportHandler nextHandler)
    {
        _nexHandler = nextHandler;

        return nextHandler;
    }
}
