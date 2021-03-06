﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Auto_Testing.Models
{
	public class Tests
	{
		[Required]
		public int? GameId { get; set; }
		public bool? TestOpens { get; set; }
		public bool? Test5min { get; set; }
		public string TestAverageRam { get; set; }
		public string TestPeakRam { get; set; }
		public bool? TestCloseOn3 { get; set; }
		public bool? TestCloseOnEscape { get; set; }
		public bool? TestCloses { get; set; }
		public int? TestAttempts { get; set; }
		public string TestFolderFileNames { get; set; }
		public int? TestNumExeFiles { get; set; }

	}

}
