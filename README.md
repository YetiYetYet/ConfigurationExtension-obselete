# ✨ ConfigurationExtension ✨

This extension add some little methods that trow a ConfigurationMissingException when 
the return value of the method is null or when the section didn't exist.

## ⚙️ Usage
- For Connection String : 
```csharp
var connectionString = builder.Configuration.GetConnectionStringOrThrowIfNullOrEmpty("DefaultConnection");
//Instead of :
var connectionSting = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException();
```

- For Section value :
```csharp
var value = builder.Configuration.GetSectionValueOrThrowIfNullorEmpty("AppSettings:Token");
//Instead of :
var connectionSting = builder.Configuration.GetSection("AppSettings:Token").Value ?? throw new InvalidOperationException();
```
