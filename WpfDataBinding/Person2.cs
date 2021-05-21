using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDataBinding
{
    [AddINotifyPropertyChangedInterface]
    class Person2 : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        public string Text2 { get; set; }

        public Person2()
        {
            Task.Run(async () =>
            {
                int i = 0;

                while (true)
                {
                    await Task.Delay(200);
                    Text2 = (i++).ToString();
                }
            });
        }

        public override string ToString()
        {
            return "Hi there";
        }
    }
}
