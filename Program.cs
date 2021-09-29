using System;

namespace dfs
{
    partial class Program
    {
        static Node sample_tree(){
            Node root = 
                new Node("A", new Node ("B",new Node("C"), new Node("D")),
                            new Node("E", new Node("F"), new Node("G", new Node("H"), null)));

            return root;
        }
        static void Main(string[] args)
        {
            Node tree = sample_tree();
            Console.WriteLine("BFS-->");
             bfs_traversal(tree);
            //Console.WriteLine("Hello World!");
        }
    }

    class Node{
        public Node left, right;
        public String data;

        public Node(String data, Node left , Node right){
            this.data = data;
            this.left = left;
            this.right = right;
        }
        public Node(String data){
            this.data = data;
            this.left = null;
            this.right = null;
        }
    }

}
