using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day7_BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter use case number (1, 2, or 3):");
            int useCase = Convert.ToInt32(Console.ReadLine());

            switch (useCase)
            {
                case 1:
                    ExecuteUseCase1();
                    break;
                case 2:
                    ExecuteUseCase2();
                    break;
                case 3:
                    ExecuteUseCase3();
                    break;
                default:
                    Console.WriteLine("Invalid use case number");
                    break;
            }
        }

        static void ExecuteUseCase1()
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Add(56);
            bst.Add(30);
            bst.Add(70);

            Console.WriteLine("BST created with elements 56, 30, and 70");
        }

        static BinarySearchTree<int> ExecuteUseCase2()
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Add(56);
            bst.Add(30);
            bst.Add(70);
            bst.Add(22);
            bst.Add(40);
            bst.Add(60);
            bst.Add(95);
            bst.Add(11);
            bst.Add(65);
            bst.Add(3);
            bst.Add(16);
            bst.Add(63);
            bst.Add(67);

            Console.WriteLine("BST created with elements 56, 30, 70, 22, 40, 60, 95, 11, 65, 3, 16, 63, and 67");
            Console.WriteLine("Number of nodes in BST: " + bst.Size());

            return bst;
        }

        static void ExecuteUseCase3()
        {
            BinarySearchTree<int> bst = ExecuteUseCase2();

            int keyToSearch = 63;
            bool found = bst.Search(keyToSearch);
            if (found)
                Console.WriteLine("Key " + keyToSearch + " found in BST");
            else
                Console.WriteLine("Key " + keyToSearch + " not found in BST");
            Console.ReadLine();
        }
    }
}
