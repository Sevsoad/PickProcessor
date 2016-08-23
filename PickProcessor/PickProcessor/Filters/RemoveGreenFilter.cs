using System;
using PickProcessor.Filters.Interfaces;
using UnityEngine;

namespace PickProcessor.Filters
{
    class RemoveGreenFilter : IFilter
    {
        public Color32[] Apply(Color32[] picture)
        {
            for (var i = 0; i < picture.Length; i++)
            {
                var pixel = picture[i];
                picture[i].g = 0;
            }

            return picture;
        }
    }
}
