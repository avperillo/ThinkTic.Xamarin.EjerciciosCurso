using EjerciciosCurso.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace EjerciciosCurso.MVVM.ViewModels
{
    public class SemaphoreViewModel : BindableObject
    {

        private Semaphore _semaphore;

        public Semaphore Semaphore
        {
            get { return _semaphore; }
            set
            {
                _semaphore = value;
                OnPropertyChanged();
            }
        }


        public SemaphoreViewModel()
        {

            ChangeStateCommand = new Command(OnChangeState);

            Semaphore = new Semaphore()
            {
                Name = "Semáforo 1",
                State = SemaphoreState.Green

            };
        }

        private void OnChangeState(object obj) => Semaphore.ChangeState();

        private ICommand _changeStateCommand;

        public ICommand ChangeStateCommand
        {
            get { return _changeStateCommand; }
            set { _changeStateCommand = value; }
        }


    }
}
