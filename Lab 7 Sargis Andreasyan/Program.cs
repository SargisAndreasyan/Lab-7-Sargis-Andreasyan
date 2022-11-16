using Lab_7_Sargis_Andreasyan;

Bear a = new Bear();
Rabbit b = new Rabbit();
Manager m = new Manager(4,10,'X');
for(int i = 0; i < 30; i++)
{
    a.Move(i, 3);
    b.Move(i, 5);
    a.Draw();
    b.Draw();
    m.Draw();
    System.Threading.Thread.Sleep(1000);
    Console.Clear();
}