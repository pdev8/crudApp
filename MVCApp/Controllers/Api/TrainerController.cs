using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using MVCApp.Interfaces;
using MVCApp.Models.Domain;
using MVCApp.Models.Response;
using MVCApp.Services;

namespace MVCApp.Controllers.Api
{
    [AllowAnonymous]
    [RoutePrefix("api/Trainers")]
    public class TrainerController : ApiController
    {
        ITrainerService _trainerService;

        public TrainerController(ITrainerService trainerService)
        {
            _trainerService = trainerService;
        }

        [Route(), HttpGet]
        public HttpResponseMessage GetAllTrainers()
        {
            try
            {
                ItemsResponse<Trainer> response = new ItemsResponse<Trainer>();
                response.Items = _trainerService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}