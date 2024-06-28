using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp4;

public class TaskFirst
{
    private Node head;

    public TaskFirst()
    {
        head = null;
    }

    public void Push(int data)
    {
        Node newNode = new Node(data);
        newNode.Next = head;
        head = newNode;
    }

    public int Pop()
    {
        if (head == null)
        {
            
            return -1;
        }

        int data = head.Data;
        head = head.Next;
        return data;
    }

    public int Peek()
    {
        if (head == null)
        {
            return -1;
        }

        return head.Data;
    }

    public string PrintElem()
    {
        string str = "";

        Node newNode = head;

        while(newNode != null)
        {
            str += newNode.Data + " ";
            newNode = newNode.Next;

        }
        
        return str;

    }

}
