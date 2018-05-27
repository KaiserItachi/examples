using GraphQLSample;
using System.Web.Http;

namespace GraphQL.GraphiQL.Controllers
{
    public class RestController : ApiController
    {
        private Repository _repository;

        public RestController(Repository repository)
        {
            _repository = repository;
        }

        [Route("GetAccountDetails")]
        public IHttpActionResult GetAccountDetails()
        {
            var Result = _repository.GetAccountDetails();
            return Ok(Result);
        }

        [Route("GetBranchDetails")]
        public IHttpActionResult GetBranchDetails()
        {
            var Result = _repository.GetBranchDetails();
            return Ok(Result);
        }

        [Route("GetAccountByAccountId")]
        public IHttpActionResult GetAccountByAccountId(int Id)
        {
            var Result = _repository.GetAccountByAccountId(Id);
            return Ok(Result);
        }

        [Route("GetBranchByBranchId")]
        public IHttpActionResult GetBranchByBranchId(int Id)
        {
            var Result = _repository.GetBranchByBranchId(Id);
            return Ok(Result);
        }
    }
}
