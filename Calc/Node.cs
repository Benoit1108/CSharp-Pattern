using System;


namespace Calc
{

    public abstract class Node
    {
        public Node Parent { get; set };    

        public Node LeftChild { get; set; }

        public Node RightChild { get; set; }
        
    }

    public class ArithmeticOperation : Node
    {

    }

    public class Parser
    {
        public Node Parse(IEnumerable<Token> tokens)
        {
            Node currentNode = null;

        }
    }
}
