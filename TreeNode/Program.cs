using TreeNode;

class Program
{
    static void Main()
    {
        Node treeNode = new Node("Root");
        Child child = new Child("Child1");
        Leaf leaf = new Leaf("Leaf1");
        child.Leafs.Add(leaf);
        leaf = new Leaf("Leaf2");
        child.Leafs.Add(leaf);
        leaf = new Leaf("Leaf3");
        child.Leafs.Add(leaf);
        treeNode.Childs.Add(child);
        Node result = SearchTreeNode("Leaf3", treeNode);
        ReadTree(result);
        Console.ReadLine();
    }

    static Node SearchTreeNode(string ID, Node treeNode)
    {
        if (ID == treeNode.ID)
        {
            return treeNode;
        }
        foreach (Child child in treeNode.Childs)
        {
            if (ID == child.ID)
            {
                return treeNode;
            }
            foreach (Leaf leaf in child.Leafs)
            {
                if (ID == leaf.ID)
                {
                    return treeNode;
                }
            }
        }
        return null;
    }
    static void ReadTree(Node treeNode)
    {
        if (treeNode == null)
        {
            Console.WriteLine("ID not found.");
            return;
        }
        foreach (Child child in treeNode.Childs)
        {
            foreach (Leaf leaf in child.Leafs)
            {
                Console.WriteLine("\ntreeNode: {0}, child: {1}, leaf: {2}", treeNode.ID, child.ID, leaf.ID);
            }
        }

    }
}