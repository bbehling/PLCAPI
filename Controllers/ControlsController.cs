using ControlsApi.Models;
using ControlsApi.service;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace ControlsApi.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ControlsController : ControllerBase
    {
        private readonly ControlsService _controlsService;

        public ControlsController(ControlsService controlsService)
        {
            _controlsService = controlsService;
        }

        [HttpGet]
        public ActionResult<JArray> Get() {
            return _controlsService.Get();
        }
    }
}