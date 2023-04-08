namespace StrawberryShake;

public interface INamedOperation<TResult>
    where TResult : class
{
    string Name { get; }

    Task<IOperationResult<TResult>> ExecuteAsync(
        IReadOnlyDictionary<string, object?>? variables = null,
        CancellationToken cancellationToken = default);
}
