namespace FlatWpfDialog.Interfaces;
public interface IDialogContentViewModel<TInput, TOutput> where TInput : IDialogContentInput where TOutput : IDialogContentOutput
{
    void Initialize(TInput parameters, TaskCompletionSource<TOutput> taskCompletionSource);
}
