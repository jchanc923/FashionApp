using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FashionApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShopPage : ContentPage
    {
        public ShopPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        private Timer timer;
        public List<Banner> Banners { get => GetBanners(); }
        public List<Product> CollectionsList { get => GetCollections(); }
        public List<Product> TrendsList { get => GetTrends(); }

        private List<Banner> GetBanners()
        {
            var bannerList = new List<Banner>();
            bannerList.Add(new Banner { Heading = "Promociones de Temporada", Message = "40% de Descuento", Caption = "Los mejores descuentos del año", Image = "banner2.png" });
            bannerList.Add(new Banner { Heading = "Herramientas electricas", Message = "Más de 50% OFF", Caption = "Obten 50% OFF en todas las herramientas electricas", Image = "electricas.png" });
            bannerList.Add(new Banner { Heading = "Accesorios", Message = "20% de Descuento", Caption = "Arma tu caja de herramienta con una combinación unica", Image = "banner3.jpg" });
            return bannerList;
        }

        private List<Product> GetCollections()
        {
            var trendList = new List<Product>();
            trendList.Add(new Product { Image = "desbrozadora.png", Name = "Desbrozadora M18 FUEL™" , Price = "$431.50" });
            trendList.Add(new Product { Image = "destrozadora.png", Name = "Desbrozadora M18 FUEL™", Price = "$249.99" });
            trendList.Add(new Product { Image = "taladro.png", Name = "Taladro/destornillador de instalación M12 FUEL™", Price = "$140.99" });
            return trendList;
        }

        private List<Product> GetTrends()
        {
            var colList = new List<Product>();
            colList.Add(new Product { Image = "kittaladro.png", Name = "Kit de taladro magnético M18 FUEL™ de 1-1/2\"", Price = "$222.99" });
            colList.Add(new Product { Image = "taladro.png", Name = "Taladro/destornillador M18 FUEL™ de ½” con ONE-KEY™", Price = "$225.99" });
            colList.Add(new Product { Image = "kittaladro.png", Name = "Kit de taladro magnético M18 FUEL™ de 1-1/2\"", Price = "$222.99" });
            colList.Add(new Product { Image = "taladro.png", Name = "Taladro/destornillador M18 FUEL™ de ½” con ONE-KEY™", Price = "$225.99" });
            colList.Add(new Product { Image = "kittaladro.png", Name = "Kit de taladro magnético M18 FUEL™ de 1-1/2\"", Price = "$222.99" });
            colList.Add(new Product { Image = "taladro.png", Name = "Taladro/destornillador M18 FUEL™ de ½” con ONE-KEY™", Price = "$225.99" });
            return colList;
        }

        protected override void OnAppearing()
        {
            timer = new Timer(TimeSpan.FromSeconds(5).TotalMilliseconds) { AutoReset = true, Enabled = true };
            timer.Elapsed += Timer_Elapsed;
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            timer?.Dispose();
            base.OnDisappearing();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Device.BeginInvokeOnMainThread(() =>
            {

                if (cvBanners.Position == 2)
                {
                    cvBanners.Position = 0;
                    return;
                }

                cvBanners.Position += 1;
            });
        }
    }

    public class Banner
    {
        public string Heading { get; set; }
        public string Message { get; set; }
        public string Caption { get; set; }
        public string Image { get; set; }
    }

    public class Product
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
    }
}