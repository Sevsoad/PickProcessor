using PickProcessor.Filters.Interfaces;
using PickProcessor.Interfaces;
using PickProcessor.Filters;

namespace PickProcessor
{
    public class FilterProvider : IFilterProvider
    {
        public IFilter[] GetAll()
        {
            return new [] { new RemoveGreenFilter()};
        }
    }
}
