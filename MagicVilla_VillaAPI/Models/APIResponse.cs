using System.Net;

namespace MagicVilla_VillaAPI.Models
{
    public class APIResponse
    {
        //standarizing API Response
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccess { get; set; } = true;
        public List<string> ErrorMessages { get; set; }
        public object Result { get; set; }
    }
}
