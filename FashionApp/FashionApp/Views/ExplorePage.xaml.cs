using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FashionApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExplorePage : ContentPage
    {
        public ExplorePage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        public List<Category> AllCategories { get => GetCategories(); }

        private List<Category> GetCategories()
        {
            var catList = new List<Category>();
            catList.Add(new Category { Image = "powertools.png", Title = "POWER TOOLS", Caption = "OBTEN 50% OFF EN TODAS LAS HERRAMIENTAS ELECTRICAS" });
            catList.Add(new Category { Image = "manuales2.png", Title = "MANUAL TOOLS", Caption = "MÁS DE 50% OFF EN TODOS LAS HERRAMIENTAS MANUALES " });
            catList.Add(new Category { Image = "automotriz.png", Title = "AUTOMOTRIZ", Caption = "20% OFF EN HERRAMIENTAS ELÉCTRICAS AUTOMOTRICES" });
            return catList;
        }
    }
}