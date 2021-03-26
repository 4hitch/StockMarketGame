using StockMarketGame.Models;
using StockMarketGame.Repository.TestRepo;
using System.Threading.Tasks;

namespace StockMarketGame.Repository
{
    internal class Repository : IRepository
    {
        private static Repository _Instance;
        public static Repository Intance
        {
            get
            {
                return _Instance ?? (_Instance = new Repository());
            }
        }

        private IRepository RealRepository;

        private Repository()
        {
            RealRepository = new TestRepository();
        }

        public void SetRepository(IRepository repository) => RealRepository = repository;

        public Task<decimal> GetRate(IIndex index) => RealRepository is null ? null : RealRepository.GetRate(index);
    }
}
