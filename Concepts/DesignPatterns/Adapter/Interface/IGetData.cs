using System.Threading.Tasks;

namespace DesignPatterns
{
    public interface IGetData
    {
        public Task<string> GetData();

    }
}
