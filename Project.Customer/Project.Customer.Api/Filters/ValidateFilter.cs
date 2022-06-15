using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Project.Customer.Api.Filters;
using System.Net;

namespace Project.Customer.Api.Base
{
    public class ValidateFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            //var response = context.HttpContext.Response.StatusCode;
            //var result = context.Result;
            var verboHttp = context.HttpContext.Request.Method ?? "GET";

            if (!context.ModelState.Values.Any())
            {
                EnumHttpVerbos verbo;
                Enum.TryParse(verboHttp, out verbo);

                context.Result = verbo switch
                {
                    EnumHttpVerbos.GET => new ContentResult { StatusCode = (int)HttpStatusCode.NotFound, Content = "NÃO TEM NADAAAAAAA NENHUMA AQUI" },                    
                    _ => new ContentResult { StatusCode = context.HttpContext.Response.StatusCode },
                };
            }
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
                context.Result = new BadRequestObjectResult(context.ModelState); //400
        }
    }
}
