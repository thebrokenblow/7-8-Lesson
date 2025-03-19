namespace ConsoleApp11.ChainOfResponsibility;

public class BasicSupportHandler : SupportHandler
{
    public override void HandlerRequest(SupportRequest supportRequest)
    {
        if (supportRequest.Complexity <= 1)
        {
            Console.WriteLine("Можем обработать");
        }
        else
        {
            _nexHandler.HandlerRequest(supportRequest);
        }
    }
}
