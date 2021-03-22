# akeyless.Api.V2Api

All URIs are relative to *https://api.akeyless.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssocRoleAuthMethod**](V2Api.md#assocroleauthmethod) | **POST** /assoc-role-am | 
[**AssocTargetItem**](V2Api.md#assoctargetitem) | **POST** /assoc-target-item | 
[**Auth**](V2Api.md#auth) | **POST** /auth | 
[**Configure**](V2Api.md#configure) | **POST** /configure | 
[**CreateAuthMethod**](V2Api.md#createauthmethod) | **POST** /create-auth-method | 
[**CreateAuthMethodAWSIAM**](V2Api.md#createauthmethodawsiam) | **POST** /create-auth-method-aws-iam | 
[**CreateAuthMethodAzureAD**](V2Api.md#createauthmethodazuread) | **POST** /create-auth-method-azure-ad | 
[**CreateAuthMethodGCP**](V2Api.md#createauthmethodgcp) | **POST** /create-auth-method-gcp | 
[**CreateAuthMethodHuawei**](V2Api.md#createauthmethodhuawei) | **POST** /create-auth-method-huawei | 
[**CreateAuthMethodOAuth2**](V2Api.md#createauthmethodoauth2) | **POST** /create-auth-method-oauth2 | 
[**CreateAuthMethodSAML**](V2Api.md#createauthmethodsaml) | **POST** /create-auth-method-saml | 
[**CreateAuthMethodUniversalIdentity**](V2Api.md#createauthmethoduniversalidentity) | **POST** /create-auth-method-universal-identity | 
[**CreateAwsTarget**](V2Api.md#createawstarget) | **POST** /create-aws-target | 
[**CreateDBTarget**](V2Api.md#createdbtarget) | **POST** /create-db-target | 
[**CreateDynamicSecret**](V2Api.md#createdynamicsecret) | **POST** /create-dynamic-secret | 
[**CreateKey**](V2Api.md#createkey) | **POST** /create-key | 
[**CreatePKICertIssuer**](V2Api.md#createpkicertissuer) | **POST** /create-pki-cert-issuer | 
[**CreateRabbitMQTarget**](V2Api.md#createrabbitmqtarget) | **POST** /create-rabbitMQ-target | 
[**CreateRdpTarget**](V2Api.md#createrdptarget) | **POST** /create-rdp-target | 
[**CreateRole**](V2Api.md#createrole) | **POST** /create-role | 
[**CreateSSHCertIssuer**](V2Api.md#createsshcertissuer) | **POST** /create-ssh-cert-issuer | 
[**CreateSSHTarget**](V2Api.md#createsshtarget) | **POST** /create-ssh-target | 
[**CreateSecret**](V2Api.md#createsecret) | **POST** /create-secret | 
[**CreateTarget**](V2Api.md#createtarget) | **POST** /create-target | 
[**CreateWebTarget**](V2Api.md#createwebtarget) | **POST** /create-web-target | 
[**Decrypt**](V2Api.md#decrypt) | **POST** /decrypt | 
[**DecryptPKCS1**](V2Api.md#decryptpkcs1) | **POST** /decrypt-pkcs1 | 
[**DeleteAuthMethod**](V2Api.md#deleteauthmethod) | **POST** /delete-auth-method | 
[**DeleteAuthMethods**](V2Api.md#deleteauthmethods) | **POST** /delete-auth-methods | 
[**DeleteItem**](V2Api.md#deleteitem) | **POST** /delete-item | 
[**DeleteItems**](V2Api.md#deleteitems) | **POST** /delete-items | 
[**DeleteRole**](V2Api.md#deleterole) | **POST** /delete-role | 
[**DeleteRoleAssociation**](V2Api.md#deleteroleassociation) | **POST** /delete-assoc | 
[**DeleteRoleRule**](V2Api.md#deleterolerule) | **POST** /delete-role-rule | 
[**DeleteRoles**](V2Api.md#deleteroles) | **POST** /delete-roles | 
[**DeleteTarget**](V2Api.md#deletetarget) | **POST** /delete-target | 
[**DeleteTargetAssociation**](V2Api.md#deletetargetassociation) | **POST** /delete-assoc-target-item | 
[**DeleteTargets**](V2Api.md#deletetargets) | **POST** /delete-targets | 
[**DescribeItem**](V2Api.md#describeitem) | **POST** /describe-item | 
[**Encrypt**](V2Api.md#encrypt) | **POST** /encrypt | 
[**EncryptPKCS1**](V2Api.md#encryptpkcs1) | **POST** /encrypt-pkcs1 | 
[**GatewayAddSubAdmins**](V2Api.md#gatewayaddsubadmins) | **POST** /gateway-add-sub-admins | 
[**GatewayCreateProducerArtifactory**](V2Api.md#gatewaycreateproducerartifactory) | **POST** /gateway-create-producer-artifactory | 
[**GatewayCreateProducerAws**](V2Api.md#gatewaycreateproduceraws) | **POST** /gateway-create-producer-aws | 
[**GatewayCreateProducerAzure**](V2Api.md#gatewaycreateproducerazure) | **POST** /gateway-create-producer-azure | 
[**GatewayCreateProducerEks**](V2Api.md#gatewaycreateproducereks) | **POST** /gateway-create-producer-eks | 
[**GatewayCreateProducerGke**](V2Api.md#gatewaycreateproducergke) | **POST** /gateway-create-producer-gke | 
[**GatewayCreateProducerMSSQL**](V2Api.md#gatewaycreateproducermssql) | **POST** /gateway-create-producer-mssql | 
[**GatewayCreateProducerMongo**](V2Api.md#gatewaycreateproducermongo) | **POST** /gateway-create-producer-mongo | 
[**GatewayCreateProducerMySQL**](V2Api.md#gatewaycreateproducermysql) | **POST** /gateway-create-producer-mysql | 
[**GatewayCreateProducerPostgreSQL**](V2Api.md#gatewaycreateproducerpostgresql) | **POST** /gateway-create-producer-postgresql | 
[**GatewayCreateProducerRabbitMQ**](V2Api.md#gatewaycreateproducerrabbitmq) | **POST** /gateway-create-producer-rabbitmq | 
[**GatewayCreateProducerRdp**](V2Api.md#gatewaycreateproducerrdp) | **POST** /gateway-create-producer-rdp | 
[**GatewayCreateProducerVenafi**](V2Api.md#gatewaycreateproducervenafi) | **POST** /gateway-create-producer-venafi | 
[**GatewayDeleteProducer**](V2Api.md#gatewaydeleteproducer) | **POST** /gateway-delete-producer | 
[**GatewayDeleteSubAdmins**](V2Api.md#gatewaydeletesubadmins) | **POST** /gateway-delete-sub-admins | 
[**GatewayGetConfig**](V2Api.md#gatewaygetconfig) | **POST** /gateway-get-config | 
[**GatewayGetProducer**](V2Api.md#gatewaygetproducer) | **POST** /gateway-get-producer | 
[**GatewayGetTmpUsers**](V2Api.md#gatewaygettmpusers) | **POST** /gateway-get-producer-tmp-creds | 
[**GatewayListProducers**](V2Api.md#gatewaylistproducers) | **POST** /gateway-list-producers | 
[**GatewayListSubAdmins**](V2Api.md#gatewaylistsubadmins) | **POST** /gateway-list-SubAdmins | 
[**GatewayRevokeTmpUsers**](V2Api.md#gatewayrevoketmpusers) | **POST** /gateway-revoke-producer-tmp-creds | 
[**GatewayStartProducer**](V2Api.md#gatewaystartproducer) | **POST** /gateway-start-producer | 
[**GatewayStopProducer**](V2Api.md#gatewaystopproducer) | **POST** /gateway-stop-producer | 
[**GatewayUpdateTmpUsers**](V2Api.md#gatewayupdatetmpusers) | **POST** /gateway-update-producer-tmp-creds | 
[**GetAccountLogo**](V2Api.md#getaccountlogo) | **POST** /get-account-logo | 
[**GetAuthMethod**](V2Api.md#getauthmethod) | **POST** /get-auth-method | 
[**GetDynamicSecretValue**](V2Api.md#getdynamicsecretvalue) | **POST** /get-dynamic-secret-value | 
[**GetRSAPublic**](V2Api.md#getrsapublic) | **POST** /get-rsa-public | 
[**GetRole**](V2Api.md#getrole) | **POST** /get-role | 
[**GetSSHCertificate**](V2Api.md#getsshcertificate) | **POST** /get-ssh-certificate | 
[**GetSecretValue**](V2Api.md#getsecretvalue) | **POST** /get-secret-value | 
[**GetTarget**](V2Api.md#gettarget) | **POST** /get-target | 
[**GetTargetDetails**](V2Api.md#gettargetdetails) | **POST** /get-target-details | 
[**ListAuthMethods**](V2Api.md#listauthmethods) | **POST** /list-auth-methods | 
[**ListItems**](V2Api.md#listitems) | **POST** /list-items | 
[**ListRoles**](V2Api.md#listroles) | **POST** /list-roles | 
[**ListTargets**](V2Api.md#listtargets) | **POST** /list-targets | 
[**MoveObjects**](V2Api.md#moveobjects) | **POST** /move-objects | 
[**RawCreds**](V2Api.md#rawcreds) | **POST** /raw-creds | 
[**RefreshKey**](V2Api.md#refreshkey) | **POST** /refresh-key | 
[**ReverseRBAC**](V2Api.md#reverserbac) | **POST** /reverse-rbac | 
[**RollbackSecret**](V2Api.md#rollbacksecret) | **POST** /rollback-secret | 
[**RotateKey**](V2Api.md#rotatekey) | **POST** /rotate-key | 
[**SetItemState**](V2Api.md#setitemstate) | **POST** /set-item-state | 
[**SetRoleRule**](V2Api.md#setrolerule) | **POST** /set-role-rule | 
[**SignPKCS1**](V2Api.md#signpkcs1) | **POST** /sign-pkcs1 | 
[**StaticCredsAuth**](V2Api.md#staticcredsauth) | **POST** /static-creds-auth | 
[**UidCreateChildToken**](V2Api.md#uidcreatechildtoken) | **POST** /uid-create-child-token | 
[**UidGenerateToken**](V2Api.md#uidgeneratetoken) | **POST** /uid-generate-token | 
[**UidListChildren**](V2Api.md#uidlistchildren) | **POST** /uid-list-children | 
[**UidRevokeToken**](V2Api.md#uidrevoketoken) | **POST** /uid-revoke-token | 
[**UidRotateToken**](V2Api.md#uidrotatetoken) | **POST** /uid-rotate-token | 
[**UpdateAWSTargetDetails**](V2Api.md#updateawstargetdetails) | **POST** /update-aws-target-details | 
[**UpdateDBTargetDetails**](V2Api.md#updatedbtargetdetails) | **POST** /update-db-target-details | 
[**UpdateItem**](V2Api.md#updateitem) | **POST** /update-item | 
[**UpdateRDPTargetDetails**](V2Api.md#updaterdptargetdetails) | **POST** /update-rdp-target-details | 
[**UpdateRabbitMQTargetDetails**](V2Api.md#updaterabbitmqtargetdetails) | **POST** /update-rabbitmq-target-details | 
[**UpdateRole**](V2Api.md#updaterole) | **POST** /update-role | 
[**UpdateSSHTargetDetails**](V2Api.md#updatesshtargetdetails) | **POST** /update-ssh-target-details | 
[**UpdateSecretVal**](V2Api.md#updatesecretval) | **POST** /update-secret-val | 
[**UpdateTarget**](V2Api.md#updatetarget) | **POST** /update-target | 
[**UpdateTargetDetails**](V2Api.md#updatetargetdetails) | **POST** /update-target-details | 
[**UpdateWebTargetDetails**](V2Api.md#updatewebtargetdetails) | **POST** /update-web-target-details | 
[**UploadRSA**](V2Api.md#uploadrsa) | **POST** /upload-rsa | 
[**VerifyPKCS1**](V2Api.md#verifypkcs1) | **POST** /verify-pkcs1 | 


<a name="assocroleauthmethod"></a>
# **AssocRoleAuthMethod**
> CreateRoleAuthMethodAssocOutput AssocRoleAuthMethod (AssocRoleAuthMethod body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class AssocRoleAuthMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new AssocRoleAuthMethod(); // AssocRoleAuthMethod | 

            try
            {
                CreateRoleAuthMethodAssocOutput result = apiInstance.AssocRoleAuthMethod(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.AssocRoleAuthMethod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AssocRoleAuthMethod**](AssocRoleAuthMethod.md)|  | 

### Return type

[**CreateRoleAuthMethodAssocOutput**](CreateRoleAuthMethodAssocOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | assocRoleAuthMethodResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assoctargetitem"></a>
# **AssocTargetItem**
> CreateTargetItemAssocOutput AssocTargetItem (AssocTargetItem body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class AssocTargetItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new AssocTargetItem(); // AssocTargetItem | 

            try
            {
                CreateTargetItemAssocOutput result = apiInstance.AssocTargetItem(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.AssocTargetItem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AssocTargetItem**](AssocTargetItem.md)|  | 

### Return type

[**CreateTargetItemAssocOutput**](CreateTargetItemAssocOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | assocTargetItemResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="auth"></a>
# **Auth**
> AuthOutput Auth (Auth body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class AuthExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new Auth(); // Auth | 

            try
            {
                AuthOutput result = apiInstance.Auth(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.Auth: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Auth**](Auth.md)|  | 

### Return type

[**AuthOutput**](AuthOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | authResponse wraps response body. |  -  |
| **401** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configure"></a>
# **Configure**
> ConfigureOutput Configure (Configure body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class ConfigureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new Configure(); // Configure | 

            try
            {
                ConfigureOutput result = apiInstance.Configure(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.Configure: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Configure**](Configure.md)|  | 

### Return type

[**ConfigureOutput**](ConfigureOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | configureResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createauthmethod"></a>
# **CreateAuthMethod**
> CreateAuthMethodOutput CreateAuthMethod (CreateAuthMethod body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class CreateAuthMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new CreateAuthMethod(); // CreateAuthMethod | 

            try
            {
                CreateAuthMethodOutput result = apiInstance.CreateAuthMethod(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.CreateAuthMethod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateAuthMethod**](CreateAuthMethod.md)|  | 

### Return type

[**CreateAuthMethodOutput**](CreateAuthMethodOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | createAuthMethodResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createauthmethodawsiam"></a>
# **CreateAuthMethodAWSIAM**
> CreateAuthMethodAWSIAMOutput CreateAuthMethodAWSIAM (CreateAuthMethodAWSIAM body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class CreateAuthMethodAWSIAMExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new CreateAuthMethodAWSIAM(); // CreateAuthMethodAWSIAM | 

            try
            {
                CreateAuthMethodAWSIAMOutput result = apiInstance.CreateAuthMethodAWSIAM(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.CreateAuthMethodAWSIAM: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateAuthMethodAWSIAM**](CreateAuthMethodAWSIAM.md)|  | 

### Return type

[**CreateAuthMethodAWSIAMOutput**](CreateAuthMethodAWSIAMOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | createAuthMethodAWSIAMResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createauthmethodazuread"></a>
# **CreateAuthMethodAzureAD**
> CreateAuthMethodAzureADOutput CreateAuthMethodAzureAD (CreateAuthMethodAzureAD body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class CreateAuthMethodAzureADExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new CreateAuthMethodAzureAD(); // CreateAuthMethodAzureAD | 

            try
            {
                CreateAuthMethodAzureADOutput result = apiInstance.CreateAuthMethodAzureAD(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.CreateAuthMethodAzureAD: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateAuthMethodAzureAD**](CreateAuthMethodAzureAD.md)|  | 

### Return type

[**CreateAuthMethodAzureADOutput**](CreateAuthMethodAzureADOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | createAuthMethodAzureADResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createauthmethodgcp"></a>
# **CreateAuthMethodGCP**
> CreateAuthMethodGCPOutput CreateAuthMethodGCP (CreateAuthMethodGCP body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class CreateAuthMethodGCPExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new CreateAuthMethodGCP(); // CreateAuthMethodGCP | 

            try
            {
                CreateAuthMethodGCPOutput result = apiInstance.CreateAuthMethodGCP(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.CreateAuthMethodGCP: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateAuthMethodGCP**](CreateAuthMethodGCP.md)|  | 

### Return type

[**CreateAuthMethodGCPOutput**](CreateAuthMethodGCPOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | createAuthMethodGCPResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createauthmethodhuawei"></a>
# **CreateAuthMethodHuawei**
> CreateAuthMethodHuaweiOutput CreateAuthMethodHuawei (CreateAuthMethodHuawei body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class CreateAuthMethodHuaweiExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new CreateAuthMethodHuawei(); // CreateAuthMethodHuawei | 

            try
            {
                CreateAuthMethodHuaweiOutput result = apiInstance.CreateAuthMethodHuawei(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.CreateAuthMethodHuawei: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateAuthMethodHuawei**](CreateAuthMethodHuawei.md)|  | 

### Return type

[**CreateAuthMethodHuaweiOutput**](CreateAuthMethodHuaweiOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | createAuthMethodHuaweiResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createauthmethodoauth2"></a>
# **CreateAuthMethodOAuth2**
> CreateAuthMethodOAuth2Output CreateAuthMethodOAuth2 (CreateAuthMethodOAuth2 body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class CreateAuthMethodOAuth2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new CreateAuthMethodOAuth2(); // CreateAuthMethodOAuth2 | 

            try
            {
                CreateAuthMethodOAuth2Output result = apiInstance.CreateAuthMethodOAuth2(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.CreateAuthMethodOAuth2: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateAuthMethodOAuth2**](CreateAuthMethodOAuth2.md)|  | 

### Return type

[**CreateAuthMethodOAuth2Output**](CreateAuthMethodOAuth2Output.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | createAuthMethodOAuth2Response wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createauthmethodsaml"></a>
# **CreateAuthMethodSAML**
> CreateAuthMethodSAMLOutput CreateAuthMethodSAML (CreateAuthMethodSAML body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class CreateAuthMethodSAMLExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new CreateAuthMethodSAML(); // CreateAuthMethodSAML | 

            try
            {
                CreateAuthMethodSAMLOutput result = apiInstance.CreateAuthMethodSAML(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.CreateAuthMethodSAML: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateAuthMethodSAML**](CreateAuthMethodSAML.md)|  | 

### Return type

[**CreateAuthMethodSAMLOutput**](CreateAuthMethodSAMLOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | createAuthMethodSAMLResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createauthmethoduniversalidentity"></a>
# **CreateAuthMethodUniversalIdentity**
> CreateAuthMethodUniversalIdentityOutput CreateAuthMethodUniversalIdentity (CreateAuthMethodUniversalIdentity body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class CreateAuthMethodUniversalIdentityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new CreateAuthMethodUniversalIdentity(); // CreateAuthMethodUniversalIdentity | 

            try
            {
                CreateAuthMethodUniversalIdentityOutput result = apiInstance.CreateAuthMethodUniversalIdentity(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.CreateAuthMethodUniversalIdentity: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateAuthMethodUniversalIdentity**](CreateAuthMethodUniversalIdentity.md)|  | 

### Return type

[**CreateAuthMethodUniversalIdentityOutput**](CreateAuthMethodUniversalIdentityOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | createAuthMethodUniversalIdentityResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createawstarget"></a>
# **CreateAwsTarget**
> Object CreateAwsTarget (CreateAwsTarget body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class CreateAwsTargetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new CreateAwsTarget(); // CreateAwsTarget | 

            try
            {
                Object result = apiInstance.CreateAwsTarget(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.CreateAwsTarget: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateAwsTarget**](CreateAwsTarget.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | createTargetResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createdbtarget"></a>
# **CreateDBTarget**
> Object CreateDBTarget (CreateDBTarget body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class CreateDBTargetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new CreateDBTarget(); // CreateDBTarget | 

            try
            {
                Object result = apiInstance.CreateDBTarget(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.CreateDBTarget: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateDBTarget**](CreateDBTarget.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | createTargetResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createdynamicsecret"></a>
# **CreateDynamicSecret**
> Object CreateDynamicSecret (CreateDynamicSecret body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class CreateDynamicSecretExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new CreateDynamicSecret(); // CreateDynamicSecret | 

            try
            {
                Object result = apiInstance.CreateDynamicSecret(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.CreateDynamicSecret: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateDynamicSecret**](CreateDynamicSecret.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | createDynamicSecretResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createkey"></a>
# **CreateKey**
> CreateKeyOutput CreateKey (CreateKey body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class CreateKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new CreateKey(); // CreateKey | 

            try
            {
                CreateKeyOutput result = apiInstance.CreateKey(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.CreateKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateKey**](CreateKey.md)|  | 

### Return type

[**CreateKeyOutput**](CreateKeyOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | createKeyResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createpkicertissuer"></a>
# **CreatePKICertIssuer**
> CreatePKICertIssuerOutput CreatePKICertIssuer (CreatePKICertIssuer body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class CreatePKICertIssuerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new CreatePKICertIssuer(); // CreatePKICertIssuer | 

            try
            {
                CreatePKICertIssuerOutput result = apiInstance.CreatePKICertIssuer(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.CreatePKICertIssuer: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreatePKICertIssuer**](CreatePKICertIssuer.md)|  | 

### Return type

[**CreatePKICertIssuerOutput**](CreatePKICertIssuerOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | createPKICertIssuerResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrabbitmqtarget"></a>
# **CreateRabbitMQTarget**
> Object CreateRabbitMQTarget (CreateRabbitMQTarget body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class CreateRabbitMQTargetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new CreateRabbitMQTarget(); // CreateRabbitMQTarget | 

            try
            {
                Object result = apiInstance.CreateRabbitMQTarget(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.CreateRabbitMQTarget: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateRabbitMQTarget**](CreateRabbitMQTarget.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | createTargetResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrdptarget"></a>
# **CreateRdpTarget**
> Object CreateRdpTarget (CreateRdpTarget body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class CreateRdpTargetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new CreateRdpTarget(); // CreateRdpTarget | 

            try
            {
                Object result = apiInstance.CreateRdpTarget(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.CreateRdpTarget: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateRdpTarget**](CreateRdpTarget.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | createTargetResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrole"></a>
# **CreateRole**
> Object CreateRole (CreateRole body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class CreateRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new CreateRole(); // CreateRole | 

            try
            {
                Object result = apiInstance.CreateRole(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.CreateRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateRole**](CreateRole.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | createRoleResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsshcertissuer"></a>
# **CreateSSHCertIssuer**
> CreateSSHCertIssuerOutput CreateSSHCertIssuer (CreateSSHCertIssuer body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class CreateSSHCertIssuerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new CreateSSHCertIssuer(); // CreateSSHCertIssuer | 

            try
            {
                CreateSSHCertIssuerOutput result = apiInstance.CreateSSHCertIssuer(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.CreateSSHCertIssuer: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateSSHCertIssuer**](CreateSSHCertIssuer.md)|  | 

### Return type

[**CreateSSHCertIssuerOutput**](CreateSSHCertIssuerOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | createSSHCertIssuerResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsshtarget"></a>
# **CreateSSHTarget**
> Object CreateSSHTarget (CreateSSHTarget body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class CreateSSHTargetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new CreateSSHTarget(); // CreateSSHTarget | 

            try
            {
                Object result = apiInstance.CreateSSHTarget(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.CreateSSHTarget: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateSSHTarget**](CreateSSHTarget.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | createTargetResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsecret"></a>
# **CreateSecret**
> CreateSecretOutput CreateSecret (CreateSecret body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class CreateSecretExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new CreateSecret(); // CreateSecret | 

            try
            {
                CreateSecretOutput result = apiInstance.CreateSecret(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.CreateSecret: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateSecret**](CreateSecret.md)|  | 

### Return type

[**CreateSecretOutput**](CreateSecretOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | createSecretResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtarget"></a>
# **CreateTarget**
> Object CreateTarget (Object body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class CreateTargetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = ;  // Object | 

            try
            {
                Object result = apiInstance.CreateTarget(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.CreateTarget: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **Object**|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | createTargetResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createwebtarget"></a>
# **CreateWebTarget**
> Object CreateWebTarget (CreateWebTarget body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class CreateWebTargetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new CreateWebTarget(); // CreateWebTarget | 

            try
            {
                Object result = apiInstance.CreateWebTarget(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.CreateWebTarget: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateWebTarget**](CreateWebTarget.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | createTargetResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="decrypt"></a>
# **Decrypt**
> DecryptOutput Decrypt (Decrypt body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class DecryptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new Decrypt(); // Decrypt | 

            try
            {
                DecryptOutput result = apiInstance.Decrypt(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.Decrypt: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Decrypt**](Decrypt.md)|  | 

### Return type

[**DecryptOutput**](DecryptOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | decryptResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="decryptpkcs1"></a>
# **DecryptPKCS1**
> DecryptPKCS1Output DecryptPKCS1 (DecryptPKCS1 body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class DecryptPKCS1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new DecryptPKCS1(); // DecryptPKCS1 | 

            try
            {
                DecryptPKCS1Output result = apiInstance.DecryptPKCS1(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.DecryptPKCS1: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DecryptPKCS1**](DecryptPKCS1.md)|  | 

### Return type

[**DecryptPKCS1Output**](DecryptPKCS1Output.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | decryptPKCS1Response wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteauthmethod"></a>
# **DeleteAuthMethod**
> DeleteAuthMethodOutput DeleteAuthMethod (DeleteAuthMethod body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class DeleteAuthMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new DeleteAuthMethod(); // DeleteAuthMethod | 

            try
            {
                DeleteAuthMethodOutput result = apiInstance.DeleteAuthMethod(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.DeleteAuthMethod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeleteAuthMethod**](DeleteAuthMethod.md)|  | 

### Return type

[**DeleteAuthMethodOutput**](DeleteAuthMethodOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | deleteAuthMethodResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteauthmethods"></a>
# **DeleteAuthMethods**
> DeleteAuthMethodsOutput DeleteAuthMethods (DeleteAuthMethods body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class DeleteAuthMethodsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new DeleteAuthMethods(); // DeleteAuthMethods | 

            try
            {
                DeleteAuthMethodsOutput result = apiInstance.DeleteAuthMethods(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.DeleteAuthMethods: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeleteAuthMethods**](DeleteAuthMethods.md)|  | 

### Return type

[**DeleteAuthMethodsOutput**](DeleteAuthMethodsOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | deleteAuthMethodsResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitem"></a>
# **DeleteItem**
> DeleteItemOutput DeleteItem (DeleteItem body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class DeleteItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new DeleteItem(); // DeleteItem | 

            try
            {
                DeleteItemOutput result = apiInstance.DeleteItem(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.DeleteItem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeleteItem**](DeleteItem.md)|  | 

### Return type

[**DeleteItemOutput**](DeleteItemOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | deleteItemResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitems"></a>
# **DeleteItems**
> DeleteItemsOutput DeleteItems (DeleteItems body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class DeleteItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new DeleteItems(); // DeleteItems | 

            try
            {
                DeleteItemsOutput result = apiInstance.DeleteItems(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.DeleteItems: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeleteItems**](DeleteItems.md)|  | 

### Return type

[**DeleteItemsOutput**](DeleteItemsOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | deleteItemsResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterole"></a>
# **DeleteRole**
> Object DeleteRole (DeleteRole body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class DeleteRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new DeleteRole(); // DeleteRole | 

            try
            {
                Object result = apiInstance.DeleteRole(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.DeleteRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeleteRole**](DeleteRole.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | deleteRoleResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteroleassociation"></a>
# **DeleteRoleAssociation**
> Object DeleteRoleAssociation (DeleteRoleAssociation body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class DeleteRoleAssociationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new DeleteRoleAssociation(); // DeleteRoleAssociation | 

            try
            {
                Object result = apiInstance.DeleteRoleAssociation(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.DeleteRoleAssociation: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeleteRoleAssociation**](DeleteRoleAssociation.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | deleteRoleAssociationResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterolerule"></a>
# **DeleteRoleRule**
> DeleteRoleRuleOutput DeleteRoleRule (DeleteRoleRule body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class DeleteRoleRuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new DeleteRoleRule(); // DeleteRoleRule | 

            try
            {
                DeleteRoleRuleOutput result = apiInstance.DeleteRoleRule(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.DeleteRoleRule: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeleteRoleRule**](DeleteRoleRule.md)|  | 

### Return type

[**DeleteRoleRuleOutput**](DeleteRoleRuleOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | deleteRoleRuleResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteroles"></a>
# **DeleteRoles**
> Object DeleteRoles (DeleteRoles body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class DeleteRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new DeleteRoles(); // DeleteRoles | 

            try
            {
                Object result = apiInstance.DeleteRoles(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.DeleteRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeleteRoles**](DeleteRoles.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | deleteRolesResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetarget"></a>
# **DeleteTarget**
> Object DeleteTarget (DeleteTarget body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class DeleteTargetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new DeleteTarget(); // DeleteTarget | 

            try
            {
                Object result = apiInstance.DeleteTarget(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.DeleteTarget: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeleteTarget**](DeleteTarget.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | deleteTargetResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetargetassociation"></a>
# **DeleteTargetAssociation**
> Object DeleteTargetAssociation (DeleteTargetAssociation body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class DeleteTargetAssociationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new DeleteTargetAssociation(); // DeleteTargetAssociation | 

            try
            {
                Object result = apiInstance.DeleteTargetAssociation(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.DeleteTargetAssociation: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeleteTargetAssociation**](DeleteTargetAssociation.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | deleteTargetAssociationResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetargets"></a>
# **DeleteTargets**
> Object DeleteTargets (DeleteTargets body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class DeleteTargetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new DeleteTargets(); // DeleteTargets | 

            try
            {
                Object result = apiInstance.DeleteTargets(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.DeleteTargets: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeleteTargets**](DeleteTargets.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | deleteTargetsResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="describeitem"></a>
# **DescribeItem**
> Item DescribeItem (DescribeItem body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class DescribeItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new DescribeItem(); // DescribeItem | 

            try
            {
                Item result = apiInstance.DescribeItem(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.DescribeItem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DescribeItem**](DescribeItem.md)|  | 

### Return type

[**Item**](Item.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | describeItemResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="encrypt"></a>
# **Encrypt**
> EncryptOutput Encrypt (Encrypt body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class EncryptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new Encrypt(); // Encrypt | 

            try
            {
                EncryptOutput result = apiInstance.Encrypt(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.Encrypt: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Encrypt**](Encrypt.md)|  | 

### Return type

[**EncryptOutput**](EncryptOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | encryptResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="encryptpkcs1"></a>
# **EncryptPKCS1**
> EncryptPKCS1Output EncryptPKCS1 (EncryptPKCS1 body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class EncryptPKCS1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new EncryptPKCS1(); // EncryptPKCS1 | 

            try
            {
                EncryptPKCS1Output result = apiInstance.EncryptPKCS1(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.EncryptPKCS1: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EncryptPKCS1**](EncryptPKCS1.md)|  | 

### Return type

[**EncryptPKCS1Output**](EncryptPKCS1Output.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | encryptPKCS1Response wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gatewayaddsubadmins"></a>
# **GatewayAddSubAdmins**
> GatewayAddSubAdminsOutput GatewayAddSubAdmins (GatewayAddSubAdmins body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class GatewayAddSubAdminsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new GatewayAddSubAdmins(); // GatewayAddSubAdmins | 

            try
            {
                GatewayAddSubAdminsOutput result = apiInstance.GatewayAddSubAdmins(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GatewayAddSubAdmins: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GatewayAddSubAdmins**](GatewayAddSubAdmins.md)|  | 

### Return type

[**GatewayAddSubAdminsOutput**](GatewayAddSubAdminsOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | gatewayAddSubAdminsResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gatewaycreateproducerartifactory"></a>
# **GatewayCreateProducerArtifactory**
> GatewayCreateProducerArtifactoryOutput GatewayCreateProducerArtifactory (GatewayCreateProducerArtifactory body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class GatewayCreateProducerArtifactoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new GatewayCreateProducerArtifactory(); // GatewayCreateProducerArtifactory | 

            try
            {
                GatewayCreateProducerArtifactoryOutput result = apiInstance.GatewayCreateProducerArtifactory(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GatewayCreateProducerArtifactory: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GatewayCreateProducerArtifactory**](GatewayCreateProducerArtifactory.md)|  | 

### Return type

[**GatewayCreateProducerArtifactoryOutput**](GatewayCreateProducerArtifactoryOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | gatewayCreateProducerArtifactoryResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gatewaycreateproduceraws"></a>
# **GatewayCreateProducerAws**
> GatewayCreateProducerAwsOutput GatewayCreateProducerAws (GatewayCreateProducerAws body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class GatewayCreateProducerAwsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new GatewayCreateProducerAws(); // GatewayCreateProducerAws | 

            try
            {
                GatewayCreateProducerAwsOutput result = apiInstance.GatewayCreateProducerAws(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GatewayCreateProducerAws: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GatewayCreateProducerAws**](GatewayCreateProducerAws.md)|  | 

### Return type

[**GatewayCreateProducerAwsOutput**](GatewayCreateProducerAwsOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | gatewayCreateProducerAwsResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gatewaycreateproducerazure"></a>
# **GatewayCreateProducerAzure**
> GatewayCreateProducerAzureOutput GatewayCreateProducerAzure (GatewayCreateProducerAzure body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class GatewayCreateProducerAzureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new GatewayCreateProducerAzure(); // GatewayCreateProducerAzure | 

            try
            {
                GatewayCreateProducerAzureOutput result = apiInstance.GatewayCreateProducerAzure(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GatewayCreateProducerAzure: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GatewayCreateProducerAzure**](GatewayCreateProducerAzure.md)|  | 

### Return type

[**GatewayCreateProducerAzureOutput**](GatewayCreateProducerAzureOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | gatewayCreateProducerAzureResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gatewaycreateproducereks"></a>
# **GatewayCreateProducerEks**
> GatewayCreateProducerEksOutput GatewayCreateProducerEks (GatewayCreateProducerEks body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class GatewayCreateProducerEksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new GatewayCreateProducerEks(); // GatewayCreateProducerEks | 

            try
            {
                GatewayCreateProducerEksOutput result = apiInstance.GatewayCreateProducerEks(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GatewayCreateProducerEks: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GatewayCreateProducerEks**](GatewayCreateProducerEks.md)|  | 

### Return type

[**GatewayCreateProducerEksOutput**](GatewayCreateProducerEksOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | gatewayCreateProducerEksResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gatewaycreateproducergke"></a>
# **GatewayCreateProducerGke**
> GatewayCreateProducerGkeOutput GatewayCreateProducerGke (GatewayCreateProducerGke body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class GatewayCreateProducerGkeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new GatewayCreateProducerGke(); // GatewayCreateProducerGke | 

            try
            {
                GatewayCreateProducerGkeOutput result = apiInstance.GatewayCreateProducerGke(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GatewayCreateProducerGke: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GatewayCreateProducerGke**](GatewayCreateProducerGke.md)|  | 

### Return type

[**GatewayCreateProducerGkeOutput**](GatewayCreateProducerGkeOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | gatewayCreateProducerGkeResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gatewaycreateproducermssql"></a>
# **GatewayCreateProducerMSSQL**
> GatewayCreateProducerMSSQLOutput GatewayCreateProducerMSSQL (GatewayCreateProducerMSSQL body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class GatewayCreateProducerMSSQLExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new GatewayCreateProducerMSSQL(); // GatewayCreateProducerMSSQL | 

            try
            {
                GatewayCreateProducerMSSQLOutput result = apiInstance.GatewayCreateProducerMSSQL(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GatewayCreateProducerMSSQL: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GatewayCreateProducerMSSQL**](GatewayCreateProducerMSSQL.md)|  | 

### Return type

[**GatewayCreateProducerMSSQLOutput**](GatewayCreateProducerMSSQLOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | gatewayCreateProducerMSSQLResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gatewaycreateproducermongo"></a>
# **GatewayCreateProducerMongo**
> GatewayCreateProducerMongoOutput GatewayCreateProducerMongo (GatewayCreateProducerMongo body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class GatewayCreateProducerMongoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new GatewayCreateProducerMongo(); // GatewayCreateProducerMongo | 

            try
            {
                GatewayCreateProducerMongoOutput result = apiInstance.GatewayCreateProducerMongo(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GatewayCreateProducerMongo: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GatewayCreateProducerMongo**](GatewayCreateProducerMongo.md)|  | 

### Return type

[**GatewayCreateProducerMongoOutput**](GatewayCreateProducerMongoOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | gatewayCreateProducerMongoResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gatewaycreateproducermysql"></a>
# **GatewayCreateProducerMySQL**
> GatewayCreateProducerMySQLOutput GatewayCreateProducerMySQL (GatewayCreateProducerMySQL body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class GatewayCreateProducerMySQLExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new GatewayCreateProducerMySQL(); // GatewayCreateProducerMySQL | 

            try
            {
                GatewayCreateProducerMySQLOutput result = apiInstance.GatewayCreateProducerMySQL(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GatewayCreateProducerMySQL: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GatewayCreateProducerMySQL**](GatewayCreateProducerMySQL.md)|  | 

### Return type

[**GatewayCreateProducerMySQLOutput**](GatewayCreateProducerMySQLOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | gatewayCreateProducerMySQLResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gatewaycreateproducerpostgresql"></a>
# **GatewayCreateProducerPostgreSQL**
> GatewayCreateProducerPostgreSQLOutput GatewayCreateProducerPostgreSQL (GatewayCreateProducerPostgreSQL body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class GatewayCreateProducerPostgreSQLExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new GatewayCreateProducerPostgreSQL(); // GatewayCreateProducerPostgreSQL | 

            try
            {
                GatewayCreateProducerPostgreSQLOutput result = apiInstance.GatewayCreateProducerPostgreSQL(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GatewayCreateProducerPostgreSQL: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GatewayCreateProducerPostgreSQL**](GatewayCreateProducerPostgreSQL.md)|  | 

### Return type

[**GatewayCreateProducerPostgreSQLOutput**](GatewayCreateProducerPostgreSQLOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | gatewayCreateProducerPostgreSQLResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gatewaycreateproducerrabbitmq"></a>
# **GatewayCreateProducerRabbitMQ**
> GatewayCreateProducerRabbitMQOutput GatewayCreateProducerRabbitMQ (GatewayCreateProducerRabbitMQ body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class GatewayCreateProducerRabbitMQExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new GatewayCreateProducerRabbitMQ(); // GatewayCreateProducerRabbitMQ | 

            try
            {
                GatewayCreateProducerRabbitMQOutput result = apiInstance.GatewayCreateProducerRabbitMQ(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GatewayCreateProducerRabbitMQ: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GatewayCreateProducerRabbitMQ**](GatewayCreateProducerRabbitMQ.md)|  | 

### Return type

[**GatewayCreateProducerRabbitMQOutput**](GatewayCreateProducerRabbitMQOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | gatewayCreateProducerRabbitMQResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gatewaycreateproducerrdp"></a>
# **GatewayCreateProducerRdp**
> GatewayCreateProducerRdpOutput GatewayCreateProducerRdp (GatewayCreateProducerRdp body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class GatewayCreateProducerRdpExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new GatewayCreateProducerRdp(); // GatewayCreateProducerRdp | 

            try
            {
                GatewayCreateProducerRdpOutput result = apiInstance.GatewayCreateProducerRdp(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GatewayCreateProducerRdp: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GatewayCreateProducerRdp**](GatewayCreateProducerRdp.md)|  | 

### Return type

[**GatewayCreateProducerRdpOutput**](GatewayCreateProducerRdpOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | gatewayCreateProducerRdpResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gatewaycreateproducervenafi"></a>
# **GatewayCreateProducerVenafi**
> GatewayCreateProducerAwsOutput GatewayCreateProducerVenafi (GatewayCreateProducerAws body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class GatewayCreateProducerVenafiExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new GatewayCreateProducerAws(); // GatewayCreateProducerAws | 

            try
            {
                GatewayCreateProducerAwsOutput result = apiInstance.GatewayCreateProducerVenafi(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GatewayCreateProducerVenafi: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GatewayCreateProducerAws**](GatewayCreateProducerAws.md)|  | 

### Return type

[**GatewayCreateProducerAwsOutput**](GatewayCreateProducerAwsOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | gatewayCreateProducerVenafiResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gatewaydeleteproducer"></a>
# **GatewayDeleteProducer**
> GatewayDeleteProducerOutput GatewayDeleteProducer (GatewayDeleteProducer body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class GatewayDeleteProducerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new GatewayDeleteProducer(); // GatewayDeleteProducer | 

            try
            {
                GatewayDeleteProducerOutput result = apiInstance.GatewayDeleteProducer(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GatewayDeleteProducer: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GatewayDeleteProducer**](GatewayDeleteProducer.md)|  | 

### Return type

[**GatewayDeleteProducerOutput**](GatewayDeleteProducerOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | gatewayDeleteProducerResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gatewaydeletesubadmins"></a>
# **GatewayDeleteSubAdmins**
> GatewayDeleteSubAdminsOutput GatewayDeleteSubAdmins (GatewayDeleteSubAdmins body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class GatewayDeleteSubAdminsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new GatewayDeleteSubAdmins(); // GatewayDeleteSubAdmins | 

            try
            {
                GatewayDeleteSubAdminsOutput result = apiInstance.GatewayDeleteSubAdmins(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GatewayDeleteSubAdmins: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GatewayDeleteSubAdmins**](GatewayDeleteSubAdmins.md)|  | 

### Return type

[**GatewayDeleteSubAdminsOutput**](GatewayDeleteSubAdminsOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | gatewayDeleteSubAdminsResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gatewaygetconfig"></a>
# **GatewayGetConfig**
> AkeylessGatewayConfig GatewayGetConfig (GatewayGetConfig body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class GatewayGetConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new GatewayGetConfig(); // GatewayGetConfig | 

            try
            {
                AkeylessGatewayConfig result = apiInstance.GatewayGetConfig(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GatewayGetConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GatewayGetConfig**](GatewayGetConfig.md)|  | 

### Return type

[**AkeylessGatewayConfig**](AkeylessGatewayConfig.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | gatewayGetConfigResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gatewaygetproducer"></a>
# **GatewayGetProducer**
> DSProducerDetails GatewayGetProducer (GatewayGetProducer body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class GatewayGetProducerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new GatewayGetProducer(); // GatewayGetProducer | 

            try
            {
                DSProducerDetails result = apiInstance.GatewayGetProducer(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GatewayGetProducer: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GatewayGetProducer**](GatewayGetProducer.md)|  | 

### Return type

[**DSProducerDetails**](DSProducerDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | gatewayGetProducerResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gatewaygettmpusers"></a>
# **GatewayGetTmpUsers**
> List&lt;TmpUserData&gt; GatewayGetTmpUsers (GatewayGetTmpUsers body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class GatewayGetTmpUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new GatewayGetTmpUsers(); // GatewayGetTmpUsers | 

            try
            {
                List<TmpUserData> result = apiInstance.GatewayGetTmpUsers(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GatewayGetTmpUsers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GatewayGetTmpUsers**](GatewayGetTmpUsers.md)|  | 

### Return type

[**List&lt;TmpUserData&gt;**](TmpUserData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | gatewayGetTmpUsersResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gatewaylistproducers"></a>
# **GatewayListProducers**
> GetProducersListReplyObj GatewayListProducers (GatewayListProducers body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class GatewayListProducersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new GatewayListProducers(); // GatewayListProducers | 

            try
            {
                GetProducersListReplyObj result = apiInstance.GatewayListProducers(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GatewayListProducers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GatewayListProducers**](GatewayListProducers.md)|  | 

### Return type

[**GetProducersListReplyObj**](GetProducersListReplyObj.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | gatewayListProducersResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gatewaylistsubadmins"></a>
# **GatewayListSubAdmins**
> GetSubAdminsListReplyObj GatewayListSubAdmins (GatewayListSubAdmins body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class GatewayListSubAdminsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new GatewayListSubAdmins(); // GatewayListSubAdmins | 

            try
            {
                GetSubAdminsListReplyObj result = apiInstance.GatewayListSubAdmins(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GatewayListSubAdmins: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GatewayListSubAdmins**](GatewayListSubAdmins.md)|  | 

### Return type

[**GetSubAdminsListReplyObj**](GetSubAdminsListReplyObj.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | gatewayListSubAdminsResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gatewayrevoketmpusers"></a>
# **GatewayRevokeTmpUsers**
> void GatewayRevokeTmpUsers (GatewayRevokeTmpUsers body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class GatewayRevokeTmpUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new GatewayRevokeTmpUsers(); // GatewayRevokeTmpUsers | 

            try
            {
                apiInstance.GatewayRevokeTmpUsers(body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GatewayRevokeTmpUsers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GatewayRevokeTmpUsers**](GatewayRevokeTmpUsers.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | gatewayRevokeTmpUsersResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gatewaystartproducer"></a>
# **GatewayStartProducer**
> GatewayStartProducerOutput GatewayStartProducer (GatewayStartProducer body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class GatewayStartProducerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new GatewayStartProducer(); // GatewayStartProducer | 

            try
            {
                GatewayStartProducerOutput result = apiInstance.GatewayStartProducer(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GatewayStartProducer: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GatewayStartProducer**](GatewayStartProducer.md)|  | 

### Return type

[**GatewayStartProducerOutput**](GatewayStartProducerOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | gatewayStartProducerResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gatewaystopproducer"></a>
# **GatewayStopProducer**
> GatewayStopProducerOutput GatewayStopProducer (GatewayStopProducer body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class GatewayStopProducerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new GatewayStopProducer(); // GatewayStopProducer | 

            try
            {
                GatewayStopProducerOutput result = apiInstance.GatewayStopProducer(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GatewayStopProducer: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GatewayStopProducer**](GatewayStopProducer.md)|  | 

### Return type

[**GatewayStopProducerOutput**](GatewayStopProducerOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | gatewayStopProducerResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gatewayupdatetmpusers"></a>
# **GatewayUpdateTmpUsers**
> void GatewayUpdateTmpUsers (GatewayUpdateTmpUsers body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class GatewayUpdateTmpUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new GatewayUpdateTmpUsers(); // GatewayUpdateTmpUsers | 

            try
            {
                apiInstance.GatewayUpdateTmpUsers(body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GatewayUpdateTmpUsers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GatewayUpdateTmpUsers**](GatewayUpdateTmpUsers.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | gatewayUpdateTmpUsersResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccountlogo"></a>
# **GetAccountLogo**
> Dictionary&lt;string, string&gt; GetAccountLogo ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class GetAccountLogoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);

            try
            {
                Dictionary<string, string> result = apiInstance.GetAccountLogo();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetAccountLogo: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Dictionary<string, string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | getAccountLogoResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthmethod"></a>
# **GetAuthMethod**
> AuthMethod GetAuthMethod (GetAuthMethod body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class GetAuthMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new GetAuthMethod(); // GetAuthMethod | 

            try
            {
                AuthMethod result = apiInstance.GetAuthMethod(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetAuthMethod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GetAuthMethod**](GetAuthMethod.md)|  | 

### Return type

[**AuthMethod**](AuthMethod.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | getAuthMethodResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdynamicsecretvalue"></a>
# **GetDynamicSecretValue**
> Dictionary&lt;string, string&gt; GetDynamicSecretValue (GetDynamicSecretValue body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class GetDynamicSecretValueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new GetDynamicSecretValue(); // GetDynamicSecretValue | 

            try
            {
                Dictionary<string, string> result = apiInstance.GetDynamicSecretValue(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetDynamicSecretValue: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GetDynamicSecretValue**](GetDynamicSecretValue.md)|  | 

### Return type

**Dictionary<string, string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | getDynamicSecretValueResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrsapublic"></a>
# **GetRSAPublic**
> GetRSAPublicOutput GetRSAPublic (GetRSAPublic body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class GetRSAPublicExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new GetRSAPublic(); // GetRSAPublic | 

            try
            {
                GetRSAPublicOutput result = apiInstance.GetRSAPublic(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetRSAPublic: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GetRSAPublic**](GetRSAPublic.md)|  | 

### Return type

[**GetRSAPublicOutput**](GetRSAPublicOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | getRSAPublicResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrole"></a>
# **GetRole**
> Role GetRole (GetRole body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class GetRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new GetRole(); // GetRole | 

            try
            {
                Role result = apiInstance.GetRole(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GetRole**](GetRole.md)|  | 

### Return type

[**Role**](Role.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | getRoleResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsshcertificate"></a>
# **GetSSHCertificate**
> GetSSHCertificateOutput GetSSHCertificate (GetSSHCertificate body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class GetSSHCertificateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new GetSSHCertificate(); // GetSSHCertificate | 

            try
            {
                GetSSHCertificateOutput result = apiInstance.GetSSHCertificate(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetSSHCertificate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GetSSHCertificate**](GetSSHCertificate.md)|  | 

### Return type

[**GetSSHCertificateOutput**](GetSSHCertificateOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | getSSHCertificateResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsecretvalue"></a>
# **GetSecretValue**
> Dictionary&lt;string, string&gt; GetSecretValue (GetSecretValue body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class GetSecretValueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new GetSecretValue(); // GetSecretValue | 

            try
            {
                Dictionary<string, string> result = apiInstance.GetSecretValue(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetSecretValue: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GetSecretValue**](GetSecretValue.md)|  | 

### Return type

**Dictionary<string, string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | getSecretValueResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettarget"></a>
# **GetTarget**
> Target GetTarget (GetTarget body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class GetTargetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new GetTarget(); // GetTarget | 

            try
            {
                Target result = apiInstance.GetTarget(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetTarget: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GetTarget**](GetTarget.md)|  | 

### Return type

[**Target**](Target.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | getTargetResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettargetdetails"></a>
# **GetTargetDetails**
> GetTargetDetailsOutput GetTargetDetails (GetTargetDetails body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class GetTargetDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new GetTargetDetails(); // GetTargetDetails | 

            try
            {
                GetTargetDetailsOutput result = apiInstance.GetTargetDetails(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetTargetDetails: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GetTargetDetails**](GetTargetDetails.md)|  | 

### Return type

[**GetTargetDetailsOutput**](GetTargetDetailsOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | getTargetDetailsResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listauthmethods"></a>
# **ListAuthMethods**
> ListAuthMethodsOutput ListAuthMethods (ListAuthMethods body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class ListAuthMethodsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new ListAuthMethods(); // ListAuthMethods | 

            try
            {
                ListAuthMethodsOutput result = apiInstance.ListAuthMethods(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.ListAuthMethods: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ListAuthMethods**](ListAuthMethods.md)|  | 

### Return type

[**ListAuthMethodsOutput**](ListAuthMethodsOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | listAuthMethodsResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listitems"></a>
# **ListItems**
> ListItemsInPathOutput ListItems (ListItems body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class ListItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new ListItems(); // ListItems | 

            try
            {
                ListItemsInPathOutput result = apiInstance.ListItems(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.ListItems: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ListItems**](ListItems.md)|  | 

### Return type

[**ListItemsInPathOutput**](ListItemsInPathOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | listItemsResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listroles"></a>
# **ListRoles**
> ListRolesOutput ListRoles (ListRoles body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class ListRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new ListRoles(); // ListRoles | 

            try
            {
                ListRolesOutput result = apiInstance.ListRoles(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.ListRoles: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ListRoles**](ListRoles.md)|  | 

### Return type

[**ListRolesOutput**](ListRolesOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | listRolesResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtargets"></a>
# **ListTargets**
> ListTargetsOutput ListTargets (ListTargets body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class ListTargetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new ListTargets(); // ListTargets | 

            try
            {
                ListTargetsOutput result = apiInstance.ListTargets(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.ListTargets: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ListTargets**](ListTargets.md)|  | 

### Return type

[**ListTargetsOutput**](ListTargetsOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | listTargetsResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="moveobjects"></a>
# **MoveObjects**
> Object MoveObjects (MoveObjects body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class MoveObjectsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new MoveObjects(); // MoveObjects | 

            try
            {
                Object result = apiInstance.MoveObjects(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.MoveObjects: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MoveObjects**](MoveObjects.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | moveObjectsResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rawcreds"></a>
# **RawCreds**
> SystemAccessCredentialsReplyObj RawCreds (RawCreds body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class RawCredsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new RawCreds(); // RawCreds |  (optional) 

            try
            {
                SystemAccessCredentialsReplyObj result = apiInstance.RawCreds(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.RawCreds: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RawCreds**](RawCreds.md)|  | [optional] 

### Return type

[**SystemAccessCredentialsReplyObj**](SystemAccessCredentialsReplyObj.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | rawCredsResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="refreshkey"></a>
# **RefreshKey**
> RefreshKeyOutput RefreshKey (RefreshKey body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class RefreshKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new RefreshKey(); // RefreshKey | 

            try
            {
                RefreshKeyOutput result = apiInstance.RefreshKey(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.RefreshKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RefreshKey**](RefreshKey.md)|  | 

### Return type

[**RefreshKeyOutput**](RefreshKeyOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | refreshKeyResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reverserbac"></a>
# **ReverseRBAC**
> ReverseRBACOutput ReverseRBAC (ReverseRBAC body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class ReverseRBACExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new ReverseRBAC(); // ReverseRBAC | 

            try
            {
                ReverseRBACOutput result = apiInstance.ReverseRBAC(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.ReverseRBAC: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReverseRBAC**](ReverseRBAC.md)|  | 

### Return type

[**ReverseRBACOutput**](ReverseRBACOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | reverseRBACResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rollbacksecret"></a>
# **RollbackSecret**
> RollbackSecretOutput RollbackSecret (RollbackSecret body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class RollbackSecretExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new RollbackSecret(); // RollbackSecret | 

            try
            {
                RollbackSecretOutput result = apiInstance.RollbackSecret(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.RollbackSecret: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RollbackSecret**](RollbackSecret.md)|  | 

### Return type

[**RollbackSecretOutput**](RollbackSecretOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | rollbackSecretResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rotatekey"></a>
# **RotateKey**
> RotateKeyOutput RotateKey (RotateKey body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class RotateKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new RotateKey(); // RotateKey | 

            try
            {
                RotateKeyOutput result = apiInstance.RotateKey(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.RotateKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RotateKey**](RotateKey.md)|  | 

### Return type

[**RotateKeyOutput**](RotateKeyOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | rotateKeyResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setitemstate"></a>
# **SetItemState**
> Object SetItemState (SetItemState body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class SetItemStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new SetItemState(); // SetItemState | 

            try
            {
                Object result = apiInstance.SetItemState(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.SetItemState: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SetItemState**](SetItemState.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | setItemStateResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setrolerule"></a>
# **SetRoleRule**
> Object SetRoleRule (SetRoleRule body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class SetRoleRuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new SetRoleRule(); // SetRoleRule | 

            try
            {
                Object result = apiInstance.SetRoleRule(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.SetRoleRule: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SetRoleRule**](SetRoleRule.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | setRoleRuleResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signpkcs1"></a>
# **SignPKCS1**
> SignPKCS1Output SignPKCS1 (SignPKCS1 body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class SignPKCS1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new SignPKCS1(); // SignPKCS1 | 

            try
            {
                SignPKCS1Output result = apiInstance.SignPKCS1(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.SignPKCS1: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SignPKCS1**](SignPKCS1.md)|  | 

### Return type

[**SignPKCS1Output**](SignPKCS1Output.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | signPKCS1Response wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="staticcredsauth"></a>
# **StaticCredsAuth**
> StaticCredsAuthOutput StaticCredsAuth (StaticCredsAuth body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class StaticCredsAuthExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new StaticCredsAuth(); // StaticCredsAuth | 

            try
            {
                StaticCredsAuthOutput result = apiInstance.StaticCredsAuth(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.StaticCredsAuth: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**StaticCredsAuth**](StaticCredsAuth.md)|  | 

### Return type

[**StaticCredsAuthOutput**](StaticCredsAuthOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | staticCredsAuthResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uidcreatechildtoken"></a>
# **UidCreateChildToken**
> UidCreateChildTokenOutput UidCreateChildToken (UidCreateChildToken body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class UidCreateChildTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new UidCreateChildToken(); // UidCreateChildToken | 

            try
            {
                UidCreateChildTokenOutput result = apiInstance.UidCreateChildToken(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.UidCreateChildToken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UidCreateChildToken**](UidCreateChildToken.md)|  | 

### Return type

[**UidCreateChildTokenOutput**](UidCreateChildTokenOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | uidCreateChildTokenResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uidgeneratetoken"></a>
# **UidGenerateToken**
> UidGenerateTokenOutput UidGenerateToken (UidGenerateToken body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class UidGenerateTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new UidGenerateToken(); // UidGenerateToken | 

            try
            {
                UidGenerateTokenOutput result = apiInstance.UidGenerateToken(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.UidGenerateToken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UidGenerateToken**](UidGenerateToken.md)|  | 

### Return type

[**UidGenerateTokenOutput**](UidGenerateTokenOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | uidGenerateTokenResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uidlistchildren"></a>
# **UidListChildren**
> UniversalIdentityDetails UidListChildren (UidListChildren body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class UidListChildrenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new UidListChildren(); // UidListChildren | 

            try
            {
                UniversalIdentityDetails result = apiInstance.UidListChildren(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.UidListChildren: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UidListChildren**](UidListChildren.md)|  | 

### Return type

[**UniversalIdentityDetails**](UniversalIdentityDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | uidListChildrenResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uidrevoketoken"></a>
# **UidRevokeToken**
> Object UidRevokeToken (UidRevokeToken body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class UidRevokeTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new UidRevokeToken(); // UidRevokeToken | 

            try
            {
                Object result = apiInstance.UidRevokeToken(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.UidRevokeToken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UidRevokeToken**](UidRevokeToken.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | uidRevokeTokenResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uidrotatetoken"></a>
# **UidRotateToken**
> UidRotateTokenOutput UidRotateToken (UidRotateToken body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class UidRotateTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new UidRotateToken(); // UidRotateToken | 

            try
            {
                UidRotateTokenOutput result = apiInstance.UidRotateToken(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.UidRotateToken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UidRotateToken**](UidRotateToken.md)|  | 

### Return type

[**UidRotateTokenOutput**](UidRotateTokenOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | uidRotateTokenResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateawstargetdetails"></a>
# **UpdateAWSTargetDetails**
> UpdateTargetOutput UpdateAWSTargetDetails (UpdateAWSTargetDetails body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class UpdateAWSTargetDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new UpdateAWSTargetDetails(); // UpdateAWSTargetDetails | 

            try
            {
                UpdateTargetOutput result = apiInstance.UpdateAWSTargetDetails(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.UpdateAWSTargetDetails: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateAWSTargetDetails**](UpdateAWSTargetDetails.md)|  | 

### Return type

[**UpdateTargetOutput**](UpdateTargetOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | updateTargetResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedbtargetdetails"></a>
# **UpdateDBTargetDetails**
> UpdateTargetOutput UpdateDBTargetDetails (UpdateDBTargetDetails body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class UpdateDBTargetDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new UpdateDBTargetDetails(); // UpdateDBTargetDetails | 

            try
            {
                UpdateTargetOutput result = apiInstance.UpdateDBTargetDetails(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.UpdateDBTargetDetails: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateDBTargetDetails**](UpdateDBTargetDetails.md)|  | 

### Return type

[**UpdateTargetOutput**](UpdateTargetOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | updateTargetResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateitem"></a>
# **UpdateItem**
> UpdateItemOutput UpdateItem (UpdateItem body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class UpdateItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new UpdateItem(); // UpdateItem | 

            try
            {
                UpdateItemOutput result = apiInstance.UpdateItem(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.UpdateItem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateItem**](UpdateItem.md)|  | 

### Return type

[**UpdateItemOutput**](UpdateItemOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | updateItemResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterdptargetdetails"></a>
# **UpdateRDPTargetDetails**
> UpdateTargetOutput UpdateRDPTargetDetails (UpdateRDPTargetDetails body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class UpdateRDPTargetDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new UpdateRDPTargetDetails(); // UpdateRDPTargetDetails | 

            try
            {
                UpdateTargetOutput result = apiInstance.UpdateRDPTargetDetails(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.UpdateRDPTargetDetails: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateRDPTargetDetails**](UpdateRDPTargetDetails.md)|  | 

### Return type

[**UpdateTargetOutput**](UpdateTargetOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | updateTargetResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterabbitmqtargetdetails"></a>
# **UpdateRabbitMQTargetDetails**
> UpdateTargetOutput UpdateRabbitMQTargetDetails (UpdateRabbitMQTargetDetails body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class UpdateRabbitMQTargetDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new UpdateRabbitMQTargetDetails(); // UpdateRabbitMQTargetDetails | 

            try
            {
                UpdateTargetOutput result = apiInstance.UpdateRabbitMQTargetDetails(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.UpdateRabbitMQTargetDetails: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateRabbitMQTargetDetails**](UpdateRabbitMQTargetDetails.md)|  | 

### Return type

[**UpdateTargetOutput**](UpdateTargetOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | updateTargetResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterole"></a>
# **UpdateRole**
> UpdateRoleOutput UpdateRole (UpdateRole body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class UpdateRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new UpdateRole(); // UpdateRole | 

            try
            {
                UpdateRoleOutput result = apiInstance.UpdateRole(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.UpdateRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateRole**](UpdateRole.md)|  | 

### Return type

[**UpdateRoleOutput**](UpdateRoleOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | updateRoleResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesshtargetdetails"></a>
# **UpdateSSHTargetDetails**
> UpdateTargetOutput UpdateSSHTargetDetails (UpdateSSHTargetDetails body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class UpdateSSHTargetDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new UpdateSSHTargetDetails(); // UpdateSSHTargetDetails | 

            try
            {
                UpdateTargetOutput result = apiInstance.UpdateSSHTargetDetails(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.UpdateSSHTargetDetails: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateSSHTargetDetails**](UpdateSSHTargetDetails.md)|  | 

### Return type

[**UpdateTargetOutput**](UpdateTargetOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | updateTargetResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesecretval"></a>
# **UpdateSecretVal**
> UpdateSecretValOutput UpdateSecretVal (UpdateSecretVal body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class UpdateSecretValExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new UpdateSecretVal(); // UpdateSecretVal | 

            try
            {
                UpdateSecretValOutput result = apiInstance.UpdateSecretVal(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.UpdateSecretVal: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateSecretVal**](UpdateSecretVal.md)|  | 

### Return type

[**UpdateSecretValOutput**](UpdateSecretValOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | updateSecretValResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetarget"></a>
# **UpdateTarget**
> UpdateTargetOutput UpdateTarget (UpdateTarget body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class UpdateTargetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new UpdateTarget(); // UpdateTarget | 

            try
            {
                UpdateTargetOutput result = apiInstance.UpdateTarget(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.UpdateTarget: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateTarget**](UpdateTarget.md)|  | 

### Return type

[**UpdateTargetOutput**](UpdateTargetOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | updateTargetResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetargetdetails"></a>
# **UpdateTargetDetails**
> UpdateTargetOutput UpdateTargetDetails (Object body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class UpdateTargetDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = ;  // Object | 

            try
            {
                UpdateTargetOutput result = apiInstance.UpdateTargetDetails(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.UpdateTargetDetails: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **Object**|  | 

### Return type

[**UpdateTargetOutput**](UpdateTargetOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | updateTargetResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatewebtargetdetails"></a>
# **UpdateWebTargetDetails**
> UpdateTargetOutput UpdateWebTargetDetails (UpdateWebTargetDetails body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class UpdateWebTargetDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new UpdateWebTargetDetails(); // UpdateWebTargetDetails | 

            try
            {
                UpdateTargetOutput result = apiInstance.UpdateWebTargetDetails(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.UpdateWebTargetDetails: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateWebTargetDetails**](UpdateWebTargetDetails.md)|  | 

### Return type

[**UpdateTargetOutput**](UpdateTargetOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | updateTargetResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadrsa"></a>
# **UploadRSA**
> Object UploadRSA (UploadRSA body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class UploadRSAExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new UploadRSA(); // UploadRSA | 

            try
            {
                Object result = apiInstance.UploadRSA(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.UploadRSA: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UploadRSA**](UploadRSA.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | uploadRSAResponse wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="verifypkcs1"></a>
# **VerifyPKCS1**
> Object VerifyPKCS1 (VerifyPKCS1 body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using akeyless.Api;
using akeyless.Client;
using akeyless.Model;

namespace Example
{
    public class VerifyPKCS1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.akeyless.io";
            var apiInstance = new V2Api(config);
            var body = new VerifyPKCS1(); // VerifyPKCS1 | 

            try
            {
                Object result = apiInstance.VerifyPKCS1(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.VerifyPKCS1: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VerifyPKCS1**](VerifyPKCS1.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | verifyPKCS1Response wraps response body. |  -  |
| **0** | errorResponse wraps any error to return it as a JSON object with one \&quot;error\&quot; field. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

