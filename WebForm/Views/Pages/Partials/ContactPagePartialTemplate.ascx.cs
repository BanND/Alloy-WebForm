using EPiServer.Framework.DataAnnotations;
using EPiServer.Framework.Web;
using WebForm.Models.Pages;

namespace WebForm.Views.Pages.Partials
{
    [TemplateDescriptor(Default=true, Inherited = true, TemplateTypeCategory = TemplateTypeCategories.UserControl)]
    public partial class ContactPagePartialTemplate : PartialPageTemplate<ContactPage>
    {
        protected override void OnLoad(System.EventArgs e)
        {
            base.OnLoad(e);

            DataBind(); // We use data-binding expressions to make the relevant layout visible
        }
    }
}
