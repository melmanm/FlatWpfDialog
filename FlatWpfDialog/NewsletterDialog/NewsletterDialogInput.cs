using FlatWpfDialog.Interfaces;

namespace FlatWpfDialog.NewsletterDialog;
public class NewsletterDialogInput(string userEmail) : IDialogContentInput
{
    public string UserEmail { get; } = userEmail;
}
