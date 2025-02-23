// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Extensions;

    /// <summary>SIM name and properties.</summary>
    public partial class SimNameAndProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISimNameAndProperties,
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISimNameAndPropertiesInternal
    {

        /// <summary>The Ki value for the SIM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public string AuthenticationKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISimPropertiesFormatInternal)Property).AuthenticationKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISimPropertiesFormatInternal)Property).AuthenticationKey = value ?? null; }

        /// <summary>
        /// An optional free-form text field that can be used to record the device type this SIM is associated with, for example 'Video
        /// camera'. The Azure portal allows SIMs to be grouped and filtered based on this value.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public string DeviceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ICommonSimPropertiesFormatInternal)Property).DeviceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ICommonSimPropertiesFormatInternal)Property).DeviceType = value ?? null; }

        /// <summary>The integrated circuit card ID (ICCID) for the SIM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public string IntegratedCircuitCardIdentifier { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ICommonSimPropertiesFormatInternal)Property).IntegratedCircuitCardIdentifier; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ICommonSimPropertiesFormatInternal)Property).IntegratedCircuitCardIdentifier = value ?? null; }

        /// <summary>The international mobile subscriber identity (IMSI) for the SIM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public string InternationalMobileSubscriberIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ICommonSimPropertiesFormatInternal)Property).InternationalMobileSubscriberIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ICommonSimPropertiesFormatInternal)Property).InternationalMobileSubscriberIdentity = value ; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISimPropertiesFormat Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISimNameAndPropertiesInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.SimPropertiesFormat()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISimNameAndPropertiesInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ICommonSimPropertiesFormatInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ICommonSimPropertiesFormatInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for SimPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISimPolicyResourceId Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISimNameAndPropertiesInternal.SimPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ICommonSimPropertiesFormatInternal)Property).SimPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ICommonSimPropertiesFormatInternal)Property).SimPolicy = value; }

        /// <summary>Internal Acessors for SimState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.SimState? Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISimNameAndPropertiesInternal.SimState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ICommonSimPropertiesFormatInternal)Property).SimState; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ICommonSimPropertiesFormatInternal)Property).SimState = value; }

        /// <summary>Internal Acessors for SiteProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISiteProvisioning Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISimNameAndPropertiesInternal.SiteProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ICommonSimPropertiesFormatInternal)Property).SiteProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ICommonSimPropertiesFormatInternal)Property).SiteProvisioningState = value; }

        /// <summary>Internal Acessors for VendorKeyFingerprint</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISimNameAndPropertiesInternal.VendorKeyFingerprint { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ICommonSimPropertiesFormatInternal)Property).VendorKeyFingerprint; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ICommonSimPropertiesFormatInternal)Property).VendorKeyFingerprint = value; }

        /// <summary>Internal Acessors for VendorName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISimNameAndPropertiesInternal.VendorName { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ICommonSimPropertiesFormatInternal)Property).VendorName; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ICommonSimPropertiesFormatInternal)Property).VendorName = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the SIM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>The Opc value for the SIM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public string OperatorKeyCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISimPropertiesFormatInternal)Property).OperatorKeyCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISimPropertiesFormatInternal)Property).OperatorKeyCode = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISimPropertiesFormat _property;

        /// <summary>SIM Properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISimPropertiesFormat Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.SimPropertiesFormat()); set => this._property = value; }

        /// <summary>The provisioning state of the SIM resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ICommonSimPropertiesFormatInternal)Property).ProvisioningState; }

        /// <summary>SIM policy resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public string SimPolicyId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ICommonSimPropertiesFormatInternal)Property).SimPolicyId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ICommonSimPropertiesFormatInternal)Property).SimPolicyId = value ?? null; }

        /// <summary>The state of the SIM resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.SimState? SimState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ICommonSimPropertiesFormatInternal)Property).SimState; }

        /// <summary>A dictionary of sites to the provisioning state of this SIM on that site.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISiteProvisioning SiteProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ICommonSimPropertiesFormatInternal)Property).SiteProvisioningState; }

        /// <summary>
        /// A list of static IP addresses assigned to this SIM. Each address is assigned at a defined network scope, made up of {attached
        /// data network, slice}.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISimStaticIPProperties[] StaticIPConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ICommonSimPropertiesFormatInternal)Property).StaticIPConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ICommonSimPropertiesFormatInternal)Property).StaticIPConfiguration = value ?? null /* arrayOf */; }

        /// <summary>The public key fingerprint of the SIM vendor who provided this SIM, if any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public string VendorKeyFingerprint { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ICommonSimPropertiesFormatInternal)Property).VendorKeyFingerprint; }

        /// <summary>The name of the SIM vendor who provided this SIM, if any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public string VendorName { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ICommonSimPropertiesFormatInternal)Property).VendorName; }

        /// <summary>Creates an new <see cref="SimNameAndProperties" /> instance.</summary>
        public SimNameAndProperties()
        {

        }
    }
    /// SIM name and properties.
    public partial interface ISimNameAndProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.IJsonSerializable
    {
        /// <summary>The Ki value for the SIM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Ki value for the SIM.",
        SerializedName = @"authenticationKey",
        PossibleTypes = new [] { typeof(string) })]
        string AuthenticationKey { get; set; }
        /// <summary>
        /// An optional free-form text field that can be used to record the device type this SIM is associated with, for example 'Video
        /// camera'. The Azure portal allows SIMs to be grouped and filtered based on this value.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An optional free-form text field that can be used to record the device type this SIM is associated with, for example 'Video camera'. The Azure portal allows SIMs to be grouped and filtered based on this value.",
        SerializedName = @"deviceType",
        PossibleTypes = new [] { typeof(string) })]
        string DeviceType { get; set; }
        /// <summary>The integrated circuit card ID (ICCID) for the SIM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The integrated circuit card ID (ICCID) for the SIM.",
        SerializedName = @"integratedCircuitCardIdentifier",
        PossibleTypes = new [] { typeof(string) })]
        string IntegratedCircuitCardIdentifier { get; set; }
        /// <summary>The international mobile subscriber identity (IMSI) for the SIM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The international mobile subscriber identity (IMSI) for the SIM.",
        SerializedName = @"internationalMobileSubscriberIdentity",
        PossibleTypes = new [] { typeof(string) })]
        string InternationalMobileSubscriberIdentity { get; set; }
        /// <summary>The name of the SIM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the SIM.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The Opc value for the SIM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Opc value for the SIM.",
        SerializedName = @"operatorKeyCode",
        PossibleTypes = new [] { typeof(string) })]
        string OperatorKeyCode { get; set; }
        /// <summary>The provisioning state of the SIM resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the SIM resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>SIM policy resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"SIM policy resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string SimPolicyId { get; set; }
        /// <summary>The state of the SIM resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The state of the SIM resource.",
        SerializedName = @"simState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.SimState) })]
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.SimState? SimState { get;  }
        /// <summary>A dictionary of sites to the provisioning state of this SIM on that site.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A dictionary of sites to the provisioning state of this SIM on that site.",
        SerializedName = @"siteProvisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISiteProvisioning) })]
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISiteProvisioning SiteProvisioningState { get;  }
        /// <summary>
        /// A list of static IP addresses assigned to this SIM. Each address is assigned at a defined network scope, made up of {attached
        /// data network, slice}.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A list of static IP addresses assigned to this SIM. Each address is assigned at a defined network scope, made up of {attached data network, slice}.",
        SerializedName = @"staticIpConfiguration",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISimStaticIPProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISimStaticIPProperties[] StaticIPConfiguration { get; set; }
        /// <summary>The public key fingerprint of the SIM vendor who provided this SIM, if any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The public key fingerprint of the SIM vendor who provided this SIM, if any.",
        SerializedName = @"vendorKeyFingerprint",
        PossibleTypes = new [] { typeof(string) })]
        string VendorKeyFingerprint { get;  }
        /// <summary>The name of the SIM vendor who provided this SIM, if any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The name of the SIM vendor who provided this SIM, if any.",
        SerializedName = @"vendorName",
        PossibleTypes = new [] { typeof(string) })]
        string VendorName { get;  }

    }
    /// SIM name and properties.
    internal partial interface ISimNameAndPropertiesInternal

    {
        /// <summary>The Ki value for the SIM.</summary>
        string AuthenticationKey { get; set; }
        /// <summary>
        /// An optional free-form text field that can be used to record the device type this SIM is associated with, for example 'Video
        /// camera'. The Azure portal allows SIMs to be grouped and filtered based on this value.
        /// </summary>
        string DeviceType { get; set; }
        /// <summary>The integrated circuit card ID (ICCID) for the SIM.</summary>
        string IntegratedCircuitCardIdentifier { get; set; }
        /// <summary>The international mobile subscriber identity (IMSI) for the SIM.</summary>
        string InternationalMobileSubscriberIdentity { get; set; }
        /// <summary>The name of the SIM.</summary>
        string Name { get; set; }
        /// <summary>The Opc value for the SIM.</summary>
        string OperatorKeyCode { get; set; }
        /// <summary>SIM Properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISimPropertiesFormat Property { get; set; }
        /// <summary>The provisioning state of the SIM resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>
        /// The SIM policy used by this SIM. The SIM policy must be in the same location as the SIM.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISimPolicyResourceId SimPolicy { get; set; }
        /// <summary>SIM policy resource ID.</summary>
        string SimPolicyId { get; set; }
        /// <summary>The state of the SIM resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.SimState? SimState { get; set; }
        /// <summary>A dictionary of sites to the provisioning state of this SIM on that site.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISiteProvisioning SiteProvisioningState { get; set; }
        /// <summary>
        /// A list of static IP addresses assigned to this SIM. Each address is assigned at a defined network scope, made up of {attached
        /// data network, slice}.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISimStaticIPProperties[] StaticIPConfiguration { get; set; }
        /// <summary>The public key fingerprint of the SIM vendor who provided this SIM, if any.</summary>
        string VendorKeyFingerprint { get; set; }
        /// <summary>The name of the SIM vendor who provided this SIM, if any.</summary>
        string VendorName { get; set; }

    }
}