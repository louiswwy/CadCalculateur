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
        //Document acDoc = AcadApp.DocumentManager.MdiActiveDocument;
        Database db = HostApplicationServices.WorkingDatabase;
        Editor ed = AcadApp.DocumentManager.MdiActiveDocument.Editor;
            
        //static List<string> layers;
        public List<string> layers
        {
            get;
            set;
        }

        public string selectLayer
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
            this.LayerC.Items.Clear();
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

                LayerC.DataSource = layers;
                foreach (string layer in layers)
                {
                    checkedListBox1.Items.Add(layer);
                }
                

            }
        }
        
        private void LayerC_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            ObjectId layerId;
            #region 选定图层
            if (LayerC.SelectedIndex >= 0)
            {

                using (Transaction trans = db.TransactionManager.StartTransaction())
                {
                    try
                    {
                        LayerTable lt = (LayerTable)db.LayerTableId.GetObject(OpenMode.ForRead);

                        layerId = lt[layers[LayerC.SelectedIndex].ToString()]; //选中图层的id

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


            
            selectedLine();

        }

        public string selectedLine()
        {
            //选中的图层名称
            selectLayer = layers[LayerC.SelectedIndex].ToString();
            //生成树图中主节点
            TreeNode MainNode = new TreeNode();
            MainNode.Text = layers[LayerC.SelectedIndex].ToString(); //图层名称
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



    }
}
