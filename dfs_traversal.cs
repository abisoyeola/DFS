using System.Collections.Generic;
using System;
namespace dfs
{
    partial class Program{
        static void dfs_traversal(Node node){
            if(node==null){
                return;
            }else{
                Console.Write(node.data + " ");
            }
            dfs_traversal(node.left);
            dfs_traversal(node.right);
        }
    }
}