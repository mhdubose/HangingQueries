namespace HangingQueries.Services;

public class Service : IService
{
    private readonly IOtherService _otherService;
    public Service(IOtherService otherService)
    {
        _otherService = otherService;
    }
    public string GetMessage()
    {
        var name = _otherService.GetName();
        return $"Hello {name}!";
    }
}