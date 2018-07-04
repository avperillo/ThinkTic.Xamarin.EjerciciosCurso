using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace EjerciciosCurso.MVVM.Models
{

    public enum SemaphoreState
    {
        Green,
        Yellow,
        Red
    }


    public class Semaphore : BindableObject
    {

        private SemaphoreState _state;
        public SemaphoreState State { get => _state; set { _state = value; OnPropertyChanged(); } }

        public string Name { get; set; }

        internal void ChangeState()
        {
            if (State == SemaphoreState.Green)
                State = SemaphoreState.Yellow;
            else if (State == SemaphoreState.Yellow)
                State = SemaphoreState.Red;
            else
                State = SemaphoreState.Green;
        }
    }
}
