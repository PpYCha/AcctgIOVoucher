using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IGPUep.Views
{
    /// <summary>
    /// Interaction logic for SummaryView.xaml
    /// </summary>
    public partial class InputVoucherView : UserControl
    {
        public InputVoucherView()
        {
            InitializeComponent();
        }

        private void openIncomeStatement_Click(object sender, RoutedEventArgs e)
        {
            var reportViewer = new Reports.ReportViewer();
            reportViewer.ShowDialog();
        }
    }
}
