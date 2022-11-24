using System;
using System.Collections;
class HelloWorld {
  static void Main() {
    ArrayList list = new ArrayList();
    Console.WriteLine(list.Capacity);
    list.Add(10);
    list.Add("C#");
    list.Add(true);
    list.Add("Programming");
    Console.WriteLine("After adding the elements " + list.Capacity);
    list.Insert(1,"Sample Data");
    list.Remove(10);
    
    foreach(object item in list){
        Console.WriteLine(item);
    }
    //Search a element 
    if(list.Contains("Sample Data")){
        Console.WriteLine("Data is present");
    }
    else{
        Console.WriteLine("Data is not present");
    }
  }
}
