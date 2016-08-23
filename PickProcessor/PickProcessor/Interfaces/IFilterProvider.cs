using PickProcessor.Filters.Interfaces;

namespace PickProcessor.Interfaces
{
    public interface IFilterProvider
    {
        IFilter[] GetAll();
    }
}
