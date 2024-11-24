using CommunityToolkit.Mvvm.ComponentModel;
using FlatWpfDialog.Interfaces;


namespace FlatWpfDialog.ViewModels;
public partial class DialogViewModel : ObservableObject
{
    [ObservableProperty]
    private object? _dialogContentViewModel;

    [ObservableProperty]
    private bool _isVisible = false;

    public async Task<TOutput> ShowAsync<TInput, TOutput>(IDialogContentViewModel<TInput, TOutput> dialogContentViewModel, TInput input) where TInput : IDialogContentInput where TOutput : IDialogContentOutput
    {
        IsVisible = true;
        DialogContentViewModel = dialogContentViewModel;

        var taskCompletionSource = new TaskCompletionSource<TOutput>();
        
        dialogContentViewModel.Initialize(input, taskCompletionSource);
        
        var result = await taskCompletionSource.Task.WaitAsync(CancellationToken.None);

        IsVisible = false;

        return result;
    }
    
}
