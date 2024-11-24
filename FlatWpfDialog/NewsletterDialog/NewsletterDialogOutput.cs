
using FlatWpfDialog.Interfaces;

namespace FlatWpfDialog.NewsletterDialog;

public enum NewsletterDialogResult
{
    SignUp,
    Dismiss,
    RemidLater
}

public class NewsletterDialogOutput(NewsletterDialogResult dialogResult) : IDialogContentOutput
{
    public NewsletterDialogResult DialogResult { get; } = dialogResult;
}
