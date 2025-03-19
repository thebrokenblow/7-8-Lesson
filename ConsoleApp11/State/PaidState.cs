namespace ConsoleApp11.State;

public class PaidState : OrderState
{
    public override void Handle(OrderContext orderContext)
    {
        //вызываем api банка для оплаты

        orderContext.OrderState = new ShippedState();
        orderContext.Handle();
    }
}
