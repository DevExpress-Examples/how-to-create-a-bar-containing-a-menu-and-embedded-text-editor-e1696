using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Bars;

namespace CreateSimpleBarLayout {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
            MessageBox.Show("The " + e.Item.Content.ToString() + " item has been clicked");
        }

        private void barCheckItem1_CheckedChanged(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
            MessageBox.Show("The " + e.Item.Content.ToString() + " item has been toggled");
        }

        private void barEditItem1_EditValueChanged(object sender, RoutedEventArgs e) {
            BarEditItem item = sender as BarEditItem;
            object newValue = item.EditValue;
            //...
        }
    }
}
