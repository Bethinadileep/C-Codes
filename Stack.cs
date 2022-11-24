//Generic
using System;
using System.Collections.Generic;
class HelloWorld {
  static void Main() {
    Stack<string> stk = new Stack<string>();
    stk.Push("C#");
    stk.Push("Java");
    stk.Push("C++");
    stk.Pop();
    Console.WriteLine(stk.Count);
    foreach(string str in stk){
        Console.WriteLine(str);
    }
    if(stk.Contains("Java") == true){
        Console.WriteLine("Data is Present");
    }
  }
}


//Non Generic
using System;
using System.Collections;
class HelloWorld {
  static void Main() {
    Stack stk = new Stack();
    stk.Push("C#");
    stk.Push("Java");
    stk.Push("C++");
    stk.Pop();
    Console.WriteLine(stk.Count);
    foreach(string str in stk){
        Console.WriteLine(str);
    }
    if(stk.Contains("Java") == true){
        Console.WriteLine("Data is Present");
    }
  }
}
