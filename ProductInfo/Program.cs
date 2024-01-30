using ProductInfo;

public class Program
{
    private static void Main(string[] args)
    {
        //Linq
        //Ilist is an interfface that provides a way to access and manipulate a collection of element by index

        IList<Newinfo> list = new List<Newinfo>()
        {
            new Newinfo() { id = 02, name = "Necklace", date = 2021 },
            new Newinfo() { id = 13, name = "Wristwatch", date = 2018 },
            new Newinfo() { id = 04, name = "Necklace", date = 2023 },
            new Newinfo() { id = 15, name = "Wristwatch", date = 2024 },
            new Newinfo() { id = 16, name = "Necklace", date = 2019 },
            new Newinfo() { id = 15, name = "Wristwatch", date = 2024 },
            new Newinfo() { id = 04, name = "Necklace", date = 2022 },
            new Newinfo() { id = 04, name = "Wristwatch", date = 2023 },
            new Newinfo() { id = 13, name = "Necklace", date = 2019 },
            new Newinfo() { id = 11, name = "Wristwatch", date = 2012 },
            new Newinfo() { id = 12, name = "Necklace", date = 2017 },
            new Newinfo() { id = 13, name = "Wristwatch", date = 2012 },
            new Newinfo() { id = 14, name = "Necklace", date = 2016 },
            new Newinfo() { id = 15, name = "Wristwatch", date = 2026 },
            new Newinfo() { id = 16, name = "Necklace", date = 2034 },
            new Newinfo() { id = 10, name = "Wristwatch", date = 2020 },
            new Newinfo() { id = 13, name = "Necklace", date = 2011 },
            new Newinfo() { id = 10, name = "Wristwatch", date = 2020 },
            new Newinfo() { id = 04, name = "Necklace", date = 2022 },
            new Newinfo() { id = 14, name = "Wristwatch", date = 2017 },
            new Newinfo() { id = 04, name = "Necklace", date = 2019 }
        };

        //query syntax
        var info = from u in list
                   where u.date > 2020
                   select u;

        //method syntax
        var info1 = list.Where(u => u.id > 10);

        //foreach (var u in info)
        //{
        //    Console.WriteLine(u.name);
        //}
        foreach (var v in info1)

        {
            Console.WriteLine(v.name + "------" + v.date);
        }
        Console.WriteLine("-----------");
    }
}