using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;

namespace Calculers
{
    public class CalculerLine
    {
        [CommandMethod("Calculateur")]
        public void ModalDialog()
        {

            MainForm form = new MainForm();     //创建对话框
            Application.ShowModalDialog(form);  //显示模态对话框
            Editor ed = Application.DocumentManager.MdiActiveDocument.Editor;
        }
    }
}
