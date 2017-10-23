using SAPBusinessObjects.WPF.Viewer;
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
using System.Windows.Shapes;

namespace IGPUep.Reports
{
    /// <summary>
    /// Interaction logic for ReportViewer.xaml
    /// </summary>
    public partial class ReportViewer
    {
        private CrystalReportsViewer crystalReportsViewer;
        private ISReport isReport;

        public ReportViewer()
        {
            InitializeComponent();

            reportContainer.Children.Clear();
            crystalReportsViewer = new CrystalReportsViewer();
            reportContainer.Children.Add(crystalReportsViewer);

            isReport = new ISReport();
            
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Dictionary<String, object> rptParams
               = new Dictionary<string, object>();
            rptParams.Add("BusinessName", "KAPIHAN LA");
            rptParams.Add("FromDate", DateTime.Now.Date);
            rptParams.Add("ToDate", DateTime.Now.Date);
            rptParams.Add("_1FoodSupply", 200); // <--- Change this
            rptParams.Add("_2Fuel", 300);// <--- Change this
            rptParams.Add("_3OtherSupplies", 200);// <--- Change this
            rptParams.Add("_4Electricity", 300);// <--- Change this
            rptParams.Add("_5RepairsBuilding", 200);// <--- Change this
            rptParams.Add("_6RepairsMachinery", 300);// <--- Change this
            rptParams.Add("_7Taxes", 200);// <--- Change this
            rptParams.Add("_8Labor", 300);// <--- Change this
            rptParams.Add("_9OtherMaintenance", 200);// <--- Change this
            rptParams.Add("_10DepreciationBuilding", 300);// <--- Change this
            rptParams.Add("_11DepreciationOffice", 300);// <--- Change this
            rptParams.Add("_0BusinessIncome", 10000);// <--- Change this
            rptParams.Add("_13TotalExpenses", (200 + 300) * 5 + 300);// We handle the computation of all expenses instead of letting the report compute
            rptParams.Add("_12NetIncome", 10000 - (200 + 300) * 5 + 300);// We also handle the computation of net income


            foreach (var item in rptParams)
            {
                isReport.SetParameterValue(item.Key, item.Value);
            }
            crystalReportsViewer.ViewerCore.ReportSource = isReport;
        }
    }
}
