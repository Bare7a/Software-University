namespace _05.HTMLDispatcher.Interfaces
{
    public interface IElementBuilder
    {
        void AddAttribute(string attr, string value);

        void AddContent(string content);
    }
}