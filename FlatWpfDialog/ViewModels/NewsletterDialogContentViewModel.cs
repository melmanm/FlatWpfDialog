using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FlatWpfDialog.Interfaces;
using FlatWpfDialog.NewsletterDialog;
using System.Windows.Input;

namespace FlatWpfDialog.ViewModels;
public partial class NewsletterDialogContentViewModel : ObservableObject, IDialogContentViewModel<NewsletterDialogInput, NewsletterDialogOutput>
{
    private TaskCompletionSource<NewsletterDialogOutput>? _tcs;

    [ObservableProperty]
    private string _userEmail = string.Empty;

    public ICommand? SignUpCommand { get; private set; } = null;
    public ICommand? DismissCommand { get; private set; } = null;
    public ICommand? RemindLaterCommand { get; private set; } = null;

    public NewsletterDialogContentViewModel()
    {
        SignUpCommand = new RelayCommand(() => /*buisness logic can go here;*/ _tcs?.SetResult(new(NewsletterDialogResult.SignUp)));
        DismissCommand = new RelayCommand(() => /*buisness logic can go here;*/ _tcs?.SetResult(new(NewsletterDialogResult.Dismiss)));
        RemindLaterCommand = new RelayCommand(() => /*buisness logic can go here;*/ _tcs?.SetResult(new(NewsletterDialogResult.RemidLater)));
    }

    public void Initialize(NewsletterDialogInput parameters, TaskCompletionSource<NewsletterDialogOutput> tcs)
    {
        UserEmail = parameters.UserEmail;

        _tcs = tcs;
    }
}
