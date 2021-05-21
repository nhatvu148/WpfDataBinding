using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDataBinding
{
    public class Person : INotifyPropertyChanged // Declare View Model
    {
        private string firstName;
        private string lastName;
        private string fullName;


        public string FirstName
        {
            get
            { return firstName; }

            set
            {
                if (firstName != value)
                {
                    firstName = value;
                    OnPropertyChanged("FirstName");
                    OnPropertyChanged("FullName");
                }
            }
        }

        public string LastName
        {
            get
            { return lastName; }

            set
            {
                if (lastName != value)
                {
                    lastName = value;
                    OnPropertyChanged("LastName");
                    OnPropertyChanged("FullName");
                }
            }
        }

        public string FullName
        {
            get
            { return fullName = firstName + " " + lastName; }

            set
            {
                if (fullName != value)
                {
                    fullName = value;
                    OnPropertyChanged("FullName");
                }
            }
        }

        public int Age { get; set; }

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        private string mTest;

        public string Test
        {
            get { return mTest; }
            set
            {
                if (mTest == value)
                    return;

                mTest = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Test)));
            }
        }


        public Person()
        {
            Task.Run(async () =>
            {
                int i = 0;
                while (true)
                {
                    await Task.Delay(200);
                    Test = (i++).ToString();
                    //PropertyChanged(this, new PropertyChangedEventArgs("Test")); // Use this if there is no private prop get set
                }
            });
        }

        //public string Test { get; set; } = "My Props";

        public override string ToString()
        {
            // return base.ToString();
            return "Hello World";
        }


    }
}
