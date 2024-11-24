
using FlatWpfDialog.Interfaces;

namespace FlatWpfDialog.NewsletterDialog;

public enum NewsletterDialogResult
{
    SignUp,
    Dismiss,
    RemidLater
}

public class NewsletterDialogOutput(NewsletterDialogResult dialogResult, string newsletterEmailAddress) : IDialogContentOutput
{
    public NewsletterDialogResult DialogResult { get; } = dialogResult;
    public string NewsletterEmailAddress { get; } = newsletterEmailAddress;
}
