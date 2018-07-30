using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DotNetCoreApiWithActionFilters.Filters
{
    public class KeyFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.HttpContext.Request.Headers.TryGetValue("key", out _))
            {
                context.Result = new BadRequestObjectResult(new
                {
                    error = "request header missing 'key' value"
                });
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            //No action required
        }
    }
}
