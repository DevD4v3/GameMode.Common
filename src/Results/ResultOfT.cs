namespace GameMode.Common;

/// <summary>
/// Represents the result of an operation that returns a value.
/// </summary>
/// <typeparam name="TValue">A value associated to the result.</typeparam>
public ref struct Result<TValue>
{
    private TValue _value;

    /// <summary>
    /// Initializes a new instance of the <see cref="Result"/> struct.
    /// </summary>
    public Result() { }

    /// <summary>
    /// Gets the value associated with the result.
    /// </summary>
    /// <exception cref="InvalidOperationException">
    /// when <see cref="Result.IsFailed"/> is true.
    /// </exception>
    public TValue Value
    {
        get
        {
            return IsSuccess ?
                _value :
                throw new InvalidOperationException("The value of a failure result can not be accessed.");
        }
        private set
        {
            _value = value;
        }
    }

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
    /// Creates a successful result containing the specified value.
    /// </summary>
    /// <param name="value">The value associated with the result.</param>
    public static Result<TValue> Success(TValue value) => new() 
    { 
        IsSuccess = true,
        Value = value 
    };

    /// <summary>
    /// Creates a successful result containing the specified value and message.
    /// </summary>
    /// <param name="value">The value associated with the result.</param>
    /// <param name="message">The message associated with the result.</param>
    public static Result<TValue> Success(TValue value, string message) => new()
    {
        IsSuccess = true,
        Value = value,
        Message = message
    };


    /// <summary>
    /// Creates a failed result.
    /// </summary>
    public static Result<TValue> Failure() => new();

    /// <summary>
    /// Creates a failed result with an associated message.
    /// </summary>
    /// <param name="message">The message associated with the result.</param>
    public static Result<TValue> Failure(string message) => new() { Message = message };
}
