using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Test_Vector.Factory;
using Test_Vector.Models;
using Test_Vector.Parsers;

namespace Test_Vector
{

    public partial class MainForm : Form
    {
        private List<DrawShape> shapes;

        public MainForm()
        {
            InitializeComponent();
            HidePanelOnLoad();
            RestFields();
            shapes = new List<DrawShape>();
            LoadDataFromDataSource();
        }

        private void LoadDataFromDataSource()
        {
            try
            {
                string fileName = ConfigurationManager.AppSettings[nameof(fileName)];
                string fileType = ConfigurationManager.AppSettings[nameof(fileType)];

                string dataFolderPath = "File";
                string filePath = Path.Combine(dataFolderPath, fileName);

                var shapeType = (DataSourceType)Enum.Parse(typeof(DataSourceType), fileType, true);
                var parser = ParserFactory.CreateParser(shapeType, filePath);
                shapes = parser.Parse();
                shapes.Insert(0, new DrawShape { Type = "Please Select" });
                comboBox1.DataSource = shapes;
                comboBox1.DisplayMember = "Type";
                comboBox1.ValueMember = "Type";

            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = ex.Message;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            var selectedShape = (DrawShape)comboBox1.SelectedItem;
            var graphics = pictureBox1.CreateGraphics();

            if (Enum.TryParse(selectedShape.Type, out ShapeType shapeType))
            {
                try
                {
                    var shapeObjects = shapes.Where(shape => shape.Type == shapeType.ToString()).ToList();
                    ShapeDrawer.DrawShapes(shapeObjects, graphics);

                    BindShapeData(shapeObjects);

                    DetailPanel.Show();
                }
                catch (Exception ex)
                {
                    lblErrorMessage.Text = ex.Message;
                }
            }
            else
            {
                DetailPanel.Hide();
            }

            graphics.Dispose();

        }


        /// <summary>
        /// This method is explicitly set for single shape data. becasue i wanted to show single shape of different type.
        /// 
        /// otherwise i would have bind multiple values of same shape to grid view.
        /// </summary>
        /// <param name="shapeObjects"></param>
        private void BindShapeData(List<DrawShape> shapeObjects)
        {
            try
            {
                //for display purpose i have handle it for one specific type only for simplicity.  

                var showShapeData = shapeObjects.FirstOrDefault();
                lblColorValue.Text = showShapeData.Color;
                lblTypeValue.Text = showShapeData.Type;

                var shapeType = (ShapeType)Enum.Parse(typeof(ShapeType), showShapeData.Type, true);
                var shapeData = ShapeDataFactory.CreateShape(shapeType);

                lblCoordinateValue.Text = shapeData.SetShapeData(showShapeData);
                lblFilledValue.Text = shapeData.SetShapeFilledData(showShapeData);
            }
            catch (Exception ex)
            {

                lblErrorMessage.Text = ex.Message;
            }
        }

        private void HidePanelOnLoad()
        {
            DetailPanel.Hide();
        }

        private void RestFields()
        {
            lblErrorMessage.Text = string.Empty;
            lblTypeValue.Text = string.Empty;
            lblColorValue.Text = string.Empty;
            lblCoordinateValue.Text = string.Empty;
        }

    }
}
