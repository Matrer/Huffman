using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aikd
{
    class Node
    { 
        public char? Char { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public string Code { get; set; }
        public string Dir { get; set; }

        private int _Count;
        public int Count
        {
            get
            {
                if (Left != null || Right != null)
                {

                    _Count = 0;
                    if (Left != null)
                        _Count += Left.Count;

                    if (Right != null)
                        _Count += Right.Count;
                }
                return _Count;
            }
    }

    public Node(char? newChar)
    {
        Code = "";
        Char = newChar;
        _Count = 1;
    }

    public void CountAdd()
    {
        _Count++;
    }
}
}
