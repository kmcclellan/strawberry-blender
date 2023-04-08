namespace StrawberryShake;

public interface INamedSubscription<TResult>
    where TResult : class
{
    string Name { get; }

    IObservable<IOperationResult<TResult>> Watch(IReadOnlyDictionary<string, object?>? variables = null);
}