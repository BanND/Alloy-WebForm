using System;
using WebForm.Business.WebControls;
using WebForm.Models.Pages;
using EPiServer.Web;

namespace WebForm.Views.Pages.Partials
{
    /// <summary>
    /// Base class for user controls used to render pages when dropped in a content area
    /// </summary>
    /// <typeparam name="T">Any page type inheriting from SitePageData</typeparam>
    public abstract class PartialPageTemplate<T> : ContentControlBase<SitePageData, T> where T : SitePageData
    {
    }
}
