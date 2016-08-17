using PickProcessor.Interfaces;
using PickProcessor.Model;

namespace PickProcessor
{
    public class PickProcessor : IPickProcessor
    {
        public Pixel[] NullGreenChanel(Pixel[] inputPicture)
        {
            for(var i = 0; i < inputPicture.Length; i++)
            {
                var pixel = inputPicture[i];
                inputPicture[i].G = 0;
            }

            return inputPicture;
        }
    }
}
