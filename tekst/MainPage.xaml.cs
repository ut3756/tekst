namespace tekst
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ileWyrazow(object sender, EventArgs e)
        {
            int counter = 0;
            string s = entSlowa.Text;

            wyczyscTekst(s);
            string wyrzucSpacje(string s)
            {
                while (s.Contains("  "))
                {
                    s = s.Replace("  ", " ");
                }
                return s;
            }
            if (string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s))
            {
                await DisplayAlert("Ojoj", "brak znakow", "sory memory");
                return;
            }
            else
                counter++;

            string napis = s.Trim();

            foreach (char a in napis)
            {
                if (a.ToString() == " ")
                    counter++;
            }

            lblDymek.IsVisible = true;
            imgDymek.IsVisible = true;
            lblDymek.Text = counter.ToString();
            imgDymek.Source = "dymek.png";

            //  await DisplayAlert("O tyle", counter.ToString(), "kto pytal");

        }

        private async void policzSamogloski(object sender, EventArgs e)
        {
            string samogloski = "aąeęioóuy";
            string s = entSlowa.Text;
            int counter = 0;

            if (string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s))
            {
                await DisplayAlert("Ojoj", "brak znakow", "sory memory");
                return;
            }

            foreach (char a in s)
            {
                if (samogloski.Contains(a.ToString().ToLower()))
                    counter++;
            }

            lblDymek2.IsVisible = true;
            imgDymek2.IsVisible = true;
            lblDymek2.Text = counter.ToString();
            imgDymek2.Source = "dymek.png";
            //await DisplayAlert("ile", counter.ToString(), "ok");
        }

        string wyczyscTekst(string st)
        {
            string wynik = "";
            string zakazane = " .,;-()?!";
            foreach (var c in zakazane)
                if (st.Contains(c))
                    st = st.Replace(c.ToString(), "");

            wynik = st.Replace(" ", "");

            return wynik;
        }

        private async void czyPalindrom(object sender, EventArgs e)
        {
            string s = entSlowa.Text;

            if (string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s))
            {
                await DisplayAlert("Ojoj", "brak znakow", "sory memory");
                return;
            }

            s = wyczyscTekst(s);

            char[] characterki = s.ToCharArray();
            Array.Reverse(characterki);
            string s2 = new string(characterki);

            lblDymek3.IsVisible = true;
            imgDymek3.IsVisible = true;
            imgDymek3.Source = "dymek2.png";
            if (s.ToLower().Equals(s2.ToLower()))
                lblDymek3.Text = "a jest";
            else
                lblDymek3.Text = "a nie jest";
        }

        private void resetuj(object sender, EventArgs s)
        {
            lblDymek.IsVisible = false;
            lblDymek2.IsVisible = false;
            lblDymek3.IsVisible = false;
            imgDymek.IsVisible = false;
            imgDymek2.IsVisible = false;
            imgDymek3.IsVisible = false;
        }
    }

}
