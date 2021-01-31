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
	/// <summary>Article</summary>
	[PublishedModel("article")]
	public partial class Article : PublishedContentModel, IArticleControls, IContentControls, IFileControls, IMetaDataControls, IUmbracoUrlAliasControls, IVisibilityControls
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public new const string ModelTypeAlias = "article";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Article, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Article(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Article Member: Select the member who publishes the article
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("articleMember")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent ArticleMember => this.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("articleMember");

		///<summary>
		/// Country: Select the country for this article or event
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("country")]
		public string Country => this.Value<string>("country");

		///<summary>
		/// Article Date: Choose a date for this article
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("articleDate")]
		public global::System.DateTime ArticleDate => global::Umbraco.Web.PublishedModels.ArticleControls.GetArticleDate(this);

		///<summary>
		/// Author Name: Enter a name for the author
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("authorName")]
		public string AuthorName => global::Umbraco.Web.PublishedModels.ArticleControls.GetAuthorName(this);

		///<summary>
		/// Content Grid: Enter the content for the grid
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("contentGrid")]
		public global::Newtonsoft.Json.Linq.JToken ContentGrid => global::Umbraco.Web.PublishedModels.ContentControls.GetContentGrid(this);

		///<summary>
		/// Description: Enter a description of the page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("description")]
		public string Description => global::Umbraco.Web.PublishedModels.ContentControls.GetDescription(this);

		///<summary>
		/// Main Image: Choose an image to show as the main image on this page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("mainImage")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent MainImage => global::Umbraco.Web.PublishedModels.ContentControls.GetMainImage(this);

		///<summary>
		/// Title: Enter the title for this page. If you leave this blank, we will use the page name.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("title")]
		public string Title => global::Umbraco.Web.PublishedModels.ContentControls.GetTitle(this);

		///<summary>
		/// Documents: Select the files to display or download
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("documents")]
		public global::System.Collections.Generic.IEnumerable<global::Umbraco.Core.Models.PublishedContent.IPublishedContent> Documents => global::Umbraco.Web.PublishedModels.FileControls.GetDocuments(this);

		///<summary>
		/// Legend: Enter a title as a header for the document links
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("legend")]
		public string Legend => global::Umbraco.Web.PublishedModels.FileControls.GetLegend(this);

		///<summary>
		/// Meta Description: Enter the meta description. This is what shows up in Google etc. If left blank, will use the page name.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription => global::Umbraco.Web.PublishedModels.MetaDataControls.GetMetaDescription(this);

		///<summary>
		/// Meta Keywords: Enter the meta keywords. This is used for Search Engine
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("metaKeywords")]
		public global::System.Collections.Generic.IEnumerable<string> MetaKeywords => global::Umbraco.Web.PublishedModels.MetaDataControls.GetMetaKeywords(this);

		///<summary>
		/// Meta Name: Enter the meta name. If left blank it will use the page name.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("metaName")]
		public string MetaName => global::Umbraco.Web.PublishedModels.MetaDataControls.GetMetaName(this);

		///<summary>
		/// Umbraco Url Alias: Enter an alternate url in here. Please note that the values you use must be lowercase, not use a leading slash and not use a trailing ".aspx" or trailing slash. If you are adding multiple values, they must be separated with a comma.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias => global::Umbraco.Web.PublishedModels.UmbracoUrlAliasControls.GetUmbracoUrlAlias(this);

		///<summary>
		/// Exclude From Sitemap: Tick this if you do not want this page to appear in the site map
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("excludeFromSitemap")]
		public bool ExcludeFromSitemap => global::Umbraco.Web.PublishedModels.VisibilityControls.GetExcludeFromSitemap(this);

		///<summary>
		/// Exclude From Top Navigation: Tick this if you don't want this page to appear in the top navigation
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("excludeFromTopNavigation")]
		public bool ExcludeFromTopNavigation => global::Umbraco.Web.PublishedModels.VisibilityControls.GetExcludeFromTopNavigation(this);

		///<summary>
		/// Umbraco Navi Hide: Tick this box if you want to hide this page from navigation and search results
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide => global::Umbraco.Web.PublishedModels.VisibilityControls.GetUmbracoNaviHide(this);
	}
}
