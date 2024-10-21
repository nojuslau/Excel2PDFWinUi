namespace Excel2PDFWinUi.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
