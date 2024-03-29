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

namespace akeyless.Test
{
    /// <summary>
    ///  Class for testing UpdatePKICertIssuer
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class UpdatePKICertIssuerTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UpdatePKICertIssuer
        //private UpdatePKICertIssuer instance;

        public UpdatePKICertIssuerTests()
        {
            // TODO uncomment below to create an instance of UpdatePKICertIssuer
            //instance = new UpdatePKICertIssuer();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UpdatePKICertIssuer
        /// </summary>
        [Fact]
        public void UpdatePKICertIssuerInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" UpdatePKICertIssuer
            //Assert.IsInstanceOfType<UpdatePKICertIssuer> (instance, "variable 'instance' is a UpdatePKICertIssuer");
        }


        /// <summary>
        /// Test the property 'AddTag'
        /// </summary>
        [Fact]
        public void AddTagTest()
        {
            // TODO unit test for the property 'AddTag'
        }
        /// <summary>
        /// Test the property 'AllowAnyName'
        /// </summary>
        [Fact]
        public void AllowAnyNameTest()
        {
            // TODO unit test for the property 'AllowAnyName'
        }
        /// <summary>
        /// Test the property 'AllowSubdomains'
        /// </summary>
        [Fact]
        public void AllowSubdomainsTest()
        {
            // TODO unit test for the property 'AllowSubdomains'
        }
        /// <summary>
        /// Test the property 'AllowedDomains'
        /// </summary>
        [Fact]
        public void AllowedDomainsTest()
        {
            // TODO unit test for the property 'AllowedDomains'
        }
        /// <summary>
        /// Test the property 'AllowedUriSans'
        /// </summary>
        [Fact]
        public void AllowedUriSansTest()
        {
            // TODO unit test for the property 'AllowedUriSans'
        }
        /// <summary>
        /// Test the property 'ClientFlag'
        /// </summary>
        [Fact]
        public void ClientFlagTest()
        {
            // TODO unit test for the property 'ClientFlag'
        }
        /// <summary>
        /// Test the property 'CodeSigningFlag'
        /// </summary>
        [Fact]
        public void CodeSigningFlagTest()
        {
            // TODO unit test for the property 'CodeSigningFlag'
        }
        /// <summary>
        /// Test the property 'Country'
        /// </summary>
        [Fact]
        public void CountryTest()
        {
            // TODO unit test for the property 'Country'
        }
        /// <summary>
        /// Test the property 'KeyUsage'
        /// </summary>
        [Fact]
        public void KeyUsageTest()
        {
            // TODO unit test for the property 'KeyUsage'
        }
        /// <summary>
        /// Test the property 'Locality'
        /// </summary>
        [Fact]
        public void LocalityTest()
        {
            // TODO unit test for the property 'Locality'
        }
        /// <summary>
        /// Test the property 'Metadata'
        /// </summary>
        [Fact]
        public void MetadataTest()
        {
            // TODO unit test for the property 'Metadata'
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
        /// Test the property 'NotEnforceHostnames'
        /// </summary>
        [Fact]
        public void NotEnforceHostnamesTest()
        {
            // TODO unit test for the property 'NotEnforceHostnames'
        }
        /// <summary>
        /// Test the property 'NotRequireCn'
        /// </summary>
        [Fact]
        public void NotRequireCnTest()
        {
            // TODO unit test for the property 'NotRequireCn'
        }
        /// <summary>
        /// Test the property 'OrganizationalUnits'
        /// </summary>
        [Fact]
        public void OrganizationalUnitsTest()
        {
            // TODO unit test for the property 'OrganizationalUnits'
        }
        /// <summary>
        /// Test the property 'Organizations'
        /// </summary>
        [Fact]
        public void OrganizationsTest()
        {
            // TODO unit test for the property 'Organizations'
        }
        /// <summary>
        /// Test the property 'Password'
        /// </summary>
        [Fact]
        public void PasswordTest()
        {
            // TODO unit test for the property 'Password'
        }
        /// <summary>
        /// Test the property 'PostalCode'
        /// </summary>
        [Fact]
        public void PostalCodeTest()
        {
            // TODO unit test for the property 'PostalCode'
        }
        /// <summary>
        /// Test the property 'Province'
        /// </summary>
        [Fact]
        public void ProvinceTest()
        {
            // TODO unit test for the property 'Province'
        }
        /// <summary>
        /// Test the property 'RmTag'
        /// </summary>
        [Fact]
        public void RmTagTest()
        {
            // TODO unit test for the property 'RmTag'
        }
        /// <summary>
        /// Test the property 'ServerFlag'
        /// </summary>
        [Fact]
        public void ServerFlagTest()
        {
            // TODO unit test for the property 'ServerFlag'
        }
        /// <summary>
        /// Test the property 'SignerKeyName'
        /// </summary>
        [Fact]
        public void SignerKeyNameTest()
        {
            // TODO unit test for the property 'SignerKeyName'
        }
        /// <summary>
        /// Test the property 'StreetAddress'
        /// </summary>
        [Fact]
        public void StreetAddressTest()
        {
            // TODO unit test for the property 'StreetAddress'
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
        /// Test the property 'Ttl'
        /// </summary>
        [Fact]
        public void TtlTest()
        {
            // TODO unit test for the property 'Ttl'
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
        /// Test the property 'Username'
        /// </summary>
        [Fact]
        public void UsernameTest()
        {
            // TODO unit test for the property 'Username'
        }

    }

}
