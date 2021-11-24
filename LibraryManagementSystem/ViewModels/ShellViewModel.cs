using Caliburn.Micro;

namespace LibraryManagementSystem.ViewModels
{
    public class ShellViewModel : Screen
    {
        private string _firstName = "Stefan Greve";

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

    }
}