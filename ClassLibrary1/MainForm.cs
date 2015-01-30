using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

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
            private int _numLine;
            private string _lineType;
            private Point3d _startPoint;
            private Point3d _endPoint;
            private Double _lengLine;
            
            public int NumLine
            {
                get { return this._numLine; }
                set { this._numLine = value; }
            }
            public string TypeName
            {
                get { return this._lineType; }
                set { this._lineType = value; }
            }
                               
            public Point3d StartPoint
            {
                get { return this._startPoint; }
                set { this._startPoint = value; }
            }
                        
            public Point3d EndPoint
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

            public LineList(int NumLine,string lineType, Point3d startPoint, Point3d endPoint, Double lengLine)
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
            int i = 1;
            this.Visible = false;
            //Line listLines =new Line();
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
                        //AcadApp.ShowAlertDialog("picked: " + acSSet.Count.ToString());
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
                                                       OpenMode.ForRead) as Line;
                                //AcadApp.ShowAlertDialog("3;");
                                formule.Text = acEnt.Length.ToString();
                                //listLines = acEnt;
                                //AcadApp.ShowAlertDialog("length: " + acEnt.Length.ToString());

                                LineList SelectedLine = new LineList(i, acEnt.GetType().ToString(), acEnt.StartPoint, acEnt.EndPoint, acEnt.Length);

                                listOfLine.Add(SelectedLine);
                                //if (acEnt != null)
                                //{
                                    // Change the object's color to Green
                                 //   acEnt.ColorIndex = 5;
                                    //AcadApp.ShowAlertDialog("4;");
                                //}
                                i++;
                            }
                        }
                        // Save the new object to the database
                        //formule 
                        //acTrans.Commit();
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

            //////////
            TreeNode node = new TreeNode();
            node.Text = "Line";
            treeView1.Nodes.Add(node);

            foreach (LineList _line in listOfLine)
            {
                TreeNode node1 = new TreeNode();
                node1.Text = "line:" + _line.NumLine;
                node.Nodes.Add(node1);//node下的两个子节点。
            }


            TreeNode node11 = new TreeNode();
            node11.Text = "hopeoneone";
            node.Nodes.Add(node11);//在node1下面在添加一个结点。

            TreeNode node2 = new TreeNode();
            node2.Text = "hopetwo";   
            node.Nodes.Add(node2);
            //////////
            m_DocumentLock.Dispose();
        }

        private void B_ReloadLayer_Click(object sender, EventArgs e)
        {
            checkedListBox_Layer.Items.Clear();
            loadLayer();
        }
        string strCollected = string.Empty;
        private void checkedListBox_Layer_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int a = 0;
            for (int i = 0; i < checkedListBox_Layer.Items.Count; i++)
            {
                if (checkedListBox_Layer.GetItemChecked(i))
                {
                    a++;
                    /*try
                    {
                        //checkedListBox_Layer = Convert.ToInt32(checkedListBox_Layer.CheckedItems.Count);
                        //string temp = _selectLayer.Find(delegate(checkedListBox_Layer.GetItemText(checkedListBox_Layer.Items[i])));
                        if (true)
                        {
                            if (strCollected == string.Empty)
                            {
                                AcadApp.ShowAlertDialog("为空" );
                                strCollected = checkedListBox_Layer.GetItemText(checkedListBox_Layer.Items[i]);
                            }
                            else if (!strCollected.Contains(checkedListBox_Layer.GetItemText(checkedListBox_Layer.Items[i])))
                            {
                                AcadApp.ShowAlertDialog("添加:" );
                                strCollected = strCollected + "/" + checkedListBox_Layer.GetItemText(checkedListBox_Layer.Items[i]);
                            }
                            
                        }
                    }
                    catch (Autodesk.AutoCAD.Runtime.Exception ex)
                    {
                        AcadApp.ShowAlertDialog("出错了!,错误信息:" + ex.Message);
                    }*/
                }
            }
            MessageBox.Show("" + a);
        }

        private void ButtonV_Click(object sender, EventArgs e)
        {
            formule.Text = "";
            double _SumLinesLength=new double();
            string _FormuleLineLength = "";
            string _ResumeLineLength = "";

            int _NumLine = listOfLine.Count;
            _FormuleLineLength = "共选中:" + _NumLine + "条线.\r\n";
            int i = 0;
            foreach (LineList _line in listOfLine)
            {
                string _LineLength = "";
                
                //AcadApp.ShowAlertDialog("i:" + i + ":" + _line.LengthLine);
                _SumLinesLength = _line.LengthLine + _SumLinesLength;

                if (true)//i != _NumLine)
                {
                    _LineLength = "线段" + i + ":  " + _line.LengthLine + "\r\n";
                    _ResumeLineLength = _ResumeLineLength + _LineLength;
                }
                //else
                //{
                //    FormuleLineLength = FormuleLineLength + " + " + SumLinesLength.ToString();
                //}
                i++;
            }
            formule.Text = _FormuleLineLength + _ResumeLineLength + "\r\n选中线段长度为:" + _SumLinesLength.ToString();
            //formule.Text = "选中线段长度为:" + SumLinesLength.ToString();
        }

        private void ButtonM_Click(object sender, EventArgs e)
        {
            
            Form1_Paint(this, new PaintEventArgs(CreateGraphics(), ClientRectangle));
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);
            splitContainer1.Panel2.CreateGraphics().Clear(splitContainer1.Panel2.BackColor);
            e.Graphics.DrawLine(Pens.Black, new Point(0, 0), new Point(ClientRectangle.Width, ClientRectangle.Height));
            //注意坐标系变换。
            splitContainer1.Panel2.CreateGraphics().DrawLine
                (Pens.Black, new Point(-splitContainer1.Panel2.Left, -splitContainer1.Panel2.Top),
                new Point(ClientRectangle.Width - splitContainer1.Panel2.Left, ClientRectangle.Height - splitContainer1.Panel2.Top));
        }


    }
}
