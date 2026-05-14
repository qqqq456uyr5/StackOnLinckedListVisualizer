using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace StackOnLinckedListVisualizer.Drawings
{
    public class DrawStackList
    {
        private Font nodeFont = new Font("Arial", 10, FontStyle.Bold);
        private Brush textBrush = Brushes.White;
        private Pen arrowPen = new Pen(Color.Black, 2);

        // Параметры узла
        private int nodeWidth = 80;
        private int nodeHeight = 40;
        private int startX = 50;
        private int startY = 50;
        private int offsetBetweenNodes = 30;

        
        public void DrawList(Graphics g, Rectangle bounds, LinkedList<int> dataCollection, string topValue)
        {

            if (dataCollection == null || dataCollection.Count == 0)
            {
                DrawEmptyMessage(g, bounds.Width, bounds.Height);
                return;
            }

            DrawNodes(g, dataCollection, topValue);
        }

        private void DrawEmptyMessage(Graphics g, int width, int height)
        {
            string message = "Стек пуст";
            using (Font font = new Font("Arial", 14, FontStyle.Italic))
            using (Brush brush = new SolidBrush(Color.Gray))
            {
                SizeF textSize = g.MeasureString(message, font);
                g.DrawString(message, font, brush,
                    (width - textSize.Width) / 2,
                    (height - textSize.Height) / 2);
            }
        }

        private void DrawNodes(Graphics g, LinkedList<int> dataCollection, string topValue)
        {
            int currentX = startX;
            int count = dataCollection.Count;
            int index = 0;

            // Рисуем стрелки
            for (int i = 0; i < count - 1; i++)
            {
                int nextX = currentX + nodeWidth + offsetBetweenNodes;
                DrawArrow(g, currentX + nodeWidth, startY + nodeHeight / 2,
                             nextX, startY + nodeHeight / 2);
                currentX = nextX;
            }

            // Рисуем узлы
            currentX = startX;
            foreach (int value in dataCollection)
            {
                Rectangle nodeRect = new Rectangle(currentX, startY, nodeWidth, nodeHeight);
                bool isTop = (topValue != null && value.ToString() == topValue);

                DrawNode(g, nodeRect, value.ToString());

                // Рисуем указатель Top для первого элемента
                if (index == 0)
                {
                    DrawTopPointer(g, nodeRect);
                }

                currentX += nodeWidth + offsetBetweenNodes;
                index++;
            }
        }

        private void DrawNode(Graphics g, Rectangle rect, string text)
        {

            LinearGradientBrush brush;
           
           
            brush = new LinearGradientBrush(rect, Color.SteelBlue, Color.DarkBlue, LinearGradientMode.Vertical);
           

            // Основной прямоугольник
            g.FillRectangle(brush, rect);

            // Рамка
            using (Pen borderPen = new Pen(Color.Black, 2))
            {
                g.DrawRectangle(borderPen, rect);
            }

            // Текст
            using (StringFormat sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                g.DrawString(text, nodeFont, textBrush, rect, sf);
            }

            brush.Dispose();
        }

        private void DrawArrow(Graphics g, int fromX, int fromY, int toX, int toY)
        {
            using (Pen pen = new Pen(Color.Black, 2))
            {
                g.DrawLine(pen, fromX, fromY, toX, toY);

                pen.Color = Color.Black;
                pen.Width = 1;

                Point[] arrow = new Point[]
                {
                    new Point(toX, toY),
                    new Point(toX - 10, toY - 5),
                    new Point(toX - 10, toY + 5)
                };
                g.FillPolygon(Brushes.Black, arrow);
            }
        }

        private void DrawTopPointer(Graphics g, Rectangle nodeRect)
        {
            using (Font pointerFont = new Font("Arial", 9, FontStyle.Bold))
            using (Brush brush = new SolidBrush(Color.DarkGreen))
            {
                int arrowX = nodeRect.X + nodeRect.Width / 2;
                int arrowY = nodeRect.Y - 25;

                g.DrawString("↑ TOP ↑", pointerFont, brush, arrowX - 25, arrowY);

            }
        }
    }
}