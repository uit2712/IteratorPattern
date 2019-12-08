using System;

namespace BinaryTreeExample.Entities
{
    class Tree
    {
        private Random _random = new Random();
        public Node Root { get; set; }

        public Tree()
        {

        }

        public void InitData()
        {
            Root = null;
            for (int i = 0; i < 20; i++)
            {
                int value = _random.Next() % 100;
                Insert(value);
            }
        }

        private void Insert(int value)
        {
            if (Root == null)
            {
                Root = new Node(value);
                return;
            }

            Insert(Root, value);
        }

        private void Insert(Node root, int value)
        {
            if (root == null || root.Value == value)
                return;

            if (root.Value > value)
            {
                if (root.Left == null)
                    root.Left = new Node(value);
                else Insert(root.Left, value);
            }
            else
            {
                if (root.Right == null)
                    root.Right = new Node(value);
                else Insert(root.Right, value);
            }
        }
    }
}
