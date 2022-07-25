namespace WarriorsWithInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu play = new Menu("play1.txt");

            play.Open("play.txt");

            play.WriteTitle();

            for (int i = 0; i < 10; i++)
            {
                play.Add(new Goblin(500));
                play.Add(new Orc(300));
                play.Add(new Doctor(200));
            }



            //var orc = new Orc(300);
            //var govl = new Goblin(500);
            //var doc = new Doctor(200);
            //var doc1 = new Doctor(200);

            IActionManager manager = new ActionManager();
            //manager.Attack(orc, govl, 10);
            //manager.Attack(govl, orc, 50);

            System.Console.WriteLine();
            manager.Attack(play.wariors[6], play.wariors[9], 170);
            System.Console.WriteLine();
            
            //System.Console.WriteLine($"Гоблин HP =  {govl.HP}");
            //System.Console.WriteLine($"Orc HP =  {orc.HP}");

            //while (orc.HP > 0 && govl.HP > 0)
            //{
            //    if (orc.HP > 0) manager.Attack(orc, govl, 10);
            //    if (govl.HP > 0) manager.Attack(govl, orc, 5);
            //    System.Console.WriteLine($"Orc HP =  {orc.HP}");
            //}

            
            //play.Add(orc);
            //play.Add(govl);
            //play.Add(doc);
            //play.Add(doc1);

            play.Save();
            play.Open("play1.txt");
        }
    }
}
