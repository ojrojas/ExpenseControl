namespace ExpenseControl.Services.Identity.Pages;

public class DiagnosticModel : PageModel
{
    [BindProperty]
    public DiagnosticViewModel Diagnostic { get; set; } = new DiagnosticViewModel();

    public DiagnosticModel()
    {
    }

    public async Task OnGet()
    {
        var result = await HttpContext.AuthenticateAsync(IdentityConstants.ApplicationScheme);

        if (result.Succeeded)
        {
            Diagnostic.Claims = result.Principal.Claims.ToList();
        }
    }

}