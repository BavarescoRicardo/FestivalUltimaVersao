using EventoMobile.Rest_Servidor_Client;
using Festival.or;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;
using Xamarin.Forms.Xaml;

namespace EventoMobile
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private static readonly string URL_GET = "http://192.168.0.103:3000/api/juri";
        private static readonly string URL_POST = "http://192.168.0.103:3000/api/juri?id=";// 
        private static readonly string erroDefaul = "Algo errado";
        // antigo link https://localhost:44302/api/juri
        private List<xJurado> juri = new List<xJurado>();
        Label lblWelcomes = new Label();
        ClienteRest cliente = new ClienteRest();
        public MainPage()
        {
            InitializeComponent();
            btnPostar.Clicked += btnPostar_Clicked;
            btnSincro.Clicked += btnSinc_Clicked;           

            Button btnpostar = new Button();
            btnpostar.Text = "Postar";
            btnpostar.IsEnabled = true;
            btnpostar.BackgroundColor = Color.DarkSlateGray;
            btnpostar.Clicked += btnPostar_Clicked;
            layout.Children.Add(btnpostar);

            Button btniniciar = new Button();
            btniniciar.Text = "Iniciar";
            btniniciar.IsEnabled = true;
            btniniciar.BackgroundColor = Color.LightSlateGray;
            btniniciar.Clicked += btnSinc_Clicked;
            layout.Children.Add(btniniciar);
            Content = layout;

            lblWelcomes.Text = "Selecionar Jurado";
        }

        StackLayout layout = new StackLayout()
        {
            VerticalOptions = LayoutOptions.Start,
            HorizontalOptions = LayoutOptions.Start,
            Padding = new Thickness(30)
        };

        private async void btnPostar_Clicked(object sender, EventArgs e)
        {
            ClienteRest cliente = new ClienteRest();
            int conteudo;
            string urposte;
            try
            {
                if (cmbJuri.SelectedIndex > 0)
                    conteudo = this.cmbJuri.SelectedIndex;
                else
                    conteudo = 2;
                urposte = null;

                urposte = URL_POST + conteudo.ToString();
                await cliente.enviarDadosAsync(urposte, "magicamente");
            }
            catch (Exception)
            {
                lblWelcome.Text = erroDefaul;
                throw new Exception(erroDefaul);
            }
        }

        public async void btnSinc_Clicked(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            try
            {
                resultado =  cliente.readResponseAsync(URL_GET).Result;
                
            }
            catch (Exception ex)
            {
                lblWelcome.Text = erroDefaul;
                throw new Exception(erroDefaul + "  "+ ex.Message);
            }
            juri = JsonConvert.DeserializeObject<List<xJurado>>(resultado);

            // fusion
            Picker comboBoxJu = new Picker();
            Picker cmbJuri = new Picker();
            comboBoxJu.ItemsSource = juri;

            layout.Children.Add(comboBoxJu);
            Content = layout;

            // Resultado 
            lblWelcome.Text = "Sincronizado !";
        }
    }
}
