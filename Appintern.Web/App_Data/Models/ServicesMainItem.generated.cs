//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.10.1
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	/// <summary>Services Main Item</summary>
	[PublishedModel("servicesMainItem")]
	public partial class ServicesMainItem : PublishedElementModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public new const string ModelTypeAlias = "servicesMainItem";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ServicesMainItem, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public ServicesMainItem(IPublishedElement content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Item Header: Enter the main item header
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("itemHeader")]
		public string ItemHeader => this.Value<string>("itemHeader");

		///<summary>
		/// Item Icon Class: Enter the Simple Line icon class
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("itemIconClass")]
		public string ItemIconClass => this.Value<string>("itemIconClass");

		///<summary>
		/// Item Introduction: Enter the item introduction as a short paragraph
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("itemIntroduction")]
		public string ItemIntroduction => this.Value<string>("itemIntroduction");

		///<summary>
		/// Item Link: Enter the link of the item header
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("itemLink")]
		public global::Umbraco.Web.Models.Link ItemLink => this.Value<global::Umbraco.Web.Models.Link>("itemLink");
	}
}
