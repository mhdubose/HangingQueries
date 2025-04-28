using HangingQueries.Services;

namespace HangingQueries.Types;

[QueryType]
public static class Query
{
    public static Message GetMessage(IService service) => new(service.GetMessage());
}
