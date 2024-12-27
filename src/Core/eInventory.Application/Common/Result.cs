namespace eInventory.Application.Common;

public class Result<T>
{
    public bool IsSuccess { get; private set; }
    public T? Data { get; private set; }
    public List<string>? Errors { get; private set; }
    public string? Message { get; set; }

    public Result(bool isSuccess, T? data, List<string>? errors, string? message)
    {
        IsSuccess = isSuccess;
        Data = data;
        Errors = errors;
        Message = message;
    }

    public static Result<T> Success(T data, string? message)
    {
        return new Result<T>(true, data, null, message);
    }

    public static Result<T> Failure(List<string> errors, string? message)
    {
        return new Result<T>(false, default, errors, message);
    }
}
