using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using DemoMVVM.Data;
using System.Windows.Input;

namespace DemoMVVM.ViewModel
{
    public class VehiclesViewModel : DependencyObject
    {
        public string FilterText
        {
            get { return (string)GetValue(FilterTextProperty); }
            set { SetValue(FilterTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FilterText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FilterTextProperty =
            DependencyProperty.Register("FilterText", typeof(string), typeof(VehiclesViewModel), new PropertyMetadata("", FilterText_Changed));

        private static void FilterText_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var current = d as VehiclesViewModel;

            if (current != null)
            {
                current.Items.Filter = null;
                current.Items.Filter = current.FilterVehicles;
            }
        }

        public ICollectionView Items
        {
            get { return (ICollectionView)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Items.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(ICollectionView), typeof(VehiclesViewModel), new PropertyMetadata(null));



        
        






        public VehiclesViewModel()
        {
            Items = CollectionViewSource.GetDefaultView(Vehicle.GetVehicles());
            Items.Filter = FilterVehicles;
        }

        private bool FilterVehicles(object obj)
        {
            bool result = true;
            var vehile = obj as Vehicle;

            if (!string.IsNullOrWhiteSpace(FilterText) && vehile != null && !vehile.Model.Contains(FilterText) && !vehile.Brand.Contains(FilterText) && !vehile.Year.ToString().Contains(FilterText))
            {
                result = false;
            }

            return result;
        }
    }
}
