/*
 * Akeyless API
 *
 * The purpose of this application is to provide access to Akeyless API.
 *
 * The version of the OpenAPI document: 2.0
 * Contact: support@akeyless.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using akeyless.Api;
using akeyless.Model;
using akeyless.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace akeyless.Test.Model
{
    /// <summary>
    ///  Class for testing DynamicSecretUpdateAws
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DynamicSecretUpdateAwsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DynamicSecretUpdateAws
        //private DynamicSecretUpdateAws instance;

        public DynamicSecretUpdateAwsTests()
        {
            // TODO uncomment below to create an instance of DynamicSecretUpdateAws
            //instance = new DynamicSecretUpdateAws();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DynamicSecretUpdateAws
        /// </summary>
        [Fact]
        public void DynamicSecretUpdateAwsInstanceTest()
        {
            // TODO uncomment below to test "IsType" DynamicSecretUpdateAws
            //Assert.IsType<DynamicSecretUpdateAws>(instance);
        }


        /// <summary>
        /// Test the property 'AccessMode'
        /// </summary>
        [Fact]
        public void AccessModeTest()
        {
            // TODO unit test for the property 'AccessMode'
        }
        /// <summary>
        /// Test the property 'AdminRotationIntervalDays'
        /// </summary>
        [Fact]
        public void AdminRotationIntervalDaysTest()
        {
            // TODO unit test for the property 'AdminRotationIntervalDays'
        }
        /// <summary>
        /// Test the property 'AwsAccessKeyId'
        /// </summary>
        [Fact]
        public void AwsAccessKeyIdTest()
        {
            // TODO unit test for the property 'AwsAccessKeyId'
        }
        /// <summary>
        /// Test the property 'AwsAccessSecretKey'
        /// </summary>
        [Fact]
        public void AwsAccessSecretKeyTest()
        {
            // TODO unit test for the property 'AwsAccessSecretKey'
        }
        /// <summary>
        /// Test the property 'AwsRoleArns'
        /// </summary>
        [Fact]
        public void AwsRoleArnsTest()
        {
            // TODO unit test for the property 'AwsRoleArns'
        }
        /// <summary>
        /// Test the property 'AwsUserConsoleAccess'
        /// </summary>
        [Fact]
        public void AwsUserConsoleAccessTest()
        {
            // TODO unit test for the property 'AwsUserConsoleAccess'
        }
        /// <summary>
        /// Test the property 'AwsUserGroups'
        /// </summary>
        [Fact]
        public void AwsUserGroupsTest()
        {
            // TODO unit test for the property 'AwsUserGroups'
        }
        /// <summary>
        /// Test the property 'AwsUserPolicies'
        /// </summary>
        [Fact]
        public void AwsUserPoliciesTest()
        {
            // TODO unit test for the property 'AwsUserPolicies'
        }
        /// <summary>
        /// Test the property 'AwsUserProgrammaticAccess'
        /// </summary>
        [Fact]
        public void AwsUserProgrammaticAccessTest()
        {
            // TODO unit test for the property 'AwsUserProgrammaticAccess'
        }
        /// <summary>
        /// Test the property 'DeleteProtection'
        /// </summary>
        [Fact]
        public void DeleteProtectionTest()
        {
            // TODO unit test for the property 'DeleteProtection'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Fact]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'EnableAdminRotation'
        /// </summary>
        [Fact]
        public void EnableAdminRotationTest()
        {
            // TODO unit test for the property 'EnableAdminRotation'
        }
        /// <summary>
        /// Test the property 'Json'
        /// </summary>
        [Fact]
        public void JsonTest()
        {
            // TODO unit test for the property 'Json'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'NewName'
        /// </summary>
        [Fact]
        public void NewNameTest()
        {
            // TODO unit test for the property 'NewName'
        }
        /// <summary>
        /// Test the property 'ProducerEncryptionKeyName'
        /// </summary>
        [Fact]
        public void ProducerEncryptionKeyNameTest()
        {
            // TODO unit test for the property 'ProducerEncryptionKeyName'
        }
        /// <summary>
        /// Test the property 'Region'
        /// </summary>
        [Fact]
        public void RegionTest()
        {
            // TODO unit test for the property 'Region'
        }
        /// <summary>
        /// Test the property 'SecureAccessAwsAccountId'
        /// </summary>
        [Fact]
        public void SecureAccessAwsAccountIdTest()
        {
            // TODO unit test for the property 'SecureAccessAwsAccountId'
        }
        /// <summary>
        /// Test the property 'SecureAccessAwsNativeCli'
        /// </summary>
        [Fact]
        public void SecureAccessAwsNativeCliTest()
        {
            // TODO unit test for the property 'SecureAccessAwsNativeCli'
        }
        /// <summary>
        /// Test the property 'SecureAccessBastionIssuer'
        /// </summary>
        [Fact]
        public void SecureAccessBastionIssuerTest()
        {
            // TODO unit test for the property 'SecureAccessBastionIssuer'
        }
        /// <summary>
        /// Test the property 'SecureAccessEnable'
        /// </summary>
        [Fact]
        public void SecureAccessEnableTest()
        {
            // TODO unit test for the property 'SecureAccessEnable'
        }
        /// <summary>
        /// Test the property 'SecureAccessWeb'
        /// </summary>
        [Fact]
        public void SecureAccessWebTest()
        {
            // TODO unit test for the property 'SecureAccessWeb'
        }
        /// <summary>
        /// Test the property 'SecureAccessWebBrowsing'
        /// </summary>
        [Fact]
        public void SecureAccessWebBrowsingTest()
        {
            // TODO unit test for the property 'SecureAccessWebBrowsing'
        }
        /// <summary>
        /// Test the property 'SecureAccessWebProxy'
        /// </summary>
        [Fact]
        public void SecureAccessWebProxyTest()
        {
            // TODO unit test for the property 'SecureAccessWebProxy'
        }
        /// <summary>
        /// Test the property 'Tags'
        /// </summary>
        [Fact]
        public void TagsTest()
        {
            // TODO unit test for the property 'Tags'
        }
        /// <summary>
        /// Test the property 'TargetName'
        /// </summary>
        [Fact]
        public void TargetNameTest()
        {
            // TODO unit test for the property 'TargetName'
        }
        /// <summary>
        /// Test the property 'Token'
        /// </summary>
        [Fact]
        public void TokenTest()
        {
            // TODO unit test for the property 'Token'
        }
        /// <summary>
        /// Test the property 'UidToken'
        /// </summary>
        [Fact]
        public void UidTokenTest()
        {
            // TODO unit test for the property 'UidToken'
        }
        /// <summary>
        /// Test the property 'UserTtl'
        /// </summary>
        [Fact]
        public void UserTtlTest()
        {
            // TODO unit test for the property 'UserTtl'
        }

    }

}
