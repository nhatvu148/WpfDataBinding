using System.Threading.Tasks;

namespace WpfDataBinding.ViewModels
{
    /// <summary>
    /// As view model for each person item
    /// </summary>
    public class PersonViewModel : BaseViewModel
    {
        public string Text2 { get; set; }

        public PersonViewModel()
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
            return nameof(PersonViewModel);
        }
    }
}
