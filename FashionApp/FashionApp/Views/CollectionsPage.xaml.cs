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
    public partial class CollectionsPage : ContentPage
    {
        public CollectionsPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        public List<Category> MyCollections { get => GetCollections(); }

        private List<Category> GetCollections()
        {
            var colList = new List<Category>();
            colList.Add(new Category { Image = "electricas.png", Title = "Herramientas electricas" });
            colList.Add(new Category { Image = "equipamiento.png", Title = "Equipamiento" });
            colList.Add(new Category { Image = "accesorios.png", Title = "Accesorios" });
            colList.Add(new Category { Image = "manuales.png", Title = "Herramientas manuales" });
            return colList;
        }
    }

    public class Category
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string Caption { get; set; }
    }
}