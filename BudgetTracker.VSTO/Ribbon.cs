using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Tools.Ribbon;

namespace BudgetTracker.VSTO
{
    public partial class Ribbon
    {
        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {
          
        }

        /// <summary>
        /// Processes data contained in weekly report by detecting and filtering out the critical fields, then producing a data object to hold the relevant data fields (see documentation for 
        /// more informnation).
        /// </summary>
        /// <remarks>
        /// NOTES: 
        /// The weekly report should be displayed in the Active Worksheet for this function to work. 
        /// </remarkds>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            //Get the active worksheet
            Worksheet currentSheet = Globals.ThisAddIn.GetActiveWorksheet();
            currentSheet.Range["A1"].Value = "Mike is a fuck.";
            currentSheet.Columns.AutoFit();


        }
    }
}
