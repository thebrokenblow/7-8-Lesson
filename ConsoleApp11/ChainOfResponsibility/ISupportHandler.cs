namespace ConsoleApp11.ChainOfResponsibility;

public interface ISupportHandler
{
    void HandlerRequest(SupportRequest supportRequest);
    ISupportHandler SetNextHandler(ISupportHandler nextHandler);
}
