using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ZIRO
{
    class IzvozExcel
    {
        public void IzradaExcel(System.Windows.Forms.DataObject podatci)
        {
            Application xlexcel;
            Workbook xlworkbook;
            Worksheet xlworksheet;
            object _misValue = System.Reflection.Missing.Value;
            xlexcel = new Application
            {
                Visible = true
            };
            xlworkbook = xlexcel.Workbooks.Add(_misValue);
            xlworksheet = (Worksheet)xlworkbook.Worksheets.get_Item(1);
            Range Celije = xlworkbook.Worksheets[1].Cells;
            Celije.NumberFormat = "@";
            Range CR = (Range)xlworksheet.Cells[1, 1];
            CR.Select();
            xlworksheet.PasteSpecial(CR, XlPasteType.xlPasteValues, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
    }
}
