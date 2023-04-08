namespace StrawberryShake;

using Microsoft.Extensions.DependencyInjection;

/// <summary>
/// Extensions of <see cref="IServiceCollection"/> to facilitate generically typed operations.
/// </summary>
public static class OperationServiceCollectionExtensions
{
    public static IServiceCollection AddOperation(
        this IServiceCollection services,
        string name,
        IDocument document)
    {
        throw new NotImplementedException();
    }
}
