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
            //0 1 2 3 


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

        bool UseItem = true;


        while (UseItem)
        {
            Console.WriteLine("사용할 아이템을 선택해주세요: ");

            for(int i=0; i<inventory.Count; i++)
            {
                Console.WriteLine($"{i}: {inventory[i].Name} 남은개수:{inventory[i].Count} ");
            }

            Console.Write("아이템 번호를 입력하거나 종료하려면 -1을 입력해주세요: ");

            //대입연산자
            //같은 형끼리만 가능하다 
            int selectIndex = int.Parse(Console.ReadLine());

            if (selectIndex == -1)
            {
                UseItem = false;
            }
            //아이템 범위 내에서 
            else if (selectIndex>=0 && selectIndex<inventory.Count)
            {
                inventory[selectIndex].Use();
            }
            else
            {
                Console.WriteLine("잘못된 번호입니다!");
            }
        }

        Console.WriteLine("\n==아이템 추가기능=====");
        Console.WriteLine("아이템 추가하시겠습니까?");
        Console.ReadLine();

        string addchoice = Console.ReadLine();

        if (addchoice.ToLower() == "y")
        {
            Console.Write("아이템 이름: ");
            string newname = Console.ReadLine();

            bool exists = false;

            foreach(var item in inventory)
            {
                if(item.Name== newname)
                {
                    exists = true;
                    Console.WriteLine("이미 존재하는 아이템입니다");
                    break;
                }
            }

            if (!exists)
            {
                Console.Write("아이템 개수: ");
                int newCount = int.Parse(Console.ReadLine());
                inventory.Add(new Item(newname, newCount));
                Console.WriteLine($"{newname}이 인벤토리에 추가되었습니다!");
            }
        }
        Console.WriteLine("==인벤토리==");
        foreach (var item in inventory)
        {
            item.DisPlay();
        }

        Console.ReadLine();
    }
}
