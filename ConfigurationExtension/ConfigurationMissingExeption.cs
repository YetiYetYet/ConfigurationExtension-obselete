namespace ConfiguationExtension;

/// <summary>
/// Execption throwed when the configuration have a null or empty element.
/// </summary>
[Serializable]
public class ConfigurationMissingException : Exception
{
    public ConfigurationMissingException() { }
    
    public ConfigurationMissingException(string message) : base(message)  { }
    
    public ConfigurationMissingException(string message,Exception inner) : base(message, inner)  { }
}