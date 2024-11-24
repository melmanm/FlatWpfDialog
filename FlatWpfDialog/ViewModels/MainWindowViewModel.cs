using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FlatWpfDialog.NewsletterDialog;
using System.Windows.Input;

namespace FlatWpfDialog.ViewModels;
public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty]
    private NewsletterDialogResult? _lastDialogResult;

    [ObservableProperty]
    private string? _lastNewsletterEmailAddress;
    public IAsyncRelayCommand OpenDialogCommand { get; }

    public MainWindowViewModel(DialogViewModel dialogViewModel, NewsletterDialogContentViewModel newsletterDialogViewModel)
    {
        OpenDialogCommand = new AsyncRelayCommand(async () =>
        {
            var dialogOutput = await dialogViewModel.ShowAsync(newsletterDialogViewModel, new("melmanm@melmanm.github.io"));
            LastDialogResult = dialogOutput.DialogResult;
            LastNewsletterEmailAddress = dialogOutput.NewsletterEmailAddress;
        });
    }
}
