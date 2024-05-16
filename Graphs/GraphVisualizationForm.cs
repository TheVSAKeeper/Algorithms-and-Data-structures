using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Graphs
{
    internal partial class GraphVisualizationForm : Form
    {
        private readonly List<Color> _edgesColors = new List<Color>(300);

        private readonly List<Dictionary<int, (int Distance, List<int> Path)>> _distanceHistory =
            new List<Dictionary<int, (int Distance, List<int> Path)>>();

        private readonly List<int> _selectHistory = new List<int>();

        private readonly List<Point> _vertexes = new List<Point>();
        private readonly Random _random = new Random();
        private Graph _graph;
        private int _selectDistanceIndex;

        private int _selectHistoryIndex;

        public GraphVisualizationForm()
        {
            InitializeComponent();

            Graph.VertexSelected += GraphOnVertexSelected;
            Graph.DistancesChanged += GraphOnDistancesChanged;

            for (int i = 0; i < _edgesColors.Capacity; i++)
                _edgesColors.Add(GetRandomColor());
        }

        private void GraphOnDistancesChanged(Dictionary<int, (int Distance, List<int> Path)> obj)
        {
            Dictionary<int, (int Distance, List<int> Path)> clone = new Dictionary<int, (int Distance, List<int> Path)>(obj);

            _distanceHistory.Add(clone);
        }

        private void GraphPanel_Paint(object sender, PaintEventArgs e)
        {
            if (_graph == null)
                return;

            using (Graphics g = e.Graphics)
            {
                DrawEdges(g);
                DrawVertexes(g);
            }
        }

        private void GraphOnVertexSelected(int obj)
        {
            _selectHistory.Add(obj);
        }

        private void CreateGraphButton_Click(object sender, EventArgs e)
        {
            int vertexCount = _verticesInputGrid.Rows.Count;
            _graph = new Graph(vertexCount);

            for (int i = 0; i < _verticesInputGrid.Rows.Count; i++)
            {
                DataGridViewRow row = _verticesInputGrid.Rows[i];

                if (row.Cells[0].Value == null)
                    continue;

                int vertex = int.Parse(row.Cells[0].Value.ToString().Trim()) - 1;

                if (row.Cells[1].Value == null)
                    continue;

                string[] neighbors = row.Cells[1].Value.ToString().Split(' ');

                foreach (string neighbor in neighbors)
                {
                    if (neighbor.Contains("/"))
                    {
                        string[] parts = neighbor.Split('/');
                        int neighborVertex = int.Parse(parts[0]) - 1;
                        int edgeWeight = int.Parse(parts[1]);

                        _graph.AddEdgeWithWeight(vertex, neighborVertex, edgeWeight);
                    }
                    else
                    {
                        int neighborVertex = int.Parse(neighbor) - 1;
                        _graph.AddEdgeWithWeight(vertex, neighborVertex, 0);
                    }
                }
            }

            GenerateVertexes(vertexCount);
            _graphPanel.Refresh();
        }

        private void GenerateVertexes(int vertexesCount)
        {
            _vertexes.Clear();

            for (int i = 0; i < vertexesCount; i++)
                AddVertex(i);
        }

        private void AddVertex(int i)
        {
            int radius = Math.Min(_graphPanel.Width / 2 - 30, _graphPanel.Height / 2);
            int vertexX = (int)(Math.Cos(2 * Math.PI * i / _graph.VerticesCount) * radius) + _graphPanel.Width / 2;
            int vertexY = (int)(Math.Sin(2 * Math.PI * i / _graph.VerticesCount) * radius) + _graphPanel.Height / 2;

            _vertexes.Add(new Point(vertexX, vertexY));
        }

        private void OnRowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            _verticesInputGrid[0, _verticesInputGrid.Rows.Count - 1].Value = _verticesInputGrid.Rows.Count;
            _verticesInputGrid.AutoResizeColumn(0);
        }

        private void OnAddVertexClicked(object sender, EventArgs e)
        {
            _verticesInputGrid.Rows.Add(new DataGridViewRow());
        }

        private void SelectPath(int startVertex, List<int> shortestPath)
        {
            int prevVertex = startVertex;

            foreach (int i in shortestPath)
            {
                SelectVertex(i);
                SelectEdge(_vertexes[prevVertex], _vertexes[i]);
                prevVertex = i;
            }
        }

        private void OnNextHistoryClicked(object sender, EventArgs e)
        {
            if (_selectHistoryIndex >= _selectHistory.Count)
            {
                MessageBox.Show(@"Обход завершён");
                return;
            }

            SelectVertex(_selectHistory[_selectHistoryIndex++]);
        }

        private void OnDFSButtonClicked(object sender, EventArgs e)
        {
            RunSearch(_graph.DepthFirstSearch, "DFS");
        }

        private void OnBFSButtonClicked(object sender, EventArgs e)
        {
            RunSearch(_graph.BreadthFirstSearch, "BFS");
        }

        private void RunSearch(Action<int> searchAlgorithm, string algorithmName)
        {
            _selectHistory.Clear();
            _selectHistoryIndex = 0;

            int startVertex = 0;
            searchAlgorithm(startVertex);

            CreateGraphButton_Click(this, EventArgs.Empty);

            string message = $"Путь {algorithmName}: {string.Join(" -> ", _selectHistory.Select(v => v + 1))}";
            MessageBox.Show(message, $@"Результат {algorithmName}");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_selectDistanceIndex >= _graph.VerticesCount + 1)
            {
                MessageBox.Show("Алгоритм Дейкстры завершен.");
                return;
            }

            CreateGraphButton_Click(this, EventArgs.Empty);
            SelectAll(_selectHistoryIndex++);

            foreach (KeyValuePair<int, (int Distance, List<int> Path)> keyValuePair in _distanceHistory[_selectDistanceIndex++])
                DrawRedTextAboveVertex(keyValuePair.Key, keyValuePair.Value.Distance.ToString());
        }

        private void SelectAll(int i)
        {
            for (int j = 0; j < i; j++)
                SelectVertex(_selectHistory[j]);
        }

        private void FindShortestPathButton_Click(object sender, EventArgs e)
        {
            if (_graph == null)
            {
                MessageBox.Show("Сначала создайте граф.");
                return;
            }

            if (_verticesInputGrid.SelectedRows.Count < 2)
                return;

            int firstSelectedRowIndex = _verticesInputGrid.SelectedRows[0].Index;
            int secondSelectedRowIndex = _verticesInputGrid.SelectedRows[1].Index;

            object startVertexNumber = _verticesInputGrid.Rows[firstSelectedRowIndex].Cells[0].Value;
            object endVertexNumber = _verticesInputGrid.Rows[secondSelectedRowIndex].Cells[0].Value;

            if (startVertexNumber == null || endVertexNumber == null)
                return;

            int startVertex = int.Parse(startVertexNumber.ToString()) - 1;
            int endVertex = int.Parse(endVertexNumber.ToString()) - 1;

            if (startVertex < 0 || endVertex < 0)
                return;

            CreateGraphButton_Click(this, EventArgs.Empty);
            _selectDistanceIndex = 0;
            _selectHistory.Clear();
            _selectHistoryIndex = 0;

            (int shortestDistance, List<int> shortestPath) = _graph.DijkstraShortestPath(startVertex, endVertex);
            SelectPath(startVertex, shortestPath);

            string pathText = string.Join(" -> ", shortestPath.Select(v => (v + 1).ToString()));
            MessageBox.Show($@"Кратчайший путь от вершины {startVertex + 1} до вершины {endVertex + 1} равен {shortestDistance}: {pathText}");
        }

        private void OnRestartClicked(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}