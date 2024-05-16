using System.Drawing;

namespace Graphs
{
    internal partial class GraphVisualizationForm
    {
        private void SelectVertex(int index)
        {
            Graphics g = _graphPanel.CreateGraphics();
            Point vertex = _vertexes[index];

            int circleDiameter = 44;
            float circleX = vertex.X - circleDiameter / 2f;
            float circleY = vertex.Y - circleDiameter / 2f;
            Pen pen = new Pen(Color.Red, 5);
            g.DrawEllipse(pen, circleX, circleY, circleDiameter, circleDiameter);
        }

        private void SelectEdge(Point startVertex, Point endVertex)
        {
            Graphics g = _graphPanel.CreateGraphics();

            Pen edgePen = new Pen(Color.DarkGreen, 5);
            g.DrawLine(edgePen, startVertex, endVertex);
        }

        private void DrawEdges(Graphics g)
        {
            for (int i = 0; i < _graph.VerticesCount; i++)
            {
                foreach (int neighbor in _graph.GetNeighbors(i))
                {
                    Point startVertex = _vertexes[i];
                    Point endVertex = _vertexes[neighbor];

                    int edgeWeight = _graph.GetEdgeWeight(i, neighbor);
                    Pen edgePen = new Pen(_edgesColors[i * 3], 3);

                    g.DrawLine(edgePen, startVertex, endVertex);

                    string weightText = edgeWeight > 0 ? edgeWeight.ToString() : "";
                    Font weightFont = new Font(FontFamily.GenericMonospace, 18f, FontStyle.Bold);
                    SizeF weightSize = g.MeasureString(weightText, weightFont);
                    float weightX = (startVertex.X + endVertex.X - weightSize.Width) / 2;
                    float weightY = (startVertex.Y + endVertex.Y - weightSize.Height) / 2;

                    g.DrawString(weightText, weightFont, Brushes.Black, weightX, weightY);
                }
            }
        }

        private Color GetRandomColor() => Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256));

        private void DrawVertexes(Graphics g)
        {
            for (int i = 0; i < _graph.VerticesCount; i++)
            {
                Point vertex = _vertexes[i];

                int circleDiameter = 40;
                float circleX = vertex.X - circleDiameter / 2f;
                float circleY = vertex.Y - circleDiameter / 2f;

                g.FillEllipse(Brushes.Blue, circleX, circleY, circleDiameter, circleDiameter);

                string text = (i + 1).ToString();

                Font textFont = new Font(FontFamily.GenericMonospace, 20f);
                SizeF textSize = g.MeasureString(text, textFont);

                float textX = circleX + (circleDiameter - textSize.Width) / 2;
                float textY = circleY + (circleDiameter - textSize.Height) / 2;

                g.DrawString(text, textFont, Brushes.White, textX, textY);
            }
        }

        private void DrawRedTextAboveVertex(int vertexIndex, string text)
        {
            if (vertexIndex >= 0 && vertexIndex < _vertexes.Count)
                using (Graphics g = _graphPanel.CreateGraphics())
                {
                    Point vertex = _vertexes[vertexIndex];
                    Font textFont = new Font(FontFamily.GenericMonospace, 14f);
                    SizeF textSize = g.MeasureString(text, textFont);

                    float textX = vertex.X - textSize.Width / 2;
                    float textY = vertex.Y - textSize.Height - 20; // 10 - отступ над вершиной

                    g.DrawString(text, textFont, Brushes.Red, textX, textY);
                }
        }
    }
}