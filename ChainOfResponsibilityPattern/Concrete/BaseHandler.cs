using ChainOfResponsibilityPattern.Abstract;

namespace ChainOfResponsibilityPatternPattern.Concrete;

public abstract class BaseHandler : IHandler
{
    private IHandler _nextHandler;

    public abstract IBaseModel Handle(IBaseModel request);

    public IHandler SetNext(IHandler handler)
    {
        _nextHandler = handler;
        return handler;
    }

    protected IBaseModel NextChain(IBaseModel request)
    {
        if (_nextHandler == null)
        {
            return request;
        }

        return _nextHandler.Handle(request);
    }
}
