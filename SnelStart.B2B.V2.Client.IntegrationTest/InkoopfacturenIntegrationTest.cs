﻿using System.Net;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SnelStart.B2B.V2.Client.IntegrationTest
{
    [TestFixture]
    public class InkoopfacturenIntegrationTest
    {
        private B2BClient _client;

        [SetUp]
        public void Setup()
        {
            _client = DependencyRoot.Client;
        }

        public async Task GetAsync()
        {
            var response = await _client.Inkoopfacturen.GetAsync("$top=1");

            Assert.That(response.HttpStatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}