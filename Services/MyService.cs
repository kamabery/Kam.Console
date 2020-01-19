﻿using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Kam.Console.Services
{
    public class MyService : IMyService
    {
        private readonly string _baseUrl;
        private readonly string _token;
        private readonly ILogger<MyService> _logger;

        public MyService(ILoggerFactory loggerFactory, IConfigurationRoot config)
        {
            var baseUrl = config["SomeConfigItem:BaseUrl"];
            var token = config["SomeConfigItem:Token"];

            _baseUrl = baseUrl;
            _token = token;
            _logger = loggerFactory.CreateLogger<MyService>();
        }

        public async Task Run()
        {
            _logger.LogInformation(_baseUrl);
            _logger.LogInformation(_token);
        }
    }
}