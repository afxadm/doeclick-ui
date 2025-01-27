using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Serilog;
using System.Net.Http.Headers;
using System.Text;
using Totem.Domain;
using Totem.Domain.Dtos;
using Totem.Domain.Entities;
using Totem.Domain.Interfaces.Apis;
using Totem.Integrations.Apis.Pagbank.Models;

namespace Totem.Integrations.Apis.Pagbank
{
    public class RequestPagbank : IRequestPagbank
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;
        //private readonly ILogger _logger;
        private string _urlBase;

        public RequestPagbank(IConfiguration configuration, HttpClient httpClient)
        {
            _configuration = configuration;
            _httpClient = httpClient;
            _urlBase = _configuration.GetSection("ApiPagbank:Url").Value;
            //_logger = logger;
        }

        public async Task<ResponseBase<object>> Payment(PaymentDto paymentDto)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(_configuration.GetSection("ApiPagbank:Token").Value);

            var content = new StringContent(JsonConvert.SerializeObject(paymentDto), Encoding.UTF8, "application/json");

            var request = await _httpClient.PostAsync(_urlBase + "charges", content);
            var result = await request.Content.ReadAsStringAsync();
            var responsePagbank = JsonConvert.DeserializeObject<ResponsePagbank>(result);

            //_logger.Information(
            //"Payment: Entity: {Entity}, EntityId: {EntityId}, Action: {Action}, CreatedAt: {CreatedAt}, Status: {Status}",
            //paymentDto.GetType().Name,  // Entity
            //paymentDto.reference_id,    // EntityId
            //"Payment",                  // Action
            //DateTime.UtcNow,            // CreatedAt
            //responsePagbank?.status     // Status
            //);

            return new ResponseBase<object>
            {
                IsSuccess = responsePagbank?.status.ToUpper() == "AUTHORIZED" ? true : false,
                Data = responsePagbank
            };
        }
    }
}
