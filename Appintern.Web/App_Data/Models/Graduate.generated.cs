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
	/// <summary>Graduate</summary>
	[PublishedModel("graduate")]
	public partial class Graduate : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public new const string ModelTypeAlias = "graduate";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Graduate, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Graduate(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Avatar: Select an avatar or picture for the profile
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("avatar")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent Avatar => this.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("avatar");

		///<summary>
		/// Bio Attachment: Upload a a CV document
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("bioAttachment")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent BioAttachment => this.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("bioAttachment");

		///<summary>
		/// Bio Summary: Enter a summary of the CV
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("bioSummary")]
		public global::System.Web.IHtmlString BioSummary => this.Value<global::System.Web.IHtmlString>("bioSummary");

		///<summary>
		/// Birth Date: Enter the birth date
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("birthDate")]
		public global::System.DateTime BirthDate => this.Value<global::System.DateTime>("birthDate");

		///<summary>
		/// Country: Select the country
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("country")]
		public string Country => this.Value<string>("country");

		///<summary>
		/// Full Name: Enter the first name and last name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("fullName")]
		public string FullName => this.Value<string>("fullName");

		///<summary>
		/// Gender: Select the gender
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("gender")]
		public string Gender => this.Value<string>("gender");

		///<summary>
		/// Phone: Enter the phone number
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("phone")]
		public string Phone => this.Value<string>("phone");

		///<summary>
		/// School: Enter the school you graduated from
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("school")]
		public string School => this.Value<string>("school");

		///<summary>
		/// Specialization: Select the field of studies
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("specialization")]
		public string Specialization => this.Value<string>("specialization");

		///<summary>
		/// Tax Number: Enter the tax number
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("taxNumber")]
		public string TaxNumber => this.Value<string>("taxNumber");

		///<summary>
		/// Is Approved
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved => this.Value<bool>("umbracoMemberApproved");

		///<summary>
		/// Comments
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments => this.Value<string>("umbracoMemberComments");

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public int UmbracoMemberFailedPasswordAttempts => this.Value<int>("umbracoMemberFailedPasswordAttempts");

		///<summary>
		/// Last Lockout Date
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public global::System.DateTime UmbracoMemberLastLockoutDate => this.Value<global::System.DateTime>("umbracoMemberLastLockoutDate");

		///<summary>
		/// Last Login Date
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public global::System.DateTime UmbracoMemberLastLogin => this.Value<global::System.DateTime>("umbracoMemberLastLogin");

		///<summary>
		/// Last Password Change Date
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public global::System.DateTime UmbracoMemberLastPasswordChangeDate => this.Value<global::System.DateTime>("umbracoMemberLastPasswordChangeDate");

		///<summary>
		/// Is Locked Out
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut => this.Value<bool>("umbracoMemberLockedOut");

		///<summary>
		/// Password Answer
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer => this.Value<string>("umbracoMemberPasswordRetrievalAnswer");

		///<summary>
		/// Password Question
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion => this.Value<string>("umbracoMemberPasswordRetrievalQuestion");

		///<summary>
		/// Url Slug: Auto generated Url slug
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("urlSlug")]
		public string UrlSlug => this.Value<string>("urlSlug");
	}
}
