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
            rptParams.Add("BusinessName", "UEP KAPIHAN");
            rptParams.Add("FromDate", new DateTime(2016, 1, 1));
            rptParams.Add("ToDate", new DateTime(2016, 12, 31));
            rptParams.Add("_1FoodSupply", 1198847.43); // <--- Change this
            rptParams.Add("_2Fuel", 10775);// <--- Change this
            rptParams.Add("_3OtherSupplies", 222922.42);// <--- Change this
            rptParams.Add("_4Electricity", 58136.42);// <--- Change this
            rptParams.Add("_5RepairsBuilding", 1197.00);// <--- Change this
            rptParams.Add("_6RepairsMachinery", 300);// <--- Change this
            rptParams.Add("_7Taxes", 500);// <--- Change this
            rptParams.Add("_8Labor", 373338.06);// <--- Change this
            rptParams.Add("_9OtherMaintenance", 15710.75);// <--- Change this
            rptParams.Add("_10DepreciationBuilding", 53267.05);// <--- Change this
            rptParams.Add("_11DepreciationOffice", 1445.68);// <--- Change this
            rptParams.Add("_0BusinessIncome", 2628329.08);// <--- Change this
            rptParams.Add("_13TotalExpenses", 1936439.81);// We handle the computation of all expenses instead of letting the report compute
            rptParams.Add("_12NetIncome", 2628329.08 - 1936439.81);// We also handle the computation of net income


            foreach (var item in rptParams)
            {
                isReport.SetParameterValue(item.Key, item.Value);
            }
            crystalReportsViewer.ViewerCore.ReportSource = isReport;
        }
    }
}
