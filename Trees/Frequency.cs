using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trees
{ /*   
         20.Дан текстовый файл. Слова содержат не более 20 символов. 
         Определить частоту использования каждого слова в тексте.
         Результат оформить в виде таблицы, содержащей слова в лексикографическом порядке.*/
    public class NodeF
    {
        public string Word;
        public NodeF Left;
        public NodeF Right;
        public int Count = 0;

        public NodeF(string word, NodeF left, NodeF right) // конструктор
        {
            Count = 1;
            Word = word;
            Right = right;
            Left = left;
        }
    }

    public class Frequency
    {
        private int Count = 0;
        private NodeF Root { get; set; }

        public NodeF Generate(List<string> words)
        {
            Queue<string> queue = new Queue<string>(words);
            return _generateFreqTree(queue);
        }

        public Frequency(List<string> words)
        {
            Root = Generate(words);
            Count = words.Count;
        }

        private NodeF _generateFreqTree(Queue<string> words)
        { 
            while (words.Count != 0)  //пока не пустая очередь
            {
                var current = Root; //начиная с корня
                var word = words.Dequeue();//запоминаем  слово
                var node = new NodeF(word, null, null);//создаем node


                while (current != null && word.CompareTo(current.Word) != 0 ) //пока текущий не null и слово в ноде не равно тому, которое мы запомнили
                {
                    if (word.CompareTo(current.Word) == 1)// если запомненное слово больше
                    {
                        if (current.Right != null) 
                        {
                            current = current.Right; //move to right
                        }
                        else
                        {
                            current.Right = node; //create node in right branch
                            break;
                        }
                        continue;
                    }
                    
                    
                    if (word.CompareTo(current.Word) == -1)
                    {
                        if (current.Left != null)
                        {
                            current = current.Left;
                        }
                        else
                        {
                            current.Left = node;
                            break;
                        }
                      
                        continue;
                    }
                }
                if (word.CompareTo(current?.Word) == 0) //check if words are equal
                    current.Count++;

                if (current == null)
                {
                    if (Root == null)
                        Root = node;
                   current = node;
                }


            }

            return Root;

        }

        public DataGridView ConvertTreeToDGV(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            int i = 0;
            dataGridView.Columns.Add("1", "Строка");
            dataGridView.Columns.Add("2", "Частота");
            ConvertTreeToDGVR(dataGridView, Root, ref i);
            return dataGridView;
        }
        void ConvertTreeToDGVR(DataGridView dataGridView, NodeF node, ref int i)// i - index
        {
            if (node == null)
            {
                return;
            }
            dataGridView.Rows.Add();
            dataGridView[0, i].Value = node.Word;
            dataGridView[1, i].Value = Convert.ToString((double)node.Count / (double)Count);
            i++;
            ConvertTreeToDGVR(dataGridView, node.Left, ref i);
            ConvertTreeToDGVR(dataGridView, node.Right, ref i);
        }
    }
}
