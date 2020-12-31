using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TooEnsure.Lib.Client.Models.Carousel;
using TooEnsure.Lib.Client.Services.Interface;
using System.Timers;

namespace TooEnsure.Lib.Client.Services
{
    public class CarouselService : ICarousel
    {
        public int CurrentId { get; set; }
        public IList<TextedCarousel> Text { get; } = new List<TextedCarousel>
        {
            new TextedCarousel { Id = 0, Text = "Local La-Fitness near you", BtnText = "Discover"},
            new TextedCarousel { Id = 1, Text = "Join Today, free of charge", BtnText = "Sign up" },
            new TextedCarousel { Id = 2, Text = "Scedule appointment with our gym professional", BtnText = "Contact" }
        };

        public event Action OnChange;

        public void MoveBackward()
        {
            throw new NotImplementedException();
        }

        public void MoveForward()
        {
            // Check before increamenting
            if (CurrentId == (Text.Count - 1))
            {
                Console.WriteLine($"Reseting: {CurrentId}");
                CurrentId = 0;
            }
            else
            {
                Console.WriteLine($"ID: {CurrentId}");
                CurrentId++;
            }
        }

        public void SetTimer(int speed)
        {
            // Create a timer with a two second interval.
            Timer Timer = new Timer(speed);
            // Hook up the Elapsed event for the timer
            Timer.Elapsed += OnTimedEvent;
            Timer.Start();
            Timer.AutoReset = true;
            Timer.Enabled = true;
        }
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            MoveForward();
            TextedChanged();
        }
        void TextedChanged() => OnChange.Invoke();
    }
}
