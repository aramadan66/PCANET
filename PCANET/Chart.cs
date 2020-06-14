using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCANET
{
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Chart_Load(object sender, EventArgs e)
        {
            //            TreeWidth = Tree.Width
            //If Rs_chart.State = adStateOpen Then Rs_chart.Close
            //        Rs_chart.Open "select * from Chart", Con, adOpenStatic, adLockOptimistic
            //        Tree.ImageList = ImageList1
            //        Tree.Nodes.Add , , "A0", "Ïáíá ÇáÍÓÇÈÇÊ", 2, 2
            //    If Rs_chart.RecordCount > 0 Then
            //        Do While Not Rs_chart.EOF
            //            If Rs_chart.Fields("Acc_main") = 0 Then
            //                Tree.Nodes.Add "A0", 4, "A" & Rs_chart.Fields("Acc_no"), "[" & Rs_chart.Fields("Acc_no") & "] " & Rs_chart.Fields("Acc_name"), 4, 4
            //            Else: Tree.Nodes.Add "A" & Rs_chart.Fields("Acc_Main"), 4, "A" & Rs_chart.Fields("Acc_no"), "[" & Rs_chart.Fields("Acc_no") & "] " & Rs_chart.Fields("Acc_name"), 4, 4
            //        End If
            //            Rs_chart.MoveNext
            //        Loop
            //    End If
            tvChart.Nodes.Add("Chart Of accounts");

        }
    }
}
