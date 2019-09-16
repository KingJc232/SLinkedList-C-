
using System;

//Disables Unitialized Variable warnings
#pragma warning disable 0414

namespace DataStructure
{

	//Going to practice making a linked list
	internal class SLinkedList<T>
	{
		private Node head; //Points to the first node in SLinkedList
		private int size; //Keeps track of size in SLinkedList

	
		//Default Constructor 
		public SLinkedList()
		{
			this.head = null;
			
			this.size = 0; //Initially No Elements in SLinkedList
		}
			
		//Adds a Entry to the SLinkedList
		public void Add(T newEntry)
		{
			//Creating a Node to hold the newEntry
			Node newNode = new Node{Data = newEntry, Next = null};

			//Testing if first node 
			if(this.IsEmpty())
			{
				//First Node 
				this.head = newNode; 	
			}
			else
			{
				//Connecting the newNode to the SLinkedList
				newNode.Next = this.head; 
				//Updating the Head
				this.head = newNode; 
			}

			this.size++; //Increasing the Size
		}

		//Removes the First Element in the SLinkedList
		public T Remove()
		{
			if(this.IsEmpty())
				return default(T); //What ever its suppose to be 
			
			T returnedElement = this.head.Data;
			
			Node savedNext = this.head.Next; 

			//Cutting ties with the removed Node
			this.head.Data = default(T);
			this.head.Next = null; 
			
			//Updating the this.head 
			this.head = savedNext; 
			
			//Updating the Size of the SLinkedList
			this.size--;

			return returnedElement;

		}

		public bool IsEmpty()
		{
			return this.size == 0; 
		}

		
		//Override

		public override String ToString()
		{
			//Displaying all the elements in the SLinkedList
			Node temp = this.head; //Creating a Node to Interate throw the SLinkedList

			string holder = "[";
			string comma = " ";
			
			while(temp != null)
			{
				holder += comma + temp.Data;
				comma = " , ";
				temp = temp.Next; //Go to the Next Node 
			}
			
			holder += " ]"; 
			return holder;
		}

		private class Node
		{
			//Using auto properties which are setters and getters 
			public T Data {get; set;}
				
			public Node Next{get; set;}
		}
	}


}
