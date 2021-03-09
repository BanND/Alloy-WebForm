using System;
using EPiServer.Core;
using WebForm.Business;
using WebForm.Models.Pages;
using EPiServer;
using EPiServer.Shell.Configuration;
using EPiServer.Web;

namespace WebForm.Views.Shared
{
    /// <summary>
    /// Main navigation menu, normally rendered in the site header
    /// </summary>
    public partial class MainNavigation : SiteUserControlBase
    {
        /// <summary>
        /// Performs a search by redirecting to the search page
        /// </summary>
        protected void PerformSearch(object sender, EventArgs e)
        {
            var searchPageLink = SiteDefinition.Current.StartPage.GetPage<StartPage>().SearchPageLink;

            if (ContentReference.IsNullOrEmpty(searchPageLink))
            {
                throw new MissingConfigurationException("No search page specified in site settings, please specify the 'Search Page' property on the start page");
            }

            var searchPageRedirectUrl = searchPageLink.GetPage().LinkURL;

            // Add query string parameter containing the search keywords to the search page's URL
            string searchText = Server.UrlEncode(SearchKeywords.Text.Trim());
            searchPageRedirectUrl = UriSupport.AddQueryString(searchPageRedirectUrl, "q", searchText);

            Response.Redirect(searchPageRedirectUrl);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            SearchKeywords.DataBind();

            HomePageLink.DataBind();
        }

        protected string GetThemeCssClass(object pageData)
        {
            return pageData is ICategorizable
                        ? string.Join(" ", ((ICategorizable) pageData).GetThemeCssClassNames())
                        : string.Empty;
        }
    }
}
