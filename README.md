
1. for문
특징
•	반복 횟수가 정해져 있을 때 주로 사용됩니다.
•	초기화, 조건식, 증감식이 한 줄에 모두 포함되어 있어 반복의 흐름을 한 눈에 알 수 있습니다.
•	반복 횟수나 범위가 명확할 때 유용합니다.
주로 사용되는 상황
•	반복 횟수가 미리 정해져 있을 때 사용됩니다.
•	예를 들어, 1부터 10까지의 숫자를 출력하거나, 배열의 특정 범위만큼 반복 작업을 할 때 적합합니다.


for (초기화문;   조건식;    증감문)
{
// 반복할 코드
}

for (int i = 0;   i < 10;   i++)  // 0부터 9까지 반복
{//<-for문의 시작부분 
    Console.WriteLine(i);
}//<-for문의 끝부분





2_ 기본 감소문 형태
for (int i = 10;   i >= 0;    i--) 
{
    Console.WriteLine(i);
}

for (int i = 10;   i > 0;    i -= 2)
{
    Console.WriteLine(i);  // 10, 8, 6, 4, 2
}

for (char c = 'A'; c <= 'Z'; c++)
{
    Console.WriteLine(c);  // A ~ Z
}

3_ 조건식이 없는 경우 
for (int i = 0; ;i++) // 조건식 없음 = 무한루프
{
    Console.WriteLine(i);
    if (i == 100) break;  // 반드시 break 필요
}


While문 처럼 무한 반복 
for (;;)
{
    Console.WriteLine("무한루프");
    If(조건)
    //break;
}


2. while문
특징
•	조건식이 참인 동안 반복이 실행됩니다.
•	반복 횟수가 명확하지 않거나, 조건이 충족될 때까지 반복해야 하는 경우에 사용됩니다.
•	초기화가 별도로 필요하고, 반복문 내부에서 조건 변경이 이루어져야 합니다.
주로 사용되는 상황
•	반복할 조건이 명확하지 않을 때, 반복을 중간에 종료하거나 조건을 만족할 때까지 반복하고자 할 때 사용됩니다.

while (true)
{
    Console.WriteLine("게임 루프 실행 중...");
}



//플레이어가 생존했을 때 
while (player.HP > 0)
{
    // 적 공격 처리
    player.TakeDamage(10);
    Thread.Sleep(1000);
}

사용자 입력이 특정 조건일 때까지 반복
string input = "";
while (input != "exit")
{
    Console.WriteLine("명령을 입력하세요:");
    input = Console.ReadLine();
}

조건이 나중에 정해지는 경우
Enemy boss = null;
while (boss == null)
{
    //적이 스폰될 때까지 기다림
    boss = GameObject.Find("Boss");
}


for문 처럼 
string[] items = { "검", "방패", "물약" };
int index = 0;
while (index < items.Length)
{
    Console.WriteLine(items[index]);
    index++;
}

2_do-while문 (일단 한 번은 실행)
int score;
do
{
    Console.WriteLine("점수를 입력하세요:");
    score = int.Parse(Console.ReadLine());
}
while (score > 0);





3. foreach문
특징
•	컬렉션이나 배열의 각 요소를 하나씩 순차적으로 접근할 때 사용됩니다.
•	배열이나 리스트와 같은 컬렉션에서 요소를 반복할 때 매우 유용하며, 인덱스를 사용하지 않고 값을 직접 다룰 수 있습니다.


var는 코드가 실행되기 전에, 즉 컴파일할 때 명확한 타입이 추론될 수 있는 상황에서만 사용 가능
var는 그런 복잡성을 감당할 수 없어서 제한된다 
foreach (var item in 컬렉션)
{
    // 반복할 코드
}

1: 배열 순회
string[] inventory = { "검", "방패", "물약" };
foreach (var item in inventory)
{
    Console.WriteLine("아이템: " + item);
}




2: 리스트 순회
List<int> scores = new List<int> { 100, 200, 300 };
foreach (var score in scores)
{
    Console.WriteLine("점수: " + score);
}

3: 딕셔너리 순회
Dictionary<string, int> shopItems = new Dictionary<string, int>()
{
    { "물약", 50 },
    { "검", 100 },
    { "방패", 75 }
};

foreach (KeyValuePair<string, int> item  in  shopItems)
{
    Console.WriteLine($"{item.Key} - {item.Value}골드");
}





foreach 주의점 읽기 전용으로만 요소에 접근
foreach (int n in numbers)
{
    n = n + 1; //  컴파일 오류: foreach 내부에서는 직접 수정 불가
}




