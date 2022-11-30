using Lab_7_Sargis_Andreasyan;
Random rand = new Random();
int speed1 = rand.Next(1, 5);
int speed2 = rand.Next(1, 5);
Bear a = new Bear('B',speed1);
Rabbit b = new Rabbit('R',speed2);
Manager m = new Manager(30,'X');
for(int i = 0; i < 30; i++)
{
    a.Move(i,8);
    b.Move(i, 5);
    a.Draw();
    b.Draw();
    m.Draw();
    System.Threading.Thread.Sleep(1000);
    Console.Clear();
}