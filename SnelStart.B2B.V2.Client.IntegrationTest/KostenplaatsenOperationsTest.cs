﻿using System;
using System.Net;
using System.Threading.Tasks;
using NUnit.Framework;
using SnelStart.B2B.V2.Client.Operations;

namespace SnelStart.B2B.V2.Client.IntegrationTest
{
    [TestFixture]
    public class KostenplaatsenOperationsTest : CrudTest<KostenplaatsModel>
    {
        private B2BClient _client;

        [SetUp]
        public void Setup()
        {
            _client = DependencyRoot.Client;
        }
        protected override ICrudOperations<KostenplaatsModel> CrudSubject => _client.Kostenplaatsen;
        protected override Task<KostenplaatsModel> CreateNewModelAsync()
        {
            return Task.FromResult(new  KostenplaatsModel
            {
                Nummer = 1003,
                Omschrijving = Guid.NewGuid().ToString()
            });
        }

        [Test]
        public async Task GetAllAsync()
        {
            var result = await _client.Kostenplaatsen.GetAllAsync();

            Assert.AreEqual(HttpStatusCode.OK, result.HttpStatusCode);
        }
    }
}