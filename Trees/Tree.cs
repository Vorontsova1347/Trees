using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Trees
{
    /*5.	Дано упорядоченное дерево глубины N (N > 0 — четное), каждая внутренняя вершина которого
     * имеет два непосредственных потомка: A с весом 1 и B с весом –1. Корень дерева C имеет вес 0.
     * Записать в текстовый файл все пути от корня к листьям, удовлетворяющие следующим условиям: 
     * суммарный вес элементов для любого начального отрезка пути неотрицателен1|неположителен2,
     * а суммарный вес всех элементов пути равен 0.
     * Каждый путь записывается в отдельной строке файла. 
     * Перебирать пути, начиная с "самого левого" и заканчивая "самым правым", при этом
     * первыми заменять конечные элементы пути. */
    public class Node
    {
        public int Weight;
        public Node Left;
        public Node Right;

        public Node(int weight, Node left, Node right) // конструктор
        {
            Weight = weight;
            Left = left;
            Right = right;
        }
    }

    public class Tree
    {
        private Node Root { get; set; }
        private Random rnd = new Random();

        private Pen penLine = new Pen(Color.Chocolate);//маршрут
        private Pen penNode = new Pen(Color.Gold);
        private SolidBrush brushNodeData = new SolidBrush(Color.Black);
        private Font fontNode = new Font("Arial", 16);

        public Tree(int maxDepth)
        {
            Root = GenerateTree(maxDepth);
        }

        public Tree(Node root)
        {
            Root = root;
        }

        public Node GenerateTree(int maxDepth)
        {
            return _generateSubTree(0, maxDepth);
        }

        private Node _generateSubTree(int weight, int maxDepth, double chance = 0.8d)
        {
            if (maxDepth > 0)
            {
                var node = new Node(weight, null, null);
                if (rnd.NextDouble() <= chance)
                    node.Left = _generateSubTree(-1, maxDepth - 1);
                if (rnd.NextDouble() <= chance)
                    node.Right = _generateSubTree(1, maxDepth - 1);
                return node;
            }

            return null;
        }

        public List<List<Node>> GetPaths(SumType sumType)
        {
            List<List<Node>> ret = new List<List<Node>>();
            //второой список сделать списком строк
           
            foreach (var path in getPathList(Root, new List<Node>(), new List<List<Node>>(), sumType))
            {
                if (Sum(path) == 0)
                    ret.Add(path);
            }
            return ret;
        }

       
        private List<List<Node>> getPathList(Node parent, List<Node> path, List<List<Node>> allPaths, SumType sumType)
        {//текущий узел для обработки, текущий путь для обработки, список всех необходимых путей
            List<Node> tmpPath = new List<Node>(path);
            if (parent.Left != null)
            {
                path = new List<Node>(tmpPath);
                path.Add(parent);
                switch (sumType)
                {
                    case SumType.NonNegative:
                        if (Sum(path) >= 0)
                            getPathList(parent.Left, path, allPaths, sumType);
                        break;
                    case SumType.NonPositive:
                        if (Sum(path) <= 0)
                            getPathList(parent.Left, path, allPaths, sumType);
                        break;
                }
            }
            if (parent.Right != null)
            {
                path = new List<Node>(tmpPath);
                path.Add(parent);
                switch (sumType)
                {
                    case SumType.NonNegative:
                        if (Sum(path) >= 0)
                            getPathList(parent.Right, path, allPaths, sumType);
                    break;
                    case SumType.NonPositive:
                        if (Sum(path) <= 0)
                            getPathList(parent.Right, path, allPaths, sumType);
                        break;
                }
                
                
            }
            if (parent.Left == null && parent.Right == null)//дошли ли до листа
            {
                path.Add(parent);
                allPaths.Add(path);
                
            }
            return allPaths;
        }



        private int Sum(List<Node> nodes)
        {
            int sum = 0;
            foreach(var node in nodes)
            {
                sum += node.Weight;
            }
            return sum;
        }

        private void DrawNode(Graphics gr, int x, int y, Node node)
        {
            gr.DrawEllipse(penNode, x - 30, y, 50, 50);
            gr.DrawString(Convert.ToString(node.Weight), fontNode, brushNodeData, x - 11, y + 17);
        }
        private void Draw(Node node, Graphics gr, int left, int right, int y, int stepY)
        {
            if (node == null)
            {
                return;
            }
            int x = (left + right) / 2;
            if (node.Left != null)
            {
                gr.DrawLine(penLine, x - 5, y + 50, (left + x) / 2, y + stepY);
            }
            if (node.Right != null)
            {
                gr.DrawLine(penLine, x - 5, y + 50, (right + x) / 2, y + stepY);
            }

            DrawNode(gr, x, y, node);

            Draw(node.Right, gr, x, right, y + stepY, stepY);
            Draw(node.Left, gr, left, x, y + stepY, stepY);

        }

        public void DrawBinTree(Graphics gr, int left, int right, int y, int stepY)
        {
            Draw(Root, gr, left, right, y, stepY);
        }

        public static void WriteToFile(List<List<Node>> paths, string fileName)
        {
            List<string> lines = new List<string>();
            foreach(var path in paths)
            {
                lines.Add(String.Join(" ", path.Select(x => x.Weight)));
            }  
            File.WriteAllLines(fileName, lines);
        }

    }

    public enum SumType
    {
        NonNegative, 
        NonPositive
    }
}
