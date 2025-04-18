using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

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


    //아이템 사용하기
    public void Use()
    {
        if (Count > 0)
        {
            Count--;
            Console.WriteLine($"{Name}을 사용했습니다 남은개수 {Count}");
        }
        else
        {
            Console.WriteLine($"{Name}은 더이상 없습니다");

        }
    }

    public void DisPlay()
    {
        Console.WriteLine($"{Name}을 사용했습니다 남은개수 {Count}");
    }
}


class RPGGame
{
    static void Main()
    {

        //바퀴를 새로만들지말아라
        List<Item> inventory = new List<Item>
        {
            new Item("회복약",5),
            new Item("목검",1),
            new Item("지도",1),
            new Item("마법약",3)
        };

        Console.WriteLine("========아이템============");

        foreach(var item in inventory)
        {
            item.DisPlay();
        }


        Console.WriteLine("========아이템사용============");




        Console.ReadLine();
    }
}
