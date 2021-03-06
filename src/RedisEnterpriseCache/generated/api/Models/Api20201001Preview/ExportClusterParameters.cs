namespace Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Runtime.Extensions;

    /// <summary>Parameters for a Redis Enterprise export operation.</summary>
    public partial class ExportClusterParameters :
        Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview.IExportClusterParameters,
        Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview.IExportClusterParametersInternal
    {

        /// <summary>Backing field for <see cref="SasUri" /> property.</summary>
        private string _sasUri;

        /// <summary>SAS Uri for the target directory to export to</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Origin(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.PropertyOrigin.Owned)]
        public string SasUri { get => this._sasUri; set => this._sasUri = value; }

        /// <summary>Creates an new <see cref="ExportClusterParameters" /> instance.</summary>
        public ExportClusterParameters()
        {

        }
    }
    /// Parameters for a Redis Enterprise export operation.
    public partial interface IExportClusterParameters :
        Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Runtime.IJsonSerializable
    {
        /// <summary>SAS Uri for the target directory to export to</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"SAS Uri for the target directory to export to",
        SerializedName = @"sasUri",
        PossibleTypes = new [] { typeof(string) })]
        string SasUri { get; set; }

    }
    /// Parameters for a Redis Enterprise export operation.
    internal partial interface IExportClusterParametersInternal

    {
        /// <summary>SAS Uri for the target directory to export to</summary>
        string SasUri { get; set; }

    }
}