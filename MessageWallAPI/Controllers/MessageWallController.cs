﻿using MessageWallAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MessageWallAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageWallController : ControllerBase
    {
        private readonly ILogger<MessageWallController> _logger;

        public MessageWallController(ILogger<MessageWallController> logger)
        {
            _logger = logger;
        }

        // GET: api/<MessageWallController>?message=Test&id=4
        [HttpGet]
        public string Get(string firstName = "", string lastName = "")
        {
            //List<string> output = new List<string>
            //{
            //    "Hello World",
            //    "How are you?"
            //};

            //if (!string.IsNullOrWhiteSpace(message))
            //{
            //    output.Add(message);
            //}

            //return output;

            return $"Hi {firstName} {lastName}";
        }

        // GET api/<MessageWallController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MessageWallController>
        [HttpPost]
        public void Post([FromBody] MessageModel message)
        {
            _logger.LogInformation("Our message was {Message}", message);
        }

        // PUT api/<MessageWallController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MessageWallController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
