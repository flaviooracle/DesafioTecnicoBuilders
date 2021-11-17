using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entidades
{
    public class Node
    {
        private Node root;

        private string key;
        private int val;

        private Node left, right;

        public Node(string key, int val)
        {
            this.key = key;
            this.val = val;
        }

        public int get(string key)
        {
            return get(root, key);
        }

        private int get(Node x, string key)
        {
            if (x == null) return 0;

            int cmp = string.Compare(x.key, key);

            if (cmp < 0) return get(x.left, key);
            else if (cmp > 0) return get(x.right, key);
            else return x.val;
        }

        public Arvorebinaria put(string key, int val)
        {
            root = put(root, key, val);
            Console.WriteLine(string.Concat("Raiz: ", formataX(root), " Key: ", key, " Left: ", formatL(root.left), " Right: ", formataR(root.right), " Val: ", val));
            return new Arvorebinaria
            {
                Root = formataX(root),
                Key = key,
                Left = formatL(root.left),
                Right = formataR(root.right),
                Sequencia = val
            };

        }

        private Node put(Node x, string key, int val)
        {
            if (x == null) return new Node(key, val);
            int cmp = string.Compare(key, x.key);
            if (cmp < 0)
            {
                x.left = put(x.left, key, val);
                x.right = null;
            }
            else
              if (cmp > 0)
            {
                x.right = put(x.right, key, val);
                x.left = null;
            }
            else
            {
                x.val = val;
            }

            return x;
        }

        private string formataX(Node x)
        {
            return x == null ? "" : x.key.ToString() + x.val.ToString();
        }

        private string formatL(Node left)
        {
            return left == null ? "" : left.key.ToString();
        }

        private string  formataR(Node right)
        {
            return right == null ? "" : right.key.ToString();
        }
    }
}