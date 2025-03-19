namespace ConsoleApp11.State;

public abstract class OrderState
{
    public abstract void Handle(OrderContext orderContext);
}