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
        public static bool _IsShow = false;
        /*public List<Line> listEntitys
        {
            get;
            set;
        }*/

        [CommandMethod("Calculateur")]
        public void ModalDialog()
        {         
            MainForm form = new MainForm();     //创建对话框

            if (_IsShow==false)
            {
                Application.ShowModelessDialog(form);  //显示非模态对话框 

            }
            else
            {
                Editor ed = Application.DocumentManager.MdiActiveDocument.Editor;
                ed.WriteMessage("界面已打开,请勿重复打开..");
            }
        }
    }
}
