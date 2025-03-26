using AutoMapper;
using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;
using MagicVilla_VillaAPI.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace MagicVilla_VillaAPI.Controllers.v2
{
    [Route("api/v{version:apiVersion}/[controller]")]
    //[Route("api/VillaNumberAPI")] // If i want static path "It is best to avoid mistakes."
    [ApiController]
    [ApiVersion("2.0")]
    public class VillaNumberAPIController : ControllerBase
    {
        #region Inject
        protected APIResponse _response;
        private readonly IVillaNumberRepository _contextVillaNumber;
        private readonly IVillaRepository _contextVilla;
        private readonly IMapper _mapper;
        public VillaNumberAPIController(IVillaNumberRepository contextVillaNumber, IMapper mapper, IVillaRepository contextVilla)
        {
            _contextVillaNumber = contextVillaNumber;
            _mapper = mapper;
            _response = new();
            _contextVilla = contextVilla;
        }
        #endregion


        // not foind in V1
        [HttpGet("GetString")]
        public IEnumerable<string> Get()
        {
            return new string[] { "Value1", "DotNetManstery" };
        }

    }
}
