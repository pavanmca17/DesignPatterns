using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public interface IGetData
    {
        public Task<string> GetData();

    }
}
