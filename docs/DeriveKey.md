# akeyless.Model.DeriveKey

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Accessibility** | **string** | for personal password manager | [optional] [default to "regular"]
**Alg** | **string** | Kdf algorithm | [default to "pbkdf2"]
**HashFunction** | **string** | HashFunction the hash function to use (relevant for pbkdf2) | [optional] [default to "sha256"]
**Iter** | **long** | IterationCount the number of iterations | 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeyLen** | **long** | KeyLength the byte length of the generated key | 
**Mem** | **long** | MemorySizeInKb the memory paramter in kb (relevant for argon2id) | [optional] [default to 16384]
**Name** | **string** | Static Secret full name | 
**Parallelism** | **long** | Parallelism the number of threads to use (relevant for argon2id) | [optional] [default to 1]
**Salt** | **string** | Salt Base64 encoded salt value. If not provided, the salt will be generated as part of the operation. The salt should be securely-generated random bytes, minimum 64 bits, 128 bits is recommended | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

