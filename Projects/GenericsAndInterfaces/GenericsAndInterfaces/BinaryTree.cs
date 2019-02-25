using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndInterfaces
{
    class BinaryTree<T> : IEnumerable where T : IComparable
    {
        /// <summary>
        /// BinaryTreeNode class interal to BinaryTree class
        /// because no other class needs to access BinaryTreeNode
        /// </summary>
        class BinaryTreeNode<T> : IEnumerable<T> where T : IComparable
        {
            public T Data { get; set; }
            public BinaryTreeNode<T> LeftChild { get; set; }
            public BinaryTreeNode<T> RightChild { get; set; }

            /// <summary>
            /// BinaryTreeNode constructor
            /// </summary>
            /// <param name="element">Data held by node</param>
            public BinaryTreeNode(T element)
            {
                Data = element;
            }

            /// <summary>
            /// Gets the height of this node relative to the tree
            /// </summary>
            /// <returns>Height of this node relative to the subtree where this node is the root</returns>
            public int Height()
            {
                return 1 + Math.Max(LeftChild != null ? LeftChild.Height() : 0, RightChild != null ? RightChild.Height() : 0);
            }

            public IEnumerator<T> GetEnumerator()
            {
                if (LeftChild != null)
                {
                    foreach (var v in LeftChild)
                    {
                        yield return v;
                    }
                }

                yield return Data;

                if (RightChild != null)
                {
                    foreach (var v in RightChild)
                    {
                        yield return v;
                    }
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        /// <summary>
        /// Root of the tree
        /// </summary>
        BinaryTreeNode<T> Root { get; set; }

        /// <summary>
        /// Height of the tree from Root
        /// </summary>
        public int Height
        { get { return Root != null ? Root.Height() : 0; } }

        /// <summary>
        /// Number of nodes in the tree
        /// </summary>
        public int NodeCount
        { get { return Root != null ? CalculateNodeCount(Root) : 0; } }

        /// <summary>
        /// Constructor for Binary Tree
        /// This constructor is empty, and can be removed.
        /// </summary>
        public BinaryTree()
        {

        }

        /// <summary>
        /// Searches the tree for a given data value
        /// </summary>
        /// <param name="element">The data we are looking for</param>
        /// <returns>True if we find the data, false otherwise</returns>
        public bool Search(T element)
        {
            if (Root == null)
                return false;

            //Go to a maximum of Height to search for element
            BinaryTreeNode<T> cur = Root;
            for (int i = 0; i <= Height; i++)
            {
                //If element is less than or equal to cur, put element on left side
                if (element.CompareTo(cur.Data) <= 0)
                {
                    if (cur.LeftChild != null)
                    {
                        cur = cur.LeftChild;
                        continue;
                    }
                    else
                        return false;
                }
                //If element is greater than to cur, put element on right side
                else if (element.CompareTo(cur.Data) == 1)
                {
                    if (cur.RightChild != null)
                    {
                        cur = cur.RightChild;
                        continue;
                    }
                    else
                        return false;
                }
                //Element is equal to what we are searching for
                else
                    return true;
            }

            //Catch all to prevent compilation errors
            return false;
        }

        /// <summary>
        /// Non-recursively inserts element into the tree. O(n) - O(logn)
        /// </summary>
        /// <param name="element">The data we want to insert into the tree</param>
        public void Insert(T element)
        {
            //If no elements in the tree, set new element to root
            if (Root == null)
            {
                Root = new BinaryTreeNode<T>(element);
                return;
            }

            //Go to a maximum of Height to insert new element
            BinaryTreeNode<T> cur = Root;
            for(int i = 0; i <= Height; i++)
            {
                //If element is less than or equal to cur, put element on left side
                if (element.CompareTo(cur.Data) <= 0)
                {
                    if (cur.LeftChild != null)
                    {
                        cur = cur.LeftChild;
                        continue;
                    }
                    else
                    {
                        cur.LeftChild = new BinaryTreeNode<T>(element);
                        return;
                    }
                }
                //If element is greater than to cur, put element on right side
                else
                {
                    if (cur.RightChild != null)
                    {
                        cur = cur.RightChild;
                        continue;
                    }
                    else
                    {
                        cur.RightChild = new BinaryTreeNode<T>(element);
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Public facing Remove method. Starts at root. O(n) - O(logn)
        /// </summary>
        /// <param name="element">value we want to remove</param>
        public void Remove(T element)
        {
            if (Root == null)
                return;
            Remove(Root, element);
        }

        /// <summary>
        /// Private facing recursive portion of the remove method. 
        /// </summary>
        /// <param name="cur">Current node that is being looked at</param>
        /// <param name="element">Data bit we are looking for</param>
        /// <returns>The new child of the element prior in the recursive stack</returns>
        private BinaryTreeNode<T> Remove(BinaryTreeNode<T> cur, T element)
        {
            if (cur == null)
                return cur;

            if (element.CompareTo(cur.Data) == -1)
            {
                cur.LeftChild = Remove(cur.LeftChild, element);
            }
            else if (element.CompareTo(cur.Data) == 1)
            {
                cur.RightChild = Remove(cur.RightChild, element);
            }
            else
            {
                //Handle nodes with only one child
                if (cur.LeftChild == null)
                    return cur.RightChild;
                else if (cur.RightChild == null)
                    return cur.LeftChild;

                //Handle nodes with two children
                cur.Data = MinValue(cur.RightChild);

                //Delete rotated node
                cur.RightChild = Remove(cur.RightChild, cur.Data);
            }
            return cur;
        }

        /// <summary>
        /// Finds the minimum value of a given subtree with cur as the root
        /// </summary>
        /// <param name="cur">Root of the given subtree</param>
        /// <returns>The minimum value</returns>
        private T MinValue(BinaryTreeNode<T> cur)
        {
            T min = cur.Data;
            while(cur.LeftChild != null)
            {
                min = cur.LeftChild.Data;
                cur = cur.LeftChild;
            }
            return min;
        }

        #region Public facing print methods
        /// <summary>
        /// Print the tree in Pre-Order format
        /// </summary>
        public void PreOrderPrint()
        { PreOrderPrint(Root); Console.WriteLine(); }

        /// <summary>
        /// Print the tree in Post-Order format
        /// </summary>
        public void PostOrderPrint()
        { PostOrderPrint(Root); Console.WriteLine(); }

        /// <summary>
        /// Print the tree in In-Order format
        /// </summary>
        public void InOrderPrint()
        { InOrderPrint(Root); Console.WriteLine(); }
        #endregion

        #region Private, recursive print methods
        /// <summary>
        /// Recursive method for preorderprint
        /// </summary>
        /// <param name="n">Current node</param>
        private void PreOrderPrint(BinaryTreeNode<T> n)
        {
            if (n == null)
                return;

            Console.WriteLine(n.Data + " ");
            PreOrderPrint(n.LeftChild);
            PreOrderPrint(n.RightChild);
        }

        /// <summary>
        /// Recursive method for postorderprint
        /// </summary>
        /// <param name="n">Current node</param>
        private void PostOrderPrint(BinaryTreeNode<T> n)
        {
            if (n == null)
                return;

            PostOrderPrint(n.LeftChild);
            PostOrderPrint(n.RightChild);
            Console.WriteLine(n.Data + " ");
        }

        /// <summary>
        /// Recursive method for inorderprint
        /// </summary>
        /// <param name="n">Current node</param>
        private void InOrderPrint(BinaryTreeNode<T> n)
        {
            if (n == null)
                return;

            InOrderPrint(n.LeftChild);
            Console.WriteLine(n.Data + " ");
            InOrderPrint(n.RightChild);
        }
        #endregion

        /// <summary>
        /// Only accessed from NodeCount property. Gets the number of nodes in the tree recursively
        /// </summary>
        /// <param name="n">Node to count</param>
        /// <returns>Number of nodes int he tree</returns>
        private int CalculateNodeCount(BinaryTreeNode<T> n)
        {
            if (n == null)
                return 0;

            return 1 + CalculateNodeCount(n.LeftChild) + CalculateNodeCount(n.RightChild);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Root.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
