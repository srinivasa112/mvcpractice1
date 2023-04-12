using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EfDBfirstApproachExample.Filters
{
	public class MyResultFilter : FilterAttribute, IResultFilter
	{
		public void OnResultExecuted(ResultExecutedContext filterContext)
		{
			filterContext.Controller.ViewBag.NoOfVisitors = 90;
		}

		public void OnResultExecuting(ResultExecutingContext filterContext)
		{ 
		}
	}
}
