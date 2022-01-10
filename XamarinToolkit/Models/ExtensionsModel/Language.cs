﻿using System;
namespace XamarinToolkit.Models.ExtensionsModel
{
    public readonly struct Language
    {
		public Language(string name, string ci)
		{
			Name = name;
			CI = ci;
		}

		public string Name { get; }

		public string CI { get; }
	}
}
