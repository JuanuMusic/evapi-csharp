/* 
 * ExaVault API
 *
 * See our API reference documentation at https://www.exavault.com/developer/api-docs/
 *
 * OpenAPI spec version: 2.0
 * Contact: support@exavault.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing AccountApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AccountApiTests
    {
        private AccountApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AccountApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AccountApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AccountApi
            //Assert.IsInstanceOfType(typeof(AccountApi), instance, "instance is a AccountApi");
        }

        /// <summary>
        /// Test GetAccount
        /// </summary>
        [Test]
        public void GetAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string evApiKey = null;
            //string evAccessToken = null;
            //string include = null;
            //var response = instance.GetAccount(evApiKey, evAccessToken, include);
            //Assert.IsInstanceOf<AccountResponse> (response, "response is AccountResponse");
        }
        /// <summary>
        /// Test UpdateAccount
        /// </summary>
        [Test]
        public void UpdateAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string evApiKey = null;
            //string evAccessToken = null;
            //UpdateAccountBody body = null;
            //var response = instance.UpdateAccount(evApiKey, evAccessToken, body);
            //Assert.IsInstanceOf<AccountResponse> (response, "response is AccountResponse");
        }
    }

}
