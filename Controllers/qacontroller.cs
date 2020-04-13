// ASP.NET Maker 2020
// Copyright (c) 2019 e.World Technology Limited. All rights reserved.

using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using AspNetMaker2020.Models;
using static AspNetMaker2020.Models.project1;

// Controllers
namespace AspNetMaker2020.Controllers
{

	// Partial class
	public partial class HomeController : Controller
	{

		// list
		[Route("qalist")]
		[Route("Home/qalist")]

		public async Task<IActionResult> qalist()
		{

			// Create page object
			qa_List = new _qa_List(this);
			qa_List.Cache = _cache;

			// Run the page
			return await qa_List.Run();
		}
	}
}