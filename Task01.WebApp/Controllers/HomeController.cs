﻿using ChannelEngine.Merchant.ApiClient.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Task.Service;
using Task01.Data.Repository;
using Task01.Interfaces;
using Task01.WebApp.Models;

namespace Task01.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDataCollection _collection;

        public HomeController(ILogger<HomeController> logger, IDataCollection dataCollection)
        {
            _logger = logger;
            _collection = dataCollection;
        }

        public IActionResult Index()
        {
            var top3Products = ((DataCollection)_collection).MerchantProductRepository.GetProducts(3);
            return View(top3Products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Edit(MerchantProductRequest model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var patchContent = $"{{\"PropertiesToUpdate\": [\"name\"], \"MerchantProductRequestModels\": [{{\"MerchantProductNo\": \"{model.MerchantProductNo}\",\"Name\": \"{model.Name}\"}}]}}";
            var result = ((DataCollection)_collection).MerchantProductRepository.Patch<MerchantProductRequest>(string.Empty, patchContent);
            return View($"'{model.MerchantProductNo}' is updated");
        }
    }
}
