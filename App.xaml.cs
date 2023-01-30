using Emilia_Morejon_ExamenP3.Services;

namespace Emilia_Morejon_ExamenP3;

public partial class App : Application
{
    public static UserCall API { get; private set; }

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            API = new UserCall();
        }
    }


