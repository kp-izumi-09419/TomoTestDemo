using System.Threading.Tasks;

namespace TomoTestDemo.Contracts.Activation
{
    public interface IActivationHandler
    {
        bool CanHandle();

        Task HandleAsync();
    }
}