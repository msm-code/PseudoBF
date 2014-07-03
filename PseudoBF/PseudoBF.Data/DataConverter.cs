using PseudoBF.CodeInfrastructure;

namespace PseudoBF.Data
{
    public static class DataConverter
    {
        public static TDst ConvertTo<TDst>(this IInMemoryData src)
            where TDst : class, IInMemoryData
        {
            TDst result = src as TDst;
            if (result != null)
            {
                return result;
            }

            throw new System.InvalidCastException();
        }
    }
}
