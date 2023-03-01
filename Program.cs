using ReizApp;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Input the hours");
        int hours = int.Parse(Console.ReadLine());
        if (hours < 1 || hours > 12)
        {
            Console.WriteLine("The input was incorrect");
            return;
        }
        Console.WriteLine("Input the minutes");
        int minutes = int.Parse(Console.ReadLine());
        if (minutes < 1 || minutes > 60)
        {
            Console.WriteLine("The input was incorrect");
            return;
        }

        Console.WriteLine("The lesser angle is " + ClockTask.LesserAngle(hours, minutes) + " degrees");

        //           1
        //         /   \
        //        2     3
        //       /    / | \
        //      4    5  6  7
        //          /  / \  
        //         8   9  10
        //             |
        //             11
        Tree<int> tree = new Tree<int>(1);
        Branch<int> rootBranch = tree.Root;
        tree.AddBranch(rootBranch, 2);
        tree.AddBranch(rootBranch, 3);
        tree.AddBranch(rootBranch.Children[0], 4);
        tree.AddBranch(rootBranch.Children[1], 5);
        tree.AddBranch(rootBranch.Children[1], 6);
        tree.AddBranch(rootBranch.Children[1], 7);
        tree.AddBranch(rootBranch.Children[1].Children[0], 8);
        tree.AddBranch(rootBranch.Children[1].Children[1], 9);
        tree.AddBranch(rootBranch.Children[1].Children[1], 10);
        tree.AddBranch(rootBranch.Children[1].Children[1].Children[0], 11);
        int result = tree.TreeDepth(tree.Root);

        Console.WriteLine("Tree depth:");
        Console.WriteLine(result);
    }
}