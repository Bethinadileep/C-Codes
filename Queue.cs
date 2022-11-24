//Generic
using System;
using System.Collections.Generic;
class HelloWorld {
  static void Main() {
    Queue<string> stk = new Queue<string>();
    stk.Enqueue("C#");
    stk.Enqueue("Java");
    stk.Enqueue("C++");
    stk.Dequeue();
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
    Queue stk = new Queue();
    stk.Enqueue("C#");
    stk.Enqueue("Java");
    stk.Enqueue("C++");
    stk.Dequeue();
    Console.WriteLine(stk.Count);
    foreach(string str in stk){
        Console.WriteLine(str);
    }
    if(stk.Contains("Java") == true){
        Console.WriteLine("Data is Present");
    }
  }
}
