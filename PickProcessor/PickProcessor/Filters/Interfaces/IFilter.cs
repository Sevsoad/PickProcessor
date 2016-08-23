using UnityEngine;

namespace PickProcessor.Filters.Interfaces
{
    public interface IFilter
    {
        Color32[] Apply(Color32[] picture);
    }
}
