namespace ConsoleApp11.Mediator;

public abstract class Colleague
{
    protected MyMediator _mediator;

    public Colleague(MyMediator myMediator)
    {
        _mediator = myMediator;
    }
}
