namespace ConsoleApp11.State;

class ShippedState : OrderState
{
    public override void Handle(OrderContext orderContext)
    {
        //работает сервис доставки

        orderContext.OrderState = new CompleteState();
        orderContext.Handle();
    }
}