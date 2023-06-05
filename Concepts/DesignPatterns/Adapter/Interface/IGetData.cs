using System.Threading.Tasks;

namespace DesignPatterns.Adapter.Interface
{
    public interface IGetData
    {
        public Task<string> GetData();

    }
}
