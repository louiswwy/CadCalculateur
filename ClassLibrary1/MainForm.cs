using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.Colors;
using DotNetARX;
using AcadApp = Autodesk.AutoCAD.ApplicationServices.Application;
using AcadWnd = Autodesk.AutoCAD.Windows;

namespace Calculers
{
    public partial class MainForm : Form
    {
        Document doc = AcadApp.DocumentManager.MdiActiveDocument;
        Database db = HostApplicationServices.WorkingDatabase;
        Editor ed = AcadApp.DocumentManager.MdiActiveDocument.Editor;
            
        //static List<string> layers;
        public List<string> layers
        {
            get;
            set;
        }

        public int _selectLayerNum
        {
            get;
            set;
        }

        public List<string> _selectLayerNom
        {
            get;
            set;
        }
        /// <summary>
        /// 
        /// </summary>
        public class LineList
        {
            private string _lineType;
            private Point2d _startPoint;
            private Point2d _endPoint;
            private Double _lengLine;
            public string TypeName
            {
                get { return this._lineType; }
                set { this._lineType = value; }
            }
                               
            public Point2d StartPoint
            {
                get { return this._startPoint; }
                set { this._startPoint = value; }
            }
                        
            public Point2d EndPoint
            {
                get { return this._endPoint; }
                set { this._endPoint = value; }
            }
            
            public Double LengthLine
            {
                get { return this._lengLine; }
                set { this._lengLine = value; }
            }

            public LineList() { }

            public LineList(string lineType, Point2d startPoint, Point2d endPoint, Double lengLine)
            {
                this._lineType = lineType;
                this._startPoint = startPoint;
                this._endPoint = endPoint;
                this._lengLine = lengLine;
            }
        }

        List<LineList> listOfLine =new List<LineList>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            /*if (LineList.Items.Count > 1)
            {
                ButtonM.Enabled = false;
                ButtonV.Enabled = false;
            }*/

            //清空显示图层的下拉列表框中的内容
            this.Combobox_Layer.Items.Clear();
            //显示所有图层
            loadLayer();
        }

       
        public void loadLayer()
        {
            //显示所有layer
            using (Transaction trans = db.TransactionManager.StartTransaction())
            {
                layers = (from layer in db.GetAllLayers()
                          select layer.Name).ToList();
                //LayerC.Items.Add(layers);
                //combobox
                Combobox_Layer.DataSource = layers;
                //checklistbox
                foreach (string layer in layers)
                {
                    checkedListBox_Layer.Items.Add(layer);
                }
            }
        }
        
        private void LayerC_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            ObjectId layerId;
            #region 选定图层
            if (Combobox_Layer.SelectedIndex >= 0)
            {

                using (Transaction trans = db.TransactionManager.StartTransaction())
                {
                    try
                    {
                        LayerTable lt = (LayerTable)db.LayerTableId.GetObject(OpenMode.ForRead);

                        layerId = lt[layers[Combobox_Layer.SelectedIndex].ToString()]; //选中图层的id

                        db.Clayer = layerId;  //将选中图层设为当前图层

                        trans.Commit();     //确认
                    }

                    catch (Autodesk.AutoCAD.Runtime.Exception ex)
                    {
                        ed.WriteMessage(ex.Message + "\n");
                    }

                }
            }
            #endregion
            //selectedLine();

        }

        public string selectedLine()
        {
            //选中的图层名称
            //foreach(string selectlayer)
            //selectLayer = layers[LayerC.SelectedIndex].ToString();
            //生成树图中主节点
            TreeNode MainNode = new TreeNode();
            MainNode.Text = layers[Combobox_Layer.SelectedIndex].ToString(); //图层名称
            treeView1.Nodes.Add(MainNode);

            //树图中line类型线段
            TreeNode NodeLine = new TreeNode();
            NodeLine.Text = "Level 1";
            MainNode.Nodes.Add(NodeLine);

            //树图中Pling类线段
            TreeNode NodePl = new TreeNode();
            NodePl.Text = "Level 2";
            MainNode.Nodes.Add(NodePl);

            //树图中MLine类线段
            TreeNode NodeMl = new TreeNode();
            NodeMl.Text = "Level 2";
            MainNode.Nodes.Add(NodeMl);
            return null;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            //for (int j = 0; j < checkedListBox1.Items.Count; j++)
            //    checkedListBox1.SetItemChecked(j, false); 
            
           
        }
        /// <summary>
        /// 使用了:
        /// DocumentLock m_DocumentLock = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.LockDocument();
        ///  代码...
        /// m_DocumentLock.Dispose();
        /// 来锁定-解锁文档防止出现由于"eLockViolation"引起的错误.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSelec_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Line listLines =new Line();
            //锁定文件防止出现错误"eLockViolation";
            DocumentLock m_DocumentLock = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.LockDocument();
            // Start a transaction
            using (Transaction acTrans = db.TransactionManager.StartTransaction())
            {

                try
                {
                    // Request for objects to be selected in the drawing area
                    PromptSelectionResult acSSPrompt = doc.Editor.GetSelection();
                    // If the prompt status is OK, objects were selected
                    if (acSSPrompt.Status == PromptStatus.OK)
                    {
                        SelectionSet acSSet = acSSPrompt.Value;
                        AcadApp.ShowAlertDialog("picked: " + acSSet.Count.ToString());
                        // Step through the objects in the selection set
                        foreach (SelectedObject acSSObj in acSSet)
                        {
                            //AcadApp.ShowAlertDialog("1;");
                            // Check to make sure a valid SelectedObject object was returned
                            if (acSSObj != null)
                            {
                                //AcadApp.ShowAlertDialog("2;");
                                // Open the selected object for write
                                Line acEnt = acTrans.GetObject(acSSObj.ObjectId,
                                                       OpenMode.ForWrite) as Line;
                                //AcadApp.ShowAlertDialog("3;");
                                formule.Text = acEnt.Length.ToString();
                                listLines = acEnt;
                                AcadApp.ShowAlertDialog("length: " + acEnt.Length.ToString());
                                //listLines(acEnt);  //导致cad程序崩溃.
                                if (acEnt != null)
                                {
                                    // Change the object's color to Green
                                    acEnt.ColorIndex = 5;
                                    //AcadApp.ShowAlertDialog("4;");
                                }
                            }
                        }
                        // Save the new object to the database
                        //formule 
                        acTrans.Commit();
                        //acEnt.downgradopen
                    }
                    else { return; }
                }
                catch (Autodesk.AutoCAD.Runtime.Exception ex)
                {
                    AcadApp.ShowAlertDialog("出错了!,错误信息:" + ex.Message);
                    ed.WriteMessage("出错了!,错误信息: >" + ex.Message + "<\n");
                }
            }
            this.Visible = true;
            m_DocumentLock.Dispose();
        }

        private void B_ReloadLayer_Click(object sender, EventArgs e)
        {
            checkedListBox_Layer.Items.Clear();
            loadLayer();
        }

        private void checkedListBox_Layer_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string strCollected = string.Empty;
            for (int i = 0; i < checkedListBox_Layer.Items.Count; i++)
            {
                if (checkedListBox_Layer.GetItemChecked(i))
                {
                    try
                    {
                        //checkedListBox_Layer = Convert.ToInt32(checkedListBox_Layer.CheckedItems.Count);
                        //string temp = _selectLayer.Find(delegate(checkedListBox_Layer.GetItemText(checkedListBox_Layer.Items[i])));
                        if (true)
                        {
                            if (strCollected == string.Empty)
                            {
                                strCollected = checkedListBox_Layer.GetItemText(checkedListBox_Layer.Items[i]);
                            }
                            else
                            {
                                strCollected = strCollected + "/" + checkedListBox_Layer.GetItemText(checkedListBox_Layer.Items[i]);
                            }
                            MessageBox.Show(strCollected);
                            //MessageBox.Show(checkedListBox_Layer.GetItemText(checkedListBox_Layer.Items[i]));
                            //_selectLayerNum.Add(checkedListBox_Layer.GetItemText(checkedListBox_Layer.Items[i]));
                            //_selectLayerNom.Add(checkedListBox_Layer.GetItemText(checkedListBox_Layer.Items[i]));
                        }
                    }
                    catch (Autodesk.AutoCAD.Runtime.Exception ex)
                    {
                        AcadApp.ShowAlertDialog("出错了!,错误信息:" + ex.Message);
                    }
                }
            }
        }



    }
}
