using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReizApp
{
    public class Tree<T>
    {
        public Branch<T> Root {get;set;}

        public Tree(T rootValue)
        {
            Root = new Branch<T>(rootValue);
        }

        public void AddBranch(Branch<T> parentBranch, T val)
        {
            Branch<T> childBranch = new Branch<T>(val);
            parentBranch.Parent = parentBranch;
            parentBranch.Children.Add(childBranch);
        }
        public int TreeDepth(Branch<T> root)
        {
            if(root == null){
                return 0;
            }

            int maxDepth = 0;
            foreach(Branch<T> branch in root.Children)
            {
                int childDepth = TreeDepth(branch);
                if(childDepth > maxDepth)
                {
                    maxDepth = childDepth;
                }
            }

            return maxDepth + 1;
        }
    }
}