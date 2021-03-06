namespace Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Runtime.PowerShell;

    /// <summary>
    /// Properties of RedisEnterprise clusters, as opposed to general resource properties like location, tags
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(ClusterPropertiesTypeConverter))]
    public partial class ClusterProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview.ClusterProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ClusterProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview.IClusterPropertiesInternal)this).MinimumTlsVersion = (string) content.GetValueForProperty("MinimumTlsVersion",((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview.IClusterPropertiesInternal)this).MinimumTlsVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview.IClusterPropertiesInternal)this).HostName = (string) content.GetValueForProperty("HostName",((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview.IClusterPropertiesInternal)this).HostName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview.IClusterPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview.IClusterPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview.IClusterPropertiesInternal)this).ResourceState = (Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ResourceState?) content.GetValueForProperty("ResourceState",((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview.IClusterPropertiesInternal)this).ResourceState, Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ResourceState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview.IClusterPropertiesInternal)this).RedisVersion = (string) content.GetValueForProperty("RedisVersion",((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview.IClusterPropertiesInternal)this).RedisVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview.IClusterPropertiesInternal)this).PrivateEndpointConnection = (Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api10.IPrivateEndpointConnection[]) content.GetValueForProperty("PrivateEndpointConnection",((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview.IClusterPropertiesInternal)this).PrivateEndpointConnection, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api10.IPrivateEndpointConnection>(__y, Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api10.PrivateEndpointConnectionTypeConverter.ConvertFrom));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview.ClusterProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ClusterProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview.IClusterPropertiesInternal)this).MinimumTlsVersion = (string) content.GetValueForProperty("MinimumTlsVersion",((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview.IClusterPropertiesInternal)this).MinimumTlsVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview.IClusterPropertiesInternal)this).HostName = (string) content.GetValueForProperty("HostName",((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview.IClusterPropertiesInternal)this).HostName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview.IClusterPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview.IClusterPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview.IClusterPropertiesInternal)this).ResourceState = (Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ResourceState?) content.GetValueForProperty("ResourceState",((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview.IClusterPropertiesInternal)this).ResourceState, Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ResourceState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview.IClusterPropertiesInternal)this).RedisVersion = (string) content.GetValueForProperty("RedisVersion",((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview.IClusterPropertiesInternal)this).RedisVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview.IClusterPropertiesInternal)this).PrivateEndpointConnection = (Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api10.IPrivateEndpointConnection[]) content.GetValueForProperty("PrivateEndpointConnection",((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview.IClusterPropertiesInternal)this).PrivateEndpointConnection, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api10.IPrivateEndpointConnection>(__y, Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api10.PrivateEndpointConnectionTypeConverter.ConvertFrom));
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview.ClusterProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview.IClusterProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview.IClusterProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ClusterProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview.ClusterProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview.IClusterProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview.IClusterProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ClusterProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ClusterProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20201001Preview.IClusterProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Properties of RedisEnterprise clusters, as opposed to general resource properties like location, tags
    [System.ComponentModel.TypeConverter(typeof(ClusterPropertiesTypeConverter))]
    public partial interface IClusterProperties

    {

    }
}