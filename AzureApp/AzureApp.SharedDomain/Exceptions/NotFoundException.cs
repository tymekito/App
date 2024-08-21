namespace AzureApp.SharedDomain.Exceptions
{
    public abstract class NotFoundException : Exception
    {
        public NotFoundException(string elementTypeName, string elementName)
            : base($"{elementTypeName} with {elementName} not found")
        {
        }
    }
}
