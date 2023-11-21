namespace Controle_de_alunos_MAUI
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new AlunoViewModel();
        }
    }
}