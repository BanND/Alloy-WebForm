using System;
using EPiServer.Core;
using WebForm.Models.Pages;

namespace WebForm.Views.Pages
{
    public partial class NewsPageTemplate : SiteTemplatePage<NewsPage>
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            NoListRootMessage.DataBind();
        }
    }
}
