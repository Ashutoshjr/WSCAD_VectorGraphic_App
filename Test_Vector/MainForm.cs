﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Test_Vector.Factory;
using Test_Vector.Models;

namespace Test_Vector
{

    public partial class MainForm : Form
    {
        private List<DrawShape> shapes;
        private WindowsFormDetail windowsFormDetail;
        private DrawShape selectedShape;

        public MainForm()
        {
            InitializeComponent();

            this.Resize += MainForm_Resize;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            HidePanelOnLoad();
            RestFields();
            shapes = new List<DrawShape>();
            LoadDataFromDataSource();
            windowsFormDetail = new WindowsFormDetail()
            {
                OriginalWidth = this.Width,
                OriginalHeight = this.Height,
                PictureBoxWidth = pictureBox1.Width,
                PictureBoxHeight = pictureBox1.Height,
                FloatingHeight = this.Height,
                FloatingWidth = this.Width,
            };
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
                comboBox1.DisplayMember = "FormattedType";
                comboBox1.ValueMember = "Type";

            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = ex.Message;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblErrorMessage.Text = string.Empty;
            pictureBox1.Refresh();
            var graphics = pictureBox1.CreateGraphics();

            try
            {
                selectedShape = (DrawShape)comboBox1.SelectedItem;
                if (windowsFormDetail != null && graphics != null)
                {
                    DrawShape(selectedShape, graphics, windowsFormDetail);
                }
            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = "An error occurred while processing the selected shape. Please try again.";
            }
            finally
            {
                graphics?.Dispose();
            }
        }

        private void DrawShape(DrawShape selectedShape, Graphics graphics, WindowsFormDetail windowsFormDetail)
        {
            if (Enum.TryParse(selectedShape.Type, true, out ShapeType shapeType))
            {
                try
                {
                    var shapeToBeDraw = ShapeDrawingFactory.CreateShapeObj(shapeType);
                    var shapeDrawer = new ShapeDrawer(shapeToBeDraw);

                    var shapeObjects = shapes.Where(shape => shape.Type == shapeType.ToString()).ToList();
                    shapeDrawer.DrawShape(shapeObjects, graphics, windowsFormDetail);

                    BindShapeData(shapeObjects);

                    DetailPanel.Show();
                    lblShapeDetails.Show();
                }
                catch (Exception ex)
                {
                    lblErrorMessage.Text = ex.Message;
                    DetailPanel.Hide();
                }
            }
            else
            {
                lblErrorMessage.Text = "Selected type is not present";
                DetailPanel.Hide();
                lblShapeDetails.Hide();
            }
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
                lblTypeValue.Text = showShapeData.FormattedType;

                var shapeType = (ShapeType)Enum.Parse(typeof(ShapeType), showShapeData.Type, true);
                var shapeData = ShapeDataFactory.CreateShape(shapeType);

                lblCoordinateValue.Text = shapeData.SetShapeData(showShapeData);
                lblFilledValue.Text = shapeData.SetShapeFilledData(showShapeData);
            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = "An error occurred while binding shape data. Please try again.";
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            RedrawShapes();
        }

        private void RedrawShapes()
        {
            pictureBox1.Refresh();
            Graphics graphics = pictureBox1.CreateGraphics();


            if (shapes != null)
            {
                try
                {
                    windowsFormDetail.PictureBoxWidth = pictureBox1.Width;
                    windowsFormDetail.PictureBoxHeight = pictureBox1.Height;
                    windowsFormDetail.FloatingWidth = this.Width;
                    windowsFormDetail.FloatingHeight = this.Height;

                    DrawShape(selectedShape, graphics, windowsFormDetail);
                }
                catch (Exception ex)
                {
                    lblErrorMessage.Text = "An error occurred while redrawing shapes. Please try again.";
                }
                finally
                {
                    graphics?.Dispose();
                }
            }
            else
            {
                lblErrorMessage.Text = "No shape data available.";
                return;
            }
        }

        private void HidePanelOnLoad()
        {
            DetailPanel.Hide();
            lblShapeDetails.Hide();

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
