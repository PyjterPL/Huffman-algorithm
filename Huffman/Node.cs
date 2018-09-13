﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Huffman
{
    public class Node
    {
        public char Symbol { get; set; }
        public int Frequency { get; set; }
        public Node Right { get; set; }
        public Node Left { get; set; }
        public string Code { get; set; }
        public static void setCodeToTheTree(string code, Node Nodes)//na początku wywoływany z "" i z rootem
        {
            if (Nodes == null)
                return;
            if (Nodes.Left == null && Nodes.Right == null)
            {
                Nodes.Code = code;
                return;
            }
            setCodeToTheTree(code + "0", Nodes.Left);
            setCodeToTheTree(code + "1", Nodes.Right);
        }
        public List<bool> Traverse(char symbol, List<bool> data)
        {
            // Leaf
            if (Right == null && Left == null)
            {
                if (symbol.Equals(this.Symbol))
                {
                    return data;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                List<bool> left = null;
                List<bool> right = null;

                if (Left != null)
                {
                    List<bool> leftPath = new List<bool>();
                    leftPath.AddRange(data);
                    leftPath.Add(false);

                    left = Left.Traverse(symbol, leftPath);
                }

                if (Right != null)
                {
                    List<bool> rightPath = new List<bool>();
                    rightPath.AddRange(data);
                    rightPath.Add(true);
                    right = Right.Traverse(symbol, rightPath);
                }

                if (left != null)
                {
                    return left;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}