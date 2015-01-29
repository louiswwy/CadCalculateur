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
        public List<Line> listEntitys
        {
            get;
            set;
        }

        [CommandMethod("Calculateur")]
        public void ModalDialog()
        {
            // Get the current document and database
            
            Document acDoc = Application.DocumentManager.MdiActiveDocument;
            Database acCurDb = acDoc.Database;
            Editor ed = Application.DocumentManager.MdiActiveDocument.Editor;
            // Start a transaction
            using (Transaction acTrans = acCurDb.TransactionManager.StartTransaction())
            {

                try
                {
                    // Request for objects to be selected in the drawing area
                    PromptSelectionResult acSSPrompt = acDoc.Editor.GetSelection();
                    // If the prompt status is OK, objects were selected
                    if (acSSPrompt.Status == PromptStatus.OK)
                    {
                        SelectionSet acSSet = acSSPrompt.Value;
                        // Step through the objects in the selection set
                        foreach (SelectedObject acSSObj in acSSet)
                        {
                            // Check to make sure a valid SelectedObject object was returned
                            if (acSSObj != null)
                            {
                                // Open the selected object for write
                                Line acEnt = acTrans.GetObject(acSSObj.ObjectId,
                                                       OpenMode.ForRead) as Line;

                                //listEntitys.Add(acEnt);  //导致cad程序崩溃.
                                //if (acEnt != null)
                                //{
                                    // Change the object's color to Green
                                //    acEnt.ColorIndex = 3;
                                //}
                            }
                        }
                        // Save the new object to the database
                        acTrans.Commit();
                    }
                    else { return; }
                }
                catch (Autodesk.AutoCAD.Runtime.Exception ex)
                {
                    ed.WriteMessage(ex.Message + "\n");
                }
            }
            MainForm form = new MainForm();     //创建对话框
            Application.ShowModalDialog(form);  //显示模态对话框
            
        }
    }
}
