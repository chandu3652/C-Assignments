using System;
using System.Collections.Generic;

namespace Assignment_4
    {
 

    class Stack
{
    private int[] ele;
    private int top;
    private int max;
    public Stack(int size)
    {
        ele = new int[size];
        top = -1;
        max = size;
    }
    public void push(int item)
    {
        if (top == max - 1)
        {
            throw new Exception("Stack overflow can not perform push");
        }
        else
        {
            ele[++top] = item;
        }
    }
    public int pop()
    {
        if (top == -1)
        {
            throw new System.Exception("stack is Empty");
        }
        else
        {
            Console.WriteLine("poped element is: " + ele[top]);
            return ele[top--];
        }
    }
    public void printStack()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is Empty");
            return;
        }
        else
        {
            for (int i = 0; i <= top; i++)
            {
                Console.WriteLine("Item[" + (i + 1) + "]; " + ele[i]);
            }
        }
    }
}
class program
{
    static void Main()
    {
            Stack a = new Stack(5);
        
        a.push(10);
        a.push(20);
        a.push(30);
        a.push(40);
        a.push(50);
               
        Console.WriteLine("Item are : ");
        a.printStack();

        a.pop();
        a.pop();
        a.pop();
        a.pop();
        a.pop();
    }
}
}
     


