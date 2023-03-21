

using snake21._03;

point p1 = new point(1, 3, '*');
//p1.x = 1;
//p1.y = 3;
//p1.sym = '*';
p1.Draw();

//int x1 = 1;
//int y1 = 3;
//char sym1 = '*';

//Draw(x1, y1, sym1);

point p2 = new point(4, 5, '#');
//p2.x = 4;
//p2.y = 5;
//p2.sym = '#';
p2.Draw();

List<int> numList = new List<int>();
numList.Add(0);
numList.Add(1);
numList.Add(2);

int x = numList[0];
int y = numList[1];
int z = numList[2];

foreach(int i in numList)
{
    Console.WriteLine(i);
}

numList.RemoveAt(0);

List<point> pList = new List<point>();
pList.Add(p1);
pList.Add(p2);

//int x1 = 1;

//int x2 = 4;
//int y2 = 5;
//char sym2 = '#';

//Draw(x2, y2, sym2);

