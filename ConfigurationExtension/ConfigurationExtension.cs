using Microsoft.Extensions.Configuration;

namespace ConfiguationExtension;

public static class ConfigurationExtension
{
    /// <summary>
    /// Shorthand for GetSection("ConnectionStrings")[name].
    /// Throw an exception if the connection sting returned is NullOrEmpty.
    /// </summary>
    /// <param name="configuration">The configuration to enumerate.</param>
    /// <param name="name">The connection string key.</param>
    /// <exception cref="ConfigurationMissingException">
    /// Throw an exception if the connection sting returned is NullOrEmpty.</exception>
    /// <returns>The connection string.</returns>
    public static string GetConnectionStringOrThrowIfNullOrEmpty(this IConfiguration configuration, string name)
    {
        if(!configuration.GetSection("ConnectionStrings").Exists())
            throw new ConfigurationMissingException(
                $"There is no section \"ConnectionStrings\") on your configuration.");
        var connectionString = configuration.GetSection("ConnectionStrings")[name];
        if (string.IsNullOrEmpty(connectionString))
            throw new ConfigurationMissingException(
                $"No connection string defined for {name} on section ConnectionsStrings.");
        return connectionString;
    }
}