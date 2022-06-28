using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeNode
{
    public class Node
    {
        public string ID;
        public List<Child> Childs = new List<Child>();
        public Node(string ID)
        {
            this.ID = ID;
        }
    }
    public class Child
    {
        public string ID;
        public List<Leaf> Leafs = new List<Leaf>();
        public Child(string ID)
        {
            this.ID = ID;
        }
    }
    public class Leaf
    {
        public string ID;
        public Leaf(string ID)
        {
            this.ID = ID;
        }
    }
   
}
