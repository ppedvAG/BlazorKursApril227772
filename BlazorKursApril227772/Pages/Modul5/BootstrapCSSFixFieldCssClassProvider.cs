using Microsoft.AspNetCore.Components.Forms;

namespace BlazorKursApril227772.Pages.Modul5
{
    public class BootstrapCSSFixFieldCssClassProvider : FieldCssClassProvider
    {
        public override string GetFieldCssClass(EditContext editContext,
            in FieldIdentifier fieldIdentifier)
        {
            var isinvalid=editContext.GetValidationMessages(fieldIdentifier).Any();

            return isinvalid ? "is-invalid" : "is-valid";
        }
    }
}
