﻿using System;
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
using System.Text.RegularExpressions;

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
            private string _idLine;
            private string _lineType;
            private Point3d _startPoint;
            private Point3d _endPoint;
            private Double _lengLine;
            private int _numTube;
            private int _numTV;
            private int _numTD;
            private int _numTP;

            public string ID
            {
                get { return this._idLine; }
                set { this._idLine = value; }
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
            //
            public int NumTube
            {
                get { return this._numTube; }
                set { this._numTube = value; }
            }
            public int NumTV
            {
                get { return this._numTV; }
                set { this._numTV = value; }
            }
            public int NumTD
            {
                get { return this._numTD; }
                set { this._numTD = value; }
            }
            public int NumTP
            {
                get { return this._numTP; }
                set { this._numTP = value; }
            }

            public LineList() { }

            public LineList(string ID, string lineType, Point3d startPoint, Point3d endPoint, Double lengLine)
            {
                this._idLine = ID;
                this._lineType = lineType;
                this._startPoint = startPoint;
                this._endPoint = endPoint;
                this._lengLine = lengLine;
            }
            public LineList(string ID, string lineType, Point3d startPoint, Point3d endPoint, Double lengLine, int numtube, int numTv, int numTd, int numTp)
            {
                this._idLine = ID;
                this._lineType = lineType;
                this._startPoint = startPoint;
                this._endPoint = endPoint;
                this._lengLine = lengLine;
                this._numTube=numtube;
                this._numTV = numTv;
                this._numTD = numTd;
                this._numTP = numTp;
            }
        }

        List<LineList> listOfLine =new List<LineList>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CalculerLine._IsShow = true;
            //清空显示图层的下拉列表框中的内容
            this.Combobox_Layer.Items.Clear();
            //显示所有图层
            loadLayer();
            loadDefautBlock();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //窗口关闭时重置_IsShow的值,使窗口可以再次打开
            CalculerLine._IsShow = false;
        }

        
        private void LayerC_SelectionChangeCommitted(object sender, EventArgs e)
        {


        }

        
        #region 第一种方法,手动制定每两个节点间线缆/钢管数量
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
            treeView1.Nodes.Clear();
            listOfLine.Clear();
            dataGridView1.Refresh();
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

                                LineList _SelectedLine = new LineList(acEnt.ObjectId.Handle.Value.ToString()
                                    , acEnt.GetType().ToString(), acEnt.StartPoint, acEnt.EndPoint, acEnt.Length);

                                listOfLine.Add(_SelectedLine);

                                i++;
                            }
                        }
                    }
                    else { return; }
                }
                catch (Autodesk.AutoCAD.Runtime.Exception ex)
                {
                    //AcadApp.ShowAlertDialog("出错了!,错误信息:" + ex.Message);
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
                node1.Text = "line:" + _line.ID;
                node.Nodes.Add(node1);//node下的两个子节点。
            }
            FillUpDataGrid();
            //////////
            m_DocumentLock.Dispose();
        }

        #region datagridView装载与清除
        public void FillUpDataGrid()
        {
            if (dataGridView1.Rows.Count > 1)
            {
                ClearUpDataGrid();
            }
            //AcadApp.ShowAlertDialog("选中:" + listOfLine.Count);
            try
            {
                //dataGridView2数据源绑定listOfLine
                //dataGridView2.DataSource = listOfLine;
                //逐条添加dataGridView1中的数据
                foreach (LineList _ent_Line in listOfLine)
                {
                    int RowIndex = 0;
                    RowIndex = this.dataGridView1.Rows.Add();
                    dataGridView1.Rows[RowIndex].Cells[0].Value = _ent_Line.ID.ToString();
                    dataGridView1.Rows[RowIndex].Cells[1].Value = _ent_Line.StartPoint.X.ToString("F2");
                    dataGridView1.Rows[RowIndex].Cells[2].Value = _ent_Line.StartPoint.Y.ToString("F2");
                    dataGridView1.Rows[RowIndex].Cells[3].Value = _ent_Line.EndPoint.X.ToString("F2");
                    dataGridView1.Rows[RowIndex].Cells[4].Value = _ent_Line.EndPoint.Y.ToString("F2");
                    dataGridView1.Rows[RowIndex].Cells[5].Value = _ent_Line.LengthLine.ToString("F2"); ;
                    dataGridView1.Rows[RowIndex].Cells[6].Value = _ent_Line.NumTube.ToString();
                    dataGridView1.Rows[RowIndex].Cells[7].Value = _ent_Line.NumTD.ToString();
                    dataGridView1.Rows[RowIndex].Cells[8].Value = _ent_Line.NumTV.ToString();
                    dataGridView1.Rows[RowIndex].Cells[8].Value = _ent_Line.NumTP.ToString();
                    RowIndex++;
                }
            }
            catch (Autodesk.AutoCAD.Runtime.Exception ex)
            {
                AcadApp.ShowAlertDialog("出错了!,错误信息:" + ex.Message);
            }
        }

        public void ClearUpDataGrid()
        {
            while (dataGridView1.Rows.Count > 1)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
           
        }
        #endregion

        private void ButtonV_Click(object sender, EventArgs e)
        {
            formule.Text = "";
            //总长度
            double _SumLinesLength = new double();
            //不同线缆和钢管的长度
            double _sumTubeLength = 0;
            double _sumTDLength = 0;
            double _sumTPLength = 0;
            double _sumTVLength = 0;

            //
            double SumTubeLength = 0;
            double SumTDLength = 0;
            double SumTPLength = 0;
            double SumTVLength = 0;
            //
            string _FormuleLineLength = "";
            //
            string _ResumeLineLength = "";

            int _NumLine = listOfLine.Count;
            _FormuleLineLength = "共选中:" + _NumLine + "条线.\r\n";
            int i = 0;
            foreach (LineList _line in listOfLine)
            {
                //在textbox中的显示各线段的长度
                string _LineLength = "";

                //AcadApp.ShowAlertDialog("i:" + i + ":" + _line.LengthLine);
                _SumLinesLength = _line.LengthLine + _SumLinesLength;
                //计算每段线的长度
                _sumTubeLength = _line.LengthLine * _line.NumTube;
                _sumTDLength = _line.LengthLine * _line.NumTD;
                _sumTPLength = _line.LengthLine * _line.NumTP;
                _sumTVLength = _line.LengthLine * _line.NumTV;

                SumTubeLength += _sumTubeLength;
                SumTDLength += _sumTDLength;
                SumTPLength += _sumTPLength;
                SumTVLength += _sumTVLength;
                if (true)//i != _NumLine)
                {
                    _LineLength = "线段" + i + "长:  " + _line.LengthLine + "\r\n"
                        + "钢管" + i + "长:  " + _sumTubeLength + "\r\n"
                        + "TD" + i + "长:  " + _sumTDLength + "\r\n"
                        + "TP" + i + "长:  " + _sumTPLength + "\r\n"
                        + "TV" + i + "长:  " + _sumTVLength + "\r\n";

                    //所有线段的长度
                    _ResumeLineLength = _ResumeLineLength + _LineLength;

                }
                //else
                //{
                //    FormuleLineLength = FormuleLineLength + " + " + SumLinesLength.ToString();
                //}
                i++;
            }
            formule.Text = _FormuleLineLength + "\r\n"
                + _ResumeLineLength + "\r\n选中线段长度为:" + _SumLinesLength.ToString() + "\r\n"
                + SumTubeLength + "\r\n  TD:" + SumTDLength + "\r\n  TV:" + SumTVLength + "\r\n  TP:" + SumTPLength;
            //formule.Text = "选中线段长度为:" + SumLinesLength.ToString();
        }


        string strCollected = string.Empty;
        

        //计算线总长度

        #region 画图 (弃用)
        private void ButtonM_Click(object sender, EventArgs e)
        {
            
            //Form1_Paint(this, new PaintEventArgs(CreateGraphics(), ClientRectangle));
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
        #endregion

        private void B_DrawLine_Click(object sender, EventArgs e)
        {
            DocumentLock m_DocumentLock = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.LockDocument();
            // Start a transaction
            using (Transaction acTrans = db.TransactionManager.StartTransaction())
            {

                try
                {
                    Point3d startPoint = new Point3d();
                    Point3d endPoint = new Point3d();
                    if (GetPoint("\n输入起点:", out startPoint) && GetPoint("\n输入终点:", startPoint, out endPoint))
                    {
                        Line lin = new Line(startPoint, endPoint);
                        db.AddToModelSpace(lin);
                        acTrans.Commit();
                        // 绘制管道
                        //DrawPipe(startPoint, endPoint, 100, 70);
                    }            
                    // Request for objects to be selected in the drawing area
                    //PromptSelectionResult acSSPrompt = doc.Editor.GetCommandVersion;
                }
                catch (Autodesk.AutoCAD.Runtime.Exception ex)
                {
                    AcadApp.ShowAlertDialog("出错了!,错误信息:" + ex.Message);
                    ed.WriteMessage("出错了!,错误信息: >" + ex.Message + "<\n");
                }                
            }
            m_DocumentLock.Dispose();
        }

        public bool GetPoint(string prompt, out Point3d pt)
        {
            Editor ed = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor;
            PromptPointResult ppr = ed.GetPoint(prompt);
            if (ppr.Status == PromptStatus.OK)
            {
                pt = ppr.Value;

                // 变换到世界坐标系
                Matrix3d mat = ed.CurrentUserCoordinateSystem;
                pt.TransformBy(mat);

                return true;
            }
            else
            {
                pt = new Point3d();
                return false;
            }
        }

        public bool GetPoint(string prompt, Point3d basePoint, out Point3d pt)
        {
            Editor ed = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor;
            PromptPointOptions ppo = new PromptPointOptions(prompt);
            ppo.BasePoint = basePoint;
            ppo.UseBasePoint = true;
            PromptPointResult ppr = ed.GetPoint(ppo);
            if (ppr.Status == PromptStatus.OK)
            {
                pt = ppr.Value;

                // 变换到世界坐标系
                Matrix3d mat = ed.CurrentUserCoordinateSystem;
                pt.TransformBy(mat);

                return true;
            }
            else
            {
                pt = new Point3d();
                return false;
            }
        }

        
        private Vector3d GetNormalByInVector(Vector3d inVector)
        {
            double tol = 1.0E-7;
            if (Math.Abs(inVector.X) < tol && Math.Abs(inVector.Y) < tol)
            {
                if (inVector.Z >= 0)
                {
                    return new Vector3d(-1, 0, 0);
                }
                else
                {
                    return Vector3d.XAxis;
                }
            }
            else
            {
                Vector2d yAxis2d = new Vector2d(inVector.X, inVector.Y);
                yAxis2d = yAxis2d.RotateBy(Math.PI * 0.5);
                Vector3d yAxis = new Vector3d(yAxis2d.X, yAxis2d.Y, 0);
                Vector3d normal = yAxis;
                normal = normal.RotateBy(Math.PI * 0.5, inVector);
                return normal;
            }
        }

        Matrix3d GetTranslateMatrix(Point3d inPoint, Vector3d inVector, Vector3d normal)
        {
            Vector3d xAxis = inVector;
            xAxis = xAxis.GetNormal();
            Vector3d zAxis = normal;
            zAxis = zAxis.GetNormal();
            Vector3d yAxis = new Vector3d(xAxis.X, xAxis.Y, xAxis.Z);
            yAxis = yAxis.RotateBy(Math.PI * 0.5, zAxis);

            return Matrix3d.AlignCoordinateSystem(Point3d.Origin, Vector3d.XAxis, Vector3d.YAxis, Vector3d.ZAxis, inPoint, xAxis, yAxis, zAxis);
        }

        private void Button_In_Click(object sender, EventArgs e)
        { 
            DocumentLock m_DocumentLock = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.LockDocument();
            // Start a transaction
            using (Transaction acTrans = db.TransactionManager.StartTransaction())
            {
                Point3d startPoint = new Point3d();
                if (GetPoint("\n输入起点:", out startPoint))
                {

                    ed.WriteMessage("未完成");                
                }

            }
            m_DocumentLock.Dispose();

        }

        //datagridview中选中一行数据时,将cad中对应的线段变色
        /// <summary>
        /// 在datagridview(表格)中选中一行数据时,将cad中对应的线段变色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            ed.WriteMessage("\n MouseDown \n>");
            DocumentLock m_DocumentLock = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.LockDocument();
            int _rowNumber = dataGridView1.CurrentCell.RowIndex;
            _currentRows = _rowNumber;
            ed.WriteMessage("选中第:   " + _rowNumber + "行");
            LineList LL = listOfLine[_rowNumber];
            ed.WriteMessage("选中实体id为:   " + LL.ID + "<");
            if (true)
            {
                using (Transaction trans = db.TransactionManager.StartTransaction())
                {
                    try
                    {
                        //通过objectId找到线段,并改变颜色
                        ObjectId _obId = db.GetObjectId(false, new Handle(Convert.ToInt64(LL.ID)), 0);
                        Line acEnt = trans.GetObject(_obId, OpenMode.ForWrite) as Line;
                        _currentColorIndex = acEnt.ColorIndex;
                        acEnt.ColorIndex = 5;
                        trans.Commit();
                    }
                    catch (Autodesk.AutoCAD.Runtime.Exception ex)
                    {
                        trans.Abort();
                        //AcadApp.ShowAlertDialog("出错了!,错误信息:" + ex.Message);
                        ed.WriteMessage("\n救命出错了!,错误信息: \n>" + ex.Message + "<\n");
                    }
                }
            }
            m_DocumentLock.Dispose();

        }

        int _currentRows;
        int _currentColorIndex = 0;
        //改变上次选中线段的颜色  并没有屁用
        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            DocumentLock m_DocumentLock = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.LockDocument();
            int _rowNumber = _currentRows;
            LineList LL = listOfLine[_rowNumber];
            if (true)
            {
                using (Transaction trans = db.TransactionManager.StartTransaction())
                {
                    try
                    {
                        //通过objectId找到线段,并改变颜色
                        ObjectId _obId = db.GetObjectId(false, new Handle(Convert.ToInt64(LL.ID)), 0);
                        Line acEnt = trans.GetObject(_obId, OpenMode.ForWrite) as Line;
                        acEnt.ColorIndex = _currentColorIndex;
                        trans.Commit();
                    }
                    catch (Autodesk.AutoCAD.Runtime.Exception ex)
                    {
                        trans.Abort();
                        //AcadApp.ShowAlertDialog("出错了!,错误信息:" + ex.Message);
                        ed.WriteMessage("\n救命出错了!,错误信息: \n>" + ex.Message + "<\n");
                    }
                }
            }
            m_DocumentLock.Dispose();

        }

        /// <summary>
        /// 在表格中定义两结点间线缆/钢管的数量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int currentCell = Convert.ToInt32(dataGridView1.CurrentCell.ColumnIndex.ToString());
            //string contenu=dataGridView1.
            if (currentCell <= 9 || currentCell >= 6)
            {
                //double NT, Np, ND, NV;
                ed.WriteMessage("\n cellEndEdit\n>");
                int _rowNumber = dataGridView1.CurrentCell.RowIndex;
                ed.WriteMessage("选中第:   " + _rowNumber + "行");
                string str = dataGridView1.Rows[_rowNumber].Cells[currentCell].Value.ToString();
                LineList LL = listOfLine[_rowNumber];
                switch (currentCell)
                {
                    case 6:
                        if (dataGridView1.Rows[_rowNumber].Cells[6].Value.ToString() != "NA"
                    && isNumberic1(dataGridView1.Rows[_rowNumber].Cells[6].Value.ToString()))
                        {
                            LL.NumTube = Convert.ToInt32(dataGridView1.Rows[_rowNumber].Cells[6].Value);
                        }
                        else
                        {
                            return;
                        }
                        break;
                    case 7:
                        if (dataGridView1.Rows[_rowNumber].Cells[7].Value.ToString() != "NA"
                    && isNumberic1(dataGridView1.Rows[_rowNumber].Cells[7].Value.ToString()))
                        {
                            LL.NumTD = Convert.ToInt32(dataGridView1.Rows[_rowNumber].Cells[7].Value);
                        }
                        else
                        {
                            return;
                        }
                        break;
                    case 8:
                        if (dataGridView1.Rows[_rowNumber].Cells[8].Value.ToString() != "NA"
                    && isNumberic1(dataGridView1.Rows[_rowNumber].Cells[8].Value.ToString()))
                        {
                            LL.NumTV = Convert.ToInt32(dataGridView1.Rows[_rowNumber].Cells[8].Value);
                        }
                        else
                        {
                            return;
                        }
                        break;
                    case 9:
                        if (dataGridView1.Rows[_rowNumber].Cells[9].Value.ToString() != "NA"
                            && isNumberic1(dataGridView1.Rows[_rowNumber].Cells[9].Value.ToString()))
                        {
                            LL.NumTP = Convert.ToInt32(dataGridView1.Rows[_rowNumber].Cells[9].Value);
                        }
                        else
                        {
                            return;
                        }
                        break;

                }
                formule.Text = "4 NumTP:" + LL.NumTP + "\r\n"
                    + "5:NumTD  " + LL.NumTD + "\r\n"
                    + "6 NumTV:" + LL.NumTV + "\r\n"
                    + "7 NumTube:" + LL.NumTube + "\r\n";
            }
        }
        #endregion

        #region 方法二,画线后自动计数;
        
        private void BA_RuKou_Click(object sender, EventArgs e)
        {
            this.Hide();
            Point3d DrawRecPoint;
            Editor ed = doc.Editor;
            GetPoint("\n输入起点:", out DrawRecPoint);
            //获取长方形左上,右下的点的2d坐标
            Point2d RecStartPoint = new Point2d(DrawRecPoint.X - 100, DrawRecPoint.Y + 400);
            Point2d RecEndPoint = new Point2d(DrawRecPoint.X + 100, DrawRecPoint.Y);
            DrawRectangle(RecStartPoint, RecEndPoint);
            this.Show();
        }

        private void BA_ChuanLou_Click(object sender, EventArgs e)
        {
            this.Hide();
            Point3d DrawRecPoint;
            GetPoint("\n输入起点:", out DrawRecPoint);
            
            //获取长方形左上,右下的点的2d坐标
            Point2d RecStartPoint = new Point2d(DrawRecPoint.X - 75, DrawRecPoint.Y + 300);
            Point2d RecEndPoint = new Point2d(DrawRecPoint.X + 75, DrawRecPoint.Y);
            DrawRectangle(RecStartPoint, RecEndPoint);
            this.Show();
        }

        //画长方形
        public void DrawRectangle(Point2d StartPt,Point2d EndPoint)
        {
            DocumentLock m_DocumentLock = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.LockDocument();
            //获取用户在文件上选定的点坐标

            //Rectangle3d rect = new Rectangle3d()
            //生成长方形图
            Polyline rectangle = new Polyline();
            rectangle.CreateRectangle(StartPt, EndPoint);
            using (Transaction trans = db.TransactionManager.StartTransaction())
            {
                BlockTable bt = (BlockTable)trans.GetObject(db.BlockTableId, OpenMode.ForRead);
                //以写方式打开模型空间块表记录
                BlockTableRecord btr = (BlockTableRecord)trans.GetObject(bt[BlockTableRecord.ModelSpace], OpenMode.ForWrite);
                //将图形对象加入块表记录中,并返回objectid对象
                db.AddToModelSpace(rectangle);
                trans.Commit();
            }
            m_DocumentLock.Dispose();
        }

        //每次checkbox值变更,重新生成插座块的扩展属性.
        private void CheckBox_TP_CheckedChanged(object sender, EventArgs e)
        {
            loadDefautBlock();
        }
        //每次checkbox值变更,重新生成插座块的扩展属性.
        private void CheckBox_TD_CheckedChanged(object sender, EventArgs e)
        {
            loadDefautBlock();
        }
        //每次checkbox值变更,重新生成插座块的扩展属性.
        private void CheckBox_TV_CheckedChanged(object sender, EventArgs e)
        {
            loadDefautBlock();
        }
        //载入默认图块.
        public void loadDefautBlock()
        {
            int _checkTp = 0; int _checkTd = 0; int _checkTv = 0; int _totalCheck = 0;
            //PromptFileNameResult Fresult=ed.GetFileNameForOpen("");
            //MessageBox.Show("+" + Fresult.StringResult);
            //string fillPath="*\Block";
            if (CheckBox_TD.Checked == true) { _checkTd = 1; } else { _checkTd = 0; }
            if (CheckBox_TP.Checked == true) { _checkTp = 1; } else { _checkTp = 0; }
            if (CheckBox_TV.Checked == true) { _checkTv = 1; } else { _checkTv = 0; }
            _totalCheck = _checkTp + _checkTd + _checkTv;
        }


        //为显示效果而添加的线段
        #endregion







        private void Combobox_Layer_SelectionChangeCommitted(object sender, EventArgs e)
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

        private void B_ReloadLayer_Click(object sender, EventArgs e)
        {
            checkedListBox_Layer.Items.Clear();
            loadLayer();
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

        //public void load
        public bool isNumberic1(string _string)
        {
            //是否为正整数.
            string pattern = @"^\+?[1-9][0-9]*$";

            if (Regex.IsMatch(_string, pattern))

                return true;

            else

                return false;

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
    }
}
