using Microsoft.AspNetCore.Mvc.Filters;

namespace Architecht.API.Filters
{
    public class ResponseHeaderFilter : ActionFilterAttribute
    {
        private readonly string _name;
        private readonly string _value;

        public ResponseHeaderFilter(string name, string value)
        {
            _name = name;
            _value = value;
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            context.HttpContext.Response.Headers.Add(_name, _value);
            context.HttpContext.Response.Headers.Add("userId", "1");


            base.OnActionExecuted(context);
        }
    }
}
