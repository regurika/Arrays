﻿using System;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
        int[] arr = new int[10]; 
        int i;  

        Console.Write("Input 10 elements in the array :\n");  

    for(i=0; i<10; i++)  
    {  
	    Console.Write("element - {0} : ",i);
	    arr[i] = Convert.ToInt32(Console.ReadLine());  		
    }  
  
        Console.Write("\nElements in array are: ");  
    for(i=0; i<10; i++)  
    {  
        Console.Write("{0}  ", arr[i]);  
    } 
        Console.Write("\n");	
  }
}
}


