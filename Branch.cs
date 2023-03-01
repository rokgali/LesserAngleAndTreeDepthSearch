namespace ReizApp
{
    public class Branch<T>
    {
        public T Value {get;set;}
        public Branch<T> Parent {get;set;}
        public List<Branch<T>> Children {get;set;}
        public Branch(T val)
        {
            Value = val;
            Children = new List<Branch<T>>();
        }       
    }
}