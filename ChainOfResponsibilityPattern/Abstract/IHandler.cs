namespace ChainOfResponsibilityPattern.Abstract;

public interface IHandler
{
    IHandler SetNext(IHandler handler);
    IBaseModel Handle(IBaseModel request);
}
