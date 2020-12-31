using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TooEnsure.Lib.Client.Models.Carousel;

namespace TooEnsure.Lib.Client.Services.Interface
{
    public interface ICarousel
    {
        event Action OnChange;
        int CurrentId { get; set; }
        IList<TextedCarousel> Text { get; }
        void SetTimer(int speed);
        void MoveForward();
        void MoveBackward();
    }
}
