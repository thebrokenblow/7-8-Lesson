﻿namespace ConsoleApp11.State;

public class OrderContext
{
    public OrderState OrderState { get; set; }

    public OrderContext()
    {
        OrderState = new CreateOrder();
    }

    public void Handle()
    {
        OrderState.Handle(this);
    }
}