using System.Web.UI.HtmlControls;
using WebForm.Views.Blocks;

namespace WebForm.Views.MasterPages
{
    public partial class Site : SiteMasterPage
    {
        protected override void OnLoad(System.EventArgs e)
        {
            base.OnLoad(e);

            // Add meta tag if the current page is set to be exluded from search engines
            if (CurrentPage.DisableIndexing)
            {
                header.Controls.Add(new HtmlMeta { Name = "robots", Content = "noindex" });
            }

            // Header and footer can be hidden by the editor, but will always be hidden in block preview mode
            HeaderPlaceHolder.Visible = !CurrentPage.HideSiteHeader && !(Page is BlockPreview);
            footer.Visible = !CurrentPage.HideSiteFooter && !(Page is BlockPreview);

            // We only display breadcrumbs if the header is visible
            Breadcrumb.Visible = HeaderPlaceHolder.Visible;
        }
    }
}
