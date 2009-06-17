﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web.DynamicData;
using System.Web.DynamicData.ModelProviders;

using MonoTests.System.Web.DynamicData;
using MonoTests.ModelProviders;
using MonoTests.DataSource;

namespace MonoTests.Common
{
	class TestDataContext2 : ITestDataContext
	{
		public const int TableFooBarNoScaffold = 0;
		public const int TableAssociatedBar = 1;

		public FooBarNoScaffold FooBarNoScaffold { get; set; }
		public AssociatedBar AssociatedBar { get; set; }

		#region ITestDataContext Members

		public List<DynamicDataTable> GetTables ()
		{
			var ret = new List<DynamicDataTable> ();

			ret.Add (new TestDataTable<FooBarNoScaffold> ());
			ret.Add (new TestDataTable<AssociatedBar> ());

			return ret;
		}

		#endregion
	}
}
