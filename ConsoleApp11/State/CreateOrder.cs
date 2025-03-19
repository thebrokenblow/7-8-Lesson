namespace ConsoleApp11.State;

public class CreateOrder : OrderState
{
    public override void Handle(OrderContext orderContext)
    {
        orderContext.OrderState = new PaidState();
        orderContext.Handle();
    }
}