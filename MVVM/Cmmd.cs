using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM
{
    public class Cmmd : ICommand
    {
        public event EventHandler CanExecuteChanged;
        PeopleVM peopleVM;

        public Cmmd(PeopleVM peopleVM)
        {
            this.peopleVM = peopleVM;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            peopleVM.Caculate();
        }
    }
}
