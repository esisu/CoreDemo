﻿using CoreDemo.Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDemo.Project.Business.Abstract
{
	public interface IAboutService
	{
		List<About> GetList();
	}
}
