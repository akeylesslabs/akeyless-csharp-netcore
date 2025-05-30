/*
 * Akeyless API
 *
 * The purpose of this application is to provide access to Akeyless API.
 *
 * The version of the OpenAPI document: 3.0
 * Contact: support@akeyless.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using akeyless.Model;
using akeyless.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace akeyless.Test.Model
{
    /// <summary>
    ///  Class for testing WalletDetails
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class WalletDetailsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for WalletDetails
        //private WalletDetails instance;

        public WalletDetailsTests()
        {
            // TODO uncomment below to create an instance of WalletDetails
            //instance = new WalletDetails();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WalletDetails
        /// </summary>
        [Fact]
        public void WalletDetailsInstanceTest()
        {
            // TODO uncomment below to test "IsType" WalletDetails
            //Assert.IsType<WalletDetails>(instance);
        }

        /// <summary>
        /// Test the property 'LoginType'
        /// </summary>
        [Fact]
        public void LoginTypeTest()
        {
            // TODO unit test for the property 'LoginType'
        }

        /// <summary>
        /// Test the property 'P12DataBase64'
        /// </summary>
        [Fact]
        public void P12DataBase64Test()
        {
            // TODO unit test for the property 'P12DataBase64'
        }

        /// <summary>
        /// Test the property 'SsoDataBase64'
        /// </summary>
        [Fact]
        public void SsoDataBase64Test()
        {
            // TODO unit test for the property 'SsoDataBase64'
        }
    }
}
