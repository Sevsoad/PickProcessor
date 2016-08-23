using System;
using PickProcessor.Filters.Interfaces;
using ColorMine.ColorSpaces.Comparisons;
using ColorMine.ColorSpaces;
using UnityEngine;

namespace PickProcessor.Filters.ColorSwapper
{
    public class ColorSwapperFilter : IAdjustableFilter
    {
        private readonly IColorSpaceComparison _comparer;
        private const double _equalityThreshold = 25;

        public ColorSwapperFilter(IColorSpaceComparison comparer)
        {
            _comparer = comparer;
        }

        public Color32[] Apply(Color32[] picture)
        {
            throw new NotImplementedException();
        }
        
        /// <param name="paramsJson">Should contain 2 colors in RGB format</param>
        public Color32[] ApplyWithParams(Color32[] picture, string paramsJson)
        {
            throw new NotImplementedException();
        }

        public Color32[] ProcessRGB(Color32[] picture, Rgb colorToChange, Rgb colorChangeTo)
        {
            for(var i = 0; i < picture.Length; i++)
            {
                var pixel = picture[i];
                var pixelRgb = new Rgb { R = pixel.r, B = pixel.b, G = pixel.g };

                if (_comparer.Compare(colorToChange, pixelRgb) < _equalityThreshold)
                {
                    pixel.r = Convert.ToByte(colorChangeTo.R);
                    pixel.g = Convert.ToByte(colorChangeTo.G);
                    pixel.b = Convert.ToByte(colorChangeTo.B);
                }
            }

            return picture;
        }
    }
}
