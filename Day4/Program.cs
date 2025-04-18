using System;
using System.Collections.Generic;

class Item
{
    //get 으로 읽고 set 값을 수정한다  
    public string Name { get; set; }

    public int Count { get; set; }


    public Item(string name, int count)
    {
        Name = name;
        Count = count;
    }





}








class RPGGame
{
    static void Main()
    {
        Console.ReadLine();
    }
}
