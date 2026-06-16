namespace GameMode.Common;

/// <summary>
/// Represents the result of an operation that does not return a value.
/// </summary>
public ref struct Result
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Result"/> struct.
    /// </summary>
    public Result() { }

    /// <summary>
    /// Gets an optional message associated with the result.
    /// </summary>
    public string Message { get; private set; } = string.Empty;

    /// <summary>
    /// A value indicating that the result was successful.
    /// </summary>
    public bool IsSuccess { get; private set; } = false;

    /// <summary>
    /// A value that indicates that the result was a failure.
    /// </summary>
    public bool IsFailed => !IsSuccess;

    /// <summary>
    /// Creates a successful result.
    /// </summary>
    public static Result Success() => new() { IsSuccess = true };

    /// <summary>
    /// Creates a successful result with an associated message.
    /// </summary>
    /// <param name="message">The message associated with the result.</param>
    public static Result Success(string message) => new() 
    { 
        IsSuccess = true,
        Message = message 
    };

    /// <summary>
    /// Creates a failed result.
    /// </summary>
    public static Result Failure() => new();

    /// <summary>
    /// Creates a failed result with an associated message.
    /// </summary>
    /// <param name="message">The message associated with the result.</param>
    public static Result Failure(string message) => new() { Message = message };
}
