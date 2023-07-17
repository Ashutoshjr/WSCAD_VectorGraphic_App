﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Vector.Helpers;
using Test_Vector.Models;
using Test_Vector.Strategies;

namespace Test_Vector
{
    public class ShapeDrawer
    {
        private static Dictionary<string, Color> shapeColors = new Dictionary<string, Color>();
        private readonly IShapeDrawingStrategy _shapeDrawingStrategy;

        public ShapeDrawer(IShapeDrawingStrategy shapeDrawingStrategy)
        {
            _shapeDrawingStrategy = shapeDrawingStrategy; 
        }

        public void DrawShape(IEnumerable<DrawShape> shapes, Graphics graphics, WindowsFormDetail windowsFormDetail)
        {
            foreach (var shape in shapes)
            {
                try
                {
                    if (!shapeColors.TryGetValue(shape.Color, out Color shapeColor))
                    {
                        shapeColor = Utility.ParseColor(shape.Color);
                        shapeColors.Add(shape.Color, shapeColor);
                    }

                    _shapeDrawingStrategy.DrawShape(shape, graphics, shapeColor, windowsFormDetail);   
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
        }
    }
}
