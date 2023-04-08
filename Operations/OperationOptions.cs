namespace StrawberryShake;

public class OperationOptions
{
    public IDocument? Document { get; set; }

    public IOperationStore? Store { get; set; }

    public RequestStrategy RequestStrategy { get; set; }

    public ExecutionStrategy ExecutionStrategy { get; set; } = ExecutionStrategy.NetworkOnly;
}

public class OperationOptions<TData>
    where TData : class
{
    public IConnection<TData>? Connection { get; set; }

    public IResultPatcher<TData>? Patcher { get; set; }
}

public class OperationOptions<TData, TResult>
    where TData : class
    where TResult : class
{
    public IOperationResultBuilder<TData, TResult>? Builder { get; set; }
}
