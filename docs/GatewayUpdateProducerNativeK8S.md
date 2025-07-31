# akeyless.Model.GatewayUpdateProducerNativeK8S
gatewayUpdateProducerNativeK8S is a command that updates k8s producer [Deprecated: Use dynamic-secret-update-k8s command]

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomUsernameTemplate** | **string** | Customize how temporary usernames are generated using go template | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**K8sAllowedNamespaces** | **string** | Comma-separated list of allowed K8S namespaces for the generated ServiceAccount (relevant only for k8s-service-account-type&#x3D;dynamic) | [optional] 
**K8sClusterCaCert** | **string** | K8S cluster CA certificate | [optional] 
**K8sClusterEndpoint** | **string** | K8S cluster URL endpoint | [optional] 
**K8sClusterName** | **string** | K8S cluster name | [optional] 
**K8sClusterToken** | **string** | K8S cluster Bearer token | [optional] 
**K8sNamespace** | **string** | K8S Namespace where the ServiceAccount exists. | [optional] 
**K8sPredefinedRoleName** | **string** | The pre-existing Role or ClusterRole name to bind the generated ServiceAccount to (relevant only for k8s-service-account-type&#x3D;dynamic) | [optional] 
**K8sPredefinedRoleType** | **string** | Specifies the type of the pre-existing K8S role [Role, ClusterRole] (relevant only for k8s-service-account-type&#x3D;dynamic) | [optional] 
**K8sRolebindingYamlData** | **string** | Content of the yaml in a Base64 format. | [optional] 
**K8sRolebindingYamlDef** | **string** | Path to yaml file that contains definitions of K8S role and role binding (relevant only for k8s-service-account-type&#x3D;dynamic) | [optional] 
**K8sServiceAccount** | **string** | K8S ServiceAccount to extract token from. | [optional] 
**K8sServiceAccountType** | **string** | K8S ServiceAccount type [fixed, dynamic]. | [optional] 
**Name** | **string** | Dynamic secret name | 
**NewName** | **string** | Dynamic secret name | [optional] 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**SecureAccessAllowPortForwading** | **bool** | Enable Port forwarding while using CLI access | [optional] 
**SecureAccessBastionIssuer** | **string** | Deprecated. use secure-access-certificate-issuer | [optional] 
**SecureAccessCertificateIssuer** | **string** | Path to the SSH Certificate Issuer for your Akeyless Secure Access | [optional] 
**SecureAccessClusterEndpoint** | **string** | The K8s cluster endpoint URL | [optional] 
**SecureAccessDashboardUrl** | **string** | The K8s dashboard url | [optional] 
**SecureAccessDelay** | **long** | The delay duration, in seconds, to wait after generating just-in-time credentials. Accepted range: 0-120 seconds | [optional] 
**SecureAccessEnable** | **string** | Enable/Disable secure remote access [true/false] | [optional] 
**SecureAccessWeb** | **bool** | Enable Web Secure Remote Access | [optional] [default to false]
**SecureAccessWebBrowsing** | **bool** | Secure browser via Akeyless&#39;s Secure Remote Access (SRA) | [optional] [default to false]
**SecureAccessWebProxy** | **bool** | Web-Proxy via Akeyless&#39;s Secure Remote Access (SRA) | [optional] [default to false]
**Tags** | **List&lt;string&gt;** | Add tags attached to this object | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UseGwServiceAccount** | **bool** | Use the GW&#39;s service account | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

