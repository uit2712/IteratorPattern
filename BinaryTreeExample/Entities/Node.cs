namespace BinaryTreeExample.Entities
{
    class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int value)
        {
            Value = value;
            Left = Right = null;
        }
    }
}
