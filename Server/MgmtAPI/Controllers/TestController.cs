using Microsoft.AspNetCore.Mvc;

namespace MgmtAPI.Controllers {

    /// <summary>
    /// A controller for testing purpose.
    /// </summary>
    [Route("test")]
    public class TestController : ControllerBase {

        /// <summary>
        /// HTTP GET method for testing purpose.
        /// </summary>
        /// <returns>The string "foo bar".</returns>
        [HttpGet]
        public string Get() {
            return "foo bar";
        }
    }
}
