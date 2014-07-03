using PseudoBF.MachineModel;

namespace PseudoBF.Builtins
{
    public interface IOperation
    {
        void Execute(IMachine machine);
    }
}
