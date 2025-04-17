using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class Program
    {
        static void Main()
        {
            List<string> monsters = new List<string> { "슬라임", "고블린", "오우거" };
            List<int> monsterHPs = new List<int> { 30, 50, 80 };

            int playerHP = 100;
            int playerDamage = 20;
            bool isPlayerAlive = true;

            Random random = new Random();
            int turn = 1;

            Console.WriteLine("== 텍스트 RPG 전투 시작 ==");
            Console.WriteLine("던전에 들어서자 몬스터들이 나타났다!\n");

            foreach (var monster in monsters)
            {
                Console.WriteLine($"- {monster}");
            }

            Console.WriteLine("\n전투를 시작합니다!\n");

            while (isPlayerAlive && monsters.Count > 0)
            {
                Console.WriteLine($"[턴 {turn}] 플레이어의 공격!");

                // 무작위로 몬스터 한 마리 선택
                int targetIndex = random.Next(monsters.Count);
                string targetMonster = monsters[targetIndex];

                Console.WriteLine($"{targetMonster} 을(를) 공격했다! (-{playerDamage} 데미지)");

                monsterHPs[targetIndex] -= playerDamage;

                if (monsterHPs[targetIndex] <= 0)
                {
                    Console.WriteLine($"{targetMonster} 이(가) 쓰러졌다!\n");
                    monsters.RemoveAt(targetIndex);
                    monsterHPs.RemoveAt(targetIndex);
                }
                else
                {
                    Console.WriteLine($"{targetMonster} 의 남은 체력: {monsterHPs[targetIndex]}\n");
                }

                // 몬스터 공격 (남아있으면)
                if (monsters.Count > 0)
                {
                    int monsterAttack = random.Next(5, 15);
                    Console.WriteLine("몬스터가 반격합니다!");
                    Console.WriteLine($"플레이어가 {monsterAttack}의 피해를 입었습니다.");

                    playerHP -= monsterAttack;

                    if (playerHP <= 0)
                    {
                        isPlayerAlive = false;
                        playerHP = 0;
                        Console.WriteLine("\n플레이어가 쓰러졌습니다...");
                    }
                    else
                    {
                        Console.WriteLine($"플레이어 HP: {playerHP}\n");
                    }
                }

                turn++;
                Console.WriteLine("----------------------------------\n");
            }

            Console.WriteLine("\n== 전투 종료 ==");

            if (isPlayerAlive)
            {
                Console.WriteLine("🎉 모든 몬스터를 물리쳤습니다! 승리!");
            }
            else
            {
                Console.WriteLine("💀 전투에서 패배했습니다...");
            }

            Console.ReadLine();
        }
    }
}
