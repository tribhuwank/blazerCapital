﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havit.Data.EntityFrameworkCore.Patterns.DataSources.Fakes;
using Havit.Data.EntityFrameworkCore.Patterns.SoftDeletes;
using Havit.Data.Patterns.Attributes;

namespace Havit.NewProjectTemplate.DataLayer.DataSources.Localizations.Fakes
{
	[Fake]
	[System.CodeDom.Compiler.GeneratedCode("Havit.Data.EntityFrameworkCore.CodeGenerator", "1.0")]
	public class FakeLanguageDataSource : FakeDataSource<Havit.NewProjectTemplate.Model.Localizations.Language>, Havit.NewProjectTemplate.DataLayer.DataSources.Localizations.ILanguageDataSource
	{
		public FakeLanguageDataSource(params Havit.NewProjectTemplate.Model.Localizations.Language[] data)
			: this((IEnumerable<Havit.NewProjectTemplate.Model.Localizations.Language>)data)
		{			
		}

		public FakeLanguageDataSource(IEnumerable<Havit.NewProjectTemplate.Model.Localizations.Language> data, ISoftDeleteManager softDeleteManager = null)
			: base(data, softDeleteManager)
		{
		}
	}
}