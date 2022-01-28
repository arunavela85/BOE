using System;


namespace CMS.DocumentEngine.Types.CMS
{
	/// <summary>
	/// Provides methods for retrieving pages of type News.
	/// </summary>
	public partial class newsProvider
	{
		/// <summary>
		/// Returns a query that selects published pages of type News.
		/// </summary>
		public static DocumentQuery<News> GetNews()
		{
			return DocumentHelper.GetDocuments<News>().PublishedVersion().Published();
		}


		/// <summary>
		/// Returns a published page of type News that matches the specified criteria.
		/// </summary>
		/// <param name="nodeId">The identifier of the content tree node that represents the page.</param>
		/// <param name="siteName">The name of the site where the page belongs.</param>
		/// <param name="cultureName">The name of the language, e.g. en-US, that determines which localized version should be retrieved.</param>
		public static DocumentQuery<News> GetNews(int nodeId, string cultureName, string siteName)
		{
			return GetNews().OnSite(siteName).Culture(cultureName).WhereEquals("NodeID", nodeId);
		}


		/// <summary>
		/// Returns a published page of type News that matches the specified criteria.
		/// </summary>
		/// <param name="nodeGuid">The globally unique identifier of the content tree node that represents the page.</param>
		/// <param name="siteName">The name of the site where the page belongs.</param>
		/// <param name="cultureName">The name of the language, e.g. en-US, that determines which localized version should be retrieved.</param>
		public static DocumentQuery<News> GetNews(Guid nodeGuid, string cultureName, string siteName)
		{
			return GetNews().OnSite(siteName).Culture(cultureName).WhereEquals("NodeGUID", nodeGuid);
		}


		/// <summary>
		/// Returns a published page of type News that matches the specified criteria.
		/// </summary>
		/// <param name="nodeAliasPath">The alias path to the content tree node that represents the page.</param>
		/// <param name="siteName">The name of the site where the page belongs.</param>
		/// <param name="cultureName">The name of the language, e.g. en-US, that determines which localized version should be retrieved.</param>
		public static DocumentQuery<News> GetNews(string nodeAliasPath, string cultureName, string siteName)
		{
			return GetNews().OnSite(siteName).Culture(cultureName).Path(nodeAliasPath);
		}
	}
}