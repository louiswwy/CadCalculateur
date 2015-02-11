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
        //private MainForm form;
        Editor ed = Application.DocumentManager.MdiActiveDocument.Editor;
        /*public List<Line> listEntitys
        {
            get;
            set;
        }*/
        MainForm form;
        [CommandMethod("Calculateur")]
        public void ModalDialog()
        {         
            //MainForm form = new MainForm();     //创建对话框

            if (form==null)
            {
                form = new MainForm();
                Application.ShowModelessDialog(form);  //显示非模态对话框 
            }
            else if (form.Visible == false && form.IsDisposed == false)
            {
                //ed.WriteMessage("界面已打开,请勿重复打开..");
                //form.
                form.Visible = true;
            }
            else if (form.IsDisposed == true)
            {
                form = new MainForm();
                Application.ShowModelessDialog(form);  //显示非模态对话框 
            }
            else
            {
               ed.WriteMessage("界面已打开,请勿重复打开..");
            }
                //ed.WriteMessage("111");
                //if (/*_IsShow == false || !*/form.IsDisposed)
                /*{
                    form = new MainForm();
                    Application.ShowModelessDialog(form);  //显示非模态对话框 

                }
                else
                {
                    //form.WindowState=Fo
                    //Editor ed = Application.DocumentManager.MdiActiveDocument.Editor;
                    ed.WriteMessage("界面已打开,请勿重复打开..");
                } */
        }
    }
}

