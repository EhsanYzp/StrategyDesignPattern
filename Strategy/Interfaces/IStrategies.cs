namespace Interfaces
{
    /// <summary>
    /// General interface.
    /// All strategies implement this interface and its "Action" method.
    /// </summary>
    public interface IStrategies
    {
        /// <summary>
        /// Action method(implemented by all strategies)
        /// </summary>
        /// <param name="message">text to print</param>
        void Action(string message);
    }
}

