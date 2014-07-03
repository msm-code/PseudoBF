using PseudoBF.CodeDom;
using PseudoBF.MachineModel;

namespace PseudoBF.CodeInfrastructure
{
    public interface IInMemoryData
    {
        string DataType { get; }
        void SkipForward(IMachine machine);
        void SkipBackward(IMachine machine);
    }
}
