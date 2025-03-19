
namespace ConsoleApp11.Mediator;

public class Colleague2 : Colleague
{ 
    public Colleague2(MyMediator myMediator) : base(myMediator)
    {
    }

    public void Send(string message)
    {
        _mediator.Send(message, this);
    }

    public void Notify(string message)
    {
        
    }
}
