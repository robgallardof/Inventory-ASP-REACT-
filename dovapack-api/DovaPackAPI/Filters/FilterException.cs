﻿using Microsoft.AspNetCore.Mvc.Filters;

namespace DovaPackAPI.Controllers.Filters
{
    public class FilterException : ExceptionFilterAttribute
    {
        private readonly ILogger<FilterException> logger;

        public FilterException(ILogger<FilterException> logger)
        {
            this.logger = logger;
        }

        public override void OnException(ExceptionContext context)
        {
            logger.LogError(context.Exception, context.Exception.Message);
            base.OnException(context);
        }
    }
}