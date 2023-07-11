using System.Diagnostics.CodeAnalysis;

namespace AzFunctionUnzip.Infrastructure.Settings
{
    [ExcludeFromCodeCoverage]
    public class SecretSettings
    {
        public string KeyVaultUri { get; set; }
        public string ZipPassword { get; set; }
    }
}
