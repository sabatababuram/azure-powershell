// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;

    public partial class SecurityCenterClient : ServiceClient<SecurityCenterClient>, ISecurityCenterClient, IAzureClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// Azure subscription ID
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// The location where ASC stores the data of the subscription. can be
        /// retrieved from Get locations
        /// </summary>
        public string AscLocation { get; set; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default value is
        /// 30.
        /// </summary>
        public int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When set to
        /// true a unique x-ms-client-request-id value is generated and included in
        /// each request. Default is true.
        /// </summary>
        public bool? GenerateClientRequestId { get; set; }

        /// <summary>
        /// Gets the IMdeOnboardingsOperations.
        /// </summary>
        public virtual IMdeOnboardingsOperations MdeOnboardings { get; private set; }

        /// <summary>
        /// Gets the ICustomAssessmentAutomationsOperations.
        /// </summary>
        public virtual ICustomAssessmentAutomationsOperations CustomAssessmentAutomations { get; private set; }

        /// <summary>
        /// Gets the ICustomEntityStoreAssignmentsOperations.
        /// </summary>
        public virtual ICustomEntityStoreAssignmentsOperations CustomEntityStoreAssignments { get; private set; }

        /// <summary>
        /// Gets the IComplianceResultsOperations.
        /// </summary>
        public virtual IComplianceResultsOperations ComplianceResults { get; private set; }

        /// <summary>
        /// Gets the IPricingsOperations.
        /// </summary>
        public virtual IPricingsOperations Pricings { get; private set; }

        /// <summary>
        /// Gets the IAdvancedThreatProtectionOperations.
        /// </summary>
        public virtual IAdvancedThreatProtectionOperations AdvancedThreatProtection { get; private set; }

        /// <summary>
        /// Gets the IDeviceSecurityGroupsOperations.
        /// </summary>
        public virtual IDeviceSecurityGroupsOperations DeviceSecurityGroups { get; private set; }

        /// <summary>
        /// Gets the IIotSecuritySolutionOperations.
        /// </summary>
        public virtual IIotSecuritySolutionOperations IotSecuritySolution { get; private set; }

        /// <summary>
        /// Gets the IIotSecuritySolutionAnalyticsOperations.
        /// </summary>
        public virtual IIotSecuritySolutionAnalyticsOperations IotSecuritySolutionAnalytics { get; private set; }

        /// <summary>
        /// Gets the IIotSecuritySolutionsAnalyticsAggregatedAlertOperations.
        /// </summary>
        public virtual IIotSecuritySolutionsAnalyticsAggregatedAlertOperations IotSecuritySolutionsAnalyticsAggregatedAlert { get; private set; }

        /// <summary>
        /// Gets the IIotSecuritySolutionsAnalyticsRecommendationOperations.
        /// </summary>
        public virtual IIotSecuritySolutionsAnalyticsRecommendationOperations IotSecuritySolutionsAnalyticsRecommendation { get; private set; }

        /// <summary>
        /// Gets the ILocationsOperations.
        /// </summary>
        public virtual ILocationsOperations Locations { get; private set; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        public virtual IOperations Operations { get; private set; }

        /// <summary>
        /// Gets the ITasksOperations.
        /// </summary>
        public virtual ITasksOperations Tasks { get; private set; }

        /// <summary>
        /// Gets the IAutoProvisioningSettingsOperations.
        /// </summary>
        public virtual IAutoProvisioningSettingsOperations AutoProvisioningSettings { get; private set; }

        /// <summary>
        /// Gets the ICompliancesOperations.
        /// </summary>
        public virtual ICompliancesOperations Compliances { get; private set; }

        /// <summary>
        /// Gets the IInformationProtectionPoliciesOperations.
        /// </summary>
        public virtual IInformationProtectionPoliciesOperations InformationProtectionPolicies { get; private set; }

        /// <summary>
        /// Gets the ISecurityContactsOperations.
        /// </summary>
        public virtual ISecurityContactsOperations SecurityContacts { get; private set; }

        /// <summary>
        /// Gets the IWorkspaceSettingsOperations.
        /// </summary>
        public virtual IWorkspaceSettingsOperations WorkspaceSettings { get; private set; }

        /// <summary>
        /// Gets the IRegulatoryComplianceStandardsOperations.
        /// </summary>
        public virtual IRegulatoryComplianceStandardsOperations RegulatoryComplianceStandards { get; private set; }

        /// <summary>
        /// Gets the IRegulatoryComplianceControlsOperations.
        /// </summary>
        public virtual IRegulatoryComplianceControlsOperations RegulatoryComplianceControls { get; private set; }

        /// <summary>
        /// Gets the IRegulatoryComplianceAssessmentsOperations.
        /// </summary>
        public virtual IRegulatoryComplianceAssessmentsOperations RegulatoryComplianceAssessments { get; private set; }

        /// <summary>
        /// Gets the ISubAssessmentsOperations.
        /// </summary>
        public virtual ISubAssessmentsOperations SubAssessments { get; private set; }

        /// <summary>
        /// Gets the IAutomationsOperations.
        /// </summary>
        public virtual IAutomationsOperations Automations { get; private set; }

        /// <summary>
        /// Gets the IAlertsSuppressionRulesOperations.
        /// </summary>
        public virtual IAlertsSuppressionRulesOperations AlertsSuppressionRules { get; private set; }

        /// <summary>
        /// Gets the IServerVulnerabilityAssessmentOperations.
        /// </summary>
        public virtual IServerVulnerabilityAssessmentOperations ServerVulnerabilityAssessment { get; private set; }

        /// <summary>
        /// Gets the IAssessmentsMetadataOperations.
        /// </summary>
        public virtual IAssessmentsMetadataOperations AssessmentsMetadata { get; private set; }

        /// <summary>
        /// Gets the IAssessmentsOperations.
        /// </summary>
        public virtual IAssessmentsOperations Assessments { get; private set; }

        /// <summary>
        /// Gets the IAdaptiveApplicationControlsOperations.
        /// </summary>
        public virtual IAdaptiveApplicationControlsOperations AdaptiveApplicationControls { get; private set; }

        /// <summary>
        /// Gets the IAdaptiveNetworkHardeningsOperations.
        /// </summary>
        public virtual IAdaptiveNetworkHardeningsOperations AdaptiveNetworkHardenings { get; private set; }

        /// <summary>
        /// Gets the IAllowedConnectionsOperations.
        /// </summary>
        public virtual IAllowedConnectionsOperations AllowedConnections { get; private set; }

        /// <summary>
        /// Gets the ITopologyOperations.
        /// </summary>
        public virtual ITopologyOperations Topology { get; private set; }

        /// <summary>
        /// Gets the IJitNetworkAccessPoliciesOperations.
        /// </summary>
        public virtual IJitNetworkAccessPoliciesOperations JitNetworkAccessPolicies { get; private set; }

        /// <summary>
        /// Gets the IDiscoveredSecuritySolutionsOperations.
        /// </summary>
        public virtual IDiscoveredSecuritySolutionsOperations DiscoveredSecuritySolutions { get; private set; }

        /// <summary>
        /// Gets the ISecuritySolutionsReferenceDataOperations.
        /// </summary>
        public virtual ISecuritySolutionsReferenceDataOperations SecuritySolutionsReferenceData { get; private set; }

        /// <summary>
        /// Gets the IExternalSecuritySolutionsOperations.
        /// </summary>
        public virtual IExternalSecuritySolutionsOperations ExternalSecuritySolutions { get; private set; }

        /// <summary>
        /// Gets the ISecureScoresOperations.
        /// </summary>
        public virtual ISecureScoresOperations SecureScores { get; private set; }

        /// <summary>
        /// Gets the ISecureScoreControlsOperations.
        /// </summary>
        public virtual ISecureScoreControlsOperations SecureScoreControls { get; private set; }

        /// <summary>
        /// Gets the ISecureScoreControlDefinitionsOperations.
        /// </summary>
        public virtual ISecureScoreControlDefinitionsOperations SecureScoreControlDefinitions { get; private set; }

        /// <summary>
        /// Gets the ISecuritySolutionsOperations.
        /// </summary>
        public virtual ISecuritySolutionsOperations SecuritySolutions { get; private set; }

        /// <summary>
        /// Gets the IConnectorsOperations.
        /// </summary>
        public virtual IConnectorsOperations Connectors { get; private set; }

        /// <summary>
        /// Gets the ISqlVulnerabilityAssessmentScansOperations.
        /// </summary>
        public virtual ISqlVulnerabilityAssessmentScansOperations SqlVulnerabilityAssessmentScans { get; private set; }

        /// <summary>
        /// Gets the ISqlVulnerabilityAssessmentScanResultsOperations.
        /// </summary>
        public virtual ISqlVulnerabilityAssessmentScanResultsOperations SqlVulnerabilityAssessmentScanResults { get; private set; }

        /// <summary>
        /// Gets the ISqlVulnerabilityAssessmentBaselineRulesOperations.
        /// </summary>
        public virtual ISqlVulnerabilityAssessmentBaselineRulesOperations SqlVulnerabilityAssessmentBaselineRules { get; private set; }

        /// <summary>
        /// Gets the IAlertsOperations.
        /// </summary>
        public virtual IAlertsOperations Alerts { get; private set; }

        /// <summary>
        /// Gets the ISettingsOperations.
        /// </summary>
        public virtual ISettingsOperations Settings { get; private set; }

        /// <summary>
        /// Gets the IIngestionSettingsOperations.
        /// </summary>
        public virtual IIngestionSettingsOperations IngestionSettings { get; private set; }

        /// <summary>
        /// Gets the ISoftwareInventoriesOperations.
        /// </summary>
        public virtual ISoftwareInventoriesOperations SoftwareInventories { get; private set; }

        /// <summary>
        /// Gets the ISecurityConnectorsOperations.
        /// </summary>
        public virtual ISecurityConnectorsOperations SecurityConnectors { get; private set; }

        /// <summary>
        /// Gets the IGovernanceRuleOperations.
        /// </summary>
        public virtual IGovernanceRuleOperations GovernanceRule { get; private set; }

        /// <summary>
        /// Gets the IGovernanceRulesOperations.
        /// </summary>
        public virtual IGovernanceRulesOperations GovernanceRules { get; private set; }

        /// <summary>
        /// Gets the ISecurityConnectorGovernanceRuleOperations.
        /// </summary>
        public virtual ISecurityConnectorGovernanceRuleOperations SecurityConnectorGovernanceRule { get; private set; }

        /// <summary>
        /// Gets the ISecurityConnectorGovernanceRulesOperations.
        /// </summary>
        public virtual ISecurityConnectorGovernanceRulesOperations SecurityConnectorGovernanceRules { get; private set; }

        /// <summary>
        /// Gets the ISubscriptionGovernanceRulesExecuteStatusOperations.
        /// </summary>
        public virtual ISubscriptionGovernanceRulesExecuteStatusOperations SubscriptionGovernanceRulesExecuteStatus { get; private set; }

        /// <summary>
        /// Gets the ISecurityConnectorGovernanceRulesExecuteStatusOperations.
        /// </summary>
        public virtual ISecurityConnectorGovernanceRulesExecuteStatusOperations SecurityConnectorGovernanceRulesExecuteStatus { get; private set; }

        /// <summary>
        /// Gets the IGovernanceAssignmentsOperations.
        /// </summary>
        public virtual IGovernanceAssignmentsOperations GovernanceAssignments { get; private set; }

        /// <summary>
        /// Gets the IApplicationsOperations.
        /// </summary>
        public virtual IApplicationsOperations Applications { get; private set; }

        /// <summary>
        /// Gets the IApplicationOperations.
        /// </summary>
        public virtual IApplicationOperations Application { get; private set; }

        /// <summary>
        /// Gets the ISecurityConnectorApplicationsOperations.
        /// </summary>
        public virtual ISecurityConnectorApplicationsOperations SecurityConnectorApplications { get; private set; }

        /// <summary>
        /// Gets the ISecurityConnectorApplicationOperations.
        /// </summary>
        public virtual ISecurityConnectorApplicationOperations SecurityConnectorApplication { get; private set; }

        /// <summary>
        /// Initializes a new instance of the SecurityCenterClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling SecurityCenterClient.Dispose(). False: will not dispose provided httpClient</param>
        protected SecurityCenterClient(HttpClient httpClient, bool disposeHttpClient) : base(httpClient, disposeHttpClient)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the SecurityCenterClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected SecurityCenterClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the SecurityCenterClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected SecurityCenterClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the SecurityCenterClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected SecurityCenterClient(System.Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the SecurityCenterClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected SecurityCenterClient(System.Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the SecurityCenterClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public SecurityCenterClient(ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the SecurityCenterClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling SecurityCenterClient.Dispose(). False: will not dispose provided httpClient</param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public SecurityCenterClient(ServiceClientCredentials credentials, HttpClient httpClient, bool disposeHttpClient) : this(httpClient, disposeHttpClient)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the SecurityCenterClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public SecurityCenterClient(ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the SecurityCenterClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public SecurityCenterClient(System.Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the SecurityCenterClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public SecurityCenterClient(System.Uri baseUri, ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        /// </summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            MdeOnboardings = new MdeOnboardingsOperations(this);
            CustomAssessmentAutomations = new CustomAssessmentAutomationsOperations(this);
            CustomEntityStoreAssignments = new CustomEntityStoreAssignmentsOperations(this);
            ComplianceResults = new ComplianceResultsOperations(this);
            Pricings = new PricingsOperations(this);
            AdvancedThreatProtection = new AdvancedThreatProtectionOperations(this);
            DeviceSecurityGroups = new DeviceSecurityGroupsOperations(this);
            IotSecuritySolution = new IotSecuritySolutionOperations(this);
            IotSecuritySolutionAnalytics = new IotSecuritySolutionAnalyticsOperations(this);
            IotSecuritySolutionsAnalyticsAggregatedAlert = new IotSecuritySolutionsAnalyticsAggregatedAlertOperations(this);
            IotSecuritySolutionsAnalyticsRecommendation = new IotSecuritySolutionsAnalyticsRecommendationOperations(this);
            Locations = new LocationsOperations(this);
            Operations = new Operations(this);
            Tasks = new TasksOperations(this);
            AutoProvisioningSettings = new AutoProvisioningSettingsOperations(this);
            Compliances = new CompliancesOperations(this);
            InformationProtectionPolicies = new InformationProtectionPoliciesOperations(this);
            SecurityContacts = new SecurityContactsOperations(this);
            WorkspaceSettings = new WorkspaceSettingsOperations(this);
            RegulatoryComplianceStandards = new RegulatoryComplianceStandardsOperations(this);
            RegulatoryComplianceControls = new RegulatoryComplianceControlsOperations(this);
            RegulatoryComplianceAssessments = new RegulatoryComplianceAssessmentsOperations(this);
            SubAssessments = new SubAssessmentsOperations(this);
            Automations = new AutomationsOperations(this);
            AlertsSuppressionRules = new AlertsSuppressionRulesOperations(this);
            ServerVulnerabilityAssessment = new ServerVulnerabilityAssessmentOperations(this);
            AssessmentsMetadata = new AssessmentsMetadataOperations(this);
            Assessments = new AssessmentsOperations(this);
            AdaptiveApplicationControls = new AdaptiveApplicationControlsOperations(this);
            AdaptiveNetworkHardenings = new AdaptiveNetworkHardeningsOperations(this);
            AllowedConnections = new AllowedConnectionsOperations(this);
            Topology = new TopologyOperations(this);
            JitNetworkAccessPolicies = new JitNetworkAccessPoliciesOperations(this);
            DiscoveredSecuritySolutions = new DiscoveredSecuritySolutionsOperations(this);
            SecuritySolutionsReferenceData = new SecuritySolutionsReferenceDataOperations(this);
            ExternalSecuritySolutions = new ExternalSecuritySolutionsOperations(this);
            SecureScores = new SecureScoresOperations(this);
            SecureScoreControls = new SecureScoreControlsOperations(this);
            SecureScoreControlDefinitions = new SecureScoreControlDefinitionsOperations(this);
            SecuritySolutions = new SecuritySolutionsOperations(this);
            Connectors = new ConnectorsOperations(this);
            SqlVulnerabilityAssessmentScans = new SqlVulnerabilityAssessmentScansOperations(this);
            SqlVulnerabilityAssessmentScanResults = new SqlVulnerabilityAssessmentScanResultsOperations(this);
            SqlVulnerabilityAssessmentBaselineRules = new SqlVulnerabilityAssessmentBaselineRulesOperations(this);
            Alerts = new AlertsOperations(this);
            Settings = new SettingsOperations(this);
            IngestionSettings = new IngestionSettingsOperations(this);
            SoftwareInventories = new SoftwareInventoriesOperations(this);
            SecurityConnectors = new SecurityConnectorsOperations(this);
            GovernanceRule = new GovernanceRuleOperations(this);
            GovernanceRules = new GovernanceRulesOperations(this);
            SecurityConnectorGovernanceRule = new SecurityConnectorGovernanceRuleOperations(this);
            SecurityConnectorGovernanceRules = new SecurityConnectorGovernanceRulesOperations(this);
            SubscriptionGovernanceRulesExecuteStatus = new SubscriptionGovernanceRulesExecuteStatusOperations(this);
            SecurityConnectorGovernanceRulesExecuteStatus = new SecurityConnectorGovernanceRulesExecuteStatusOperations(this);
            GovernanceAssignments = new GovernanceAssignmentsOperations(this);
            Applications = new ApplicationsOperations(this);
            Application = new ApplicationOperations(this);
            SecurityConnectorApplications = new SecurityConnectorApplicationsOperations(this);
            SecurityConnectorApplication = new SecurityConnectorApplicationOperations(this);
            BaseUri = new System.Uri("https://management.azure.com");
            AcceptLanguage = "en-US";
            LongRunningOperationRetryTimeout = 30;
            GenerateClientRequestId = true;
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<CustomAlertRule>("ruleType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<CustomAlertRule>("ruleType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<ResourceDetails>("source"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<ResourceDetails>("source"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<AdditionalData>("assessedResourceType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<AdditionalData>("assessedResourceType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<AutomationAction>("actionType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<AutomationAction>("actionType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<ExternalSecuritySolution>("kind"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<ExternalSecuritySolution>("kind"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<AuthenticationDetailsProperties>("authenticationType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<AuthenticationDetailsProperties>("authenticationType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<ResourceIdentifier>("type"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<ResourceIdentifier>("type"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<AlertSimulatorRequestProperties>("kind"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<AlertSimulatorRequestProperties>("kind"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<Setting>("kind"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<Setting>("kind"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<CloudOffering>("offeringType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<CloudOffering>("offeringType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<EnvironmentData>("environmentType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<EnvironmentData>("environmentType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<AwsOrganizationalData>("organizationMembershipType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<AwsOrganizationalData>("organizationMembershipType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<GcpOrganizationalData>("organizationMembershipType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<GcpOrganizationalData>("organizationMembershipType"));
            CustomInitialize();
            DeserializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings.Converters.Add(new CloudErrorJsonConverter());
        }
    }
}
