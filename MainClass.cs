/*
	Practicing C# Seeing if i remember some of the things 
*/

#pragma warning disable 0219

using System; //Included the namespace System so dont have to add quantifier to Console class Or methods in Console Class 

using DataStructure;

//Typically The namespace is always the name of the file 
namespace MainClass
{
	
	//Default Accessor Quantifier for classes is internal
	internal class App
	{
		//Default Accessor Quantifier for methods is private 
		private static void Main(string[] args)
		{
		
			//Creating a SLinkedList
			SLinkedList<int> list = new SLinkedList<int>();

			for(int i = 0; i < 10000; i++)
			{
				list.Add(i);
				Console.WriteLine(list);
			}
			
		}


	}
	
}
