namespace Core.Utilities.Results
{
    //Begin for basic voids
    public interface IResult
    {
        bool IsSuccess { get; }
        string Message { get; }

    }
}
