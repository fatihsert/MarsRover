namespace MarsRover.Parser
{
    public interface IInputParser<TModel>
        where TModel : class
    {
        TModel Parse(string value);

    }
}
