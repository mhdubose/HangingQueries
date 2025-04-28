using HangingQueries.Services;

public class OtherService : IOtherService
{
    private readonly IService _service;

    public OtherService(IService service)
    {
        _service = service;
    }

    public string GetName()
    {
        return "World";
    }
}