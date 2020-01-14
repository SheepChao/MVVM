using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;

namespace MVVM
{
    public class PeopleVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnProPertyChanged(string Name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Name));
        }

        readonly Cmmd cmmd;


        public ICommand BtCaculateClicked
        {
            get
            {
                return cmmd;
            }
        }


        readonly People people;
        public PeopleVM(People people)
        {
            this.people = people;
            cmmd = new Cmmd(this);
        }

        public PeopleVM()
        {
            people = new People();
            cmmd = new Cmmd(this);

        }

        public string Name
        {
            get { return people.Name; }
            set
            {
                people.Name = value;
                //OnProPertyChanged(nameof(Name));
            }
        }

        public int Amount
        {
            get { return people.Amount; }
            set
            {
                people.Amount = value;
                //OnProPertyChanged(nameof(Amount));
            }
        }

        public bool IsMarried
        {
            get { return people.IsMarried; }
            set
            {
                people.IsMarried = value;
                //OnProPertyChanged(nameof(IsMarried));
            }
        }

        public decimal Tax
        {
            get
            {
                return people.Tax;
            }
        }

        public void Caculate()
        {
            people.CaculateTax();
            OnProPertyChanged(nameof(Tax));
        }
    }
}