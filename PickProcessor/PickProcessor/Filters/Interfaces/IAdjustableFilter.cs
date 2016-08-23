using UnityEngine;

namespace PickProcessor.Filters.Interfaces
{
    public interface IAdjustableFilter : IFilter
    {
        Color32[] ApplyWithParams(Color32[] picture, string paramsJson);
    }
}
