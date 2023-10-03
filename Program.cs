using PattaBeelder;
/*
int op = 2;
decimal pip = 3;
Console.WriteLine(op * pip);
*/


List<Position> position = new()
{
    new Position {Name = "Cheese Premium  ", Price = 5, Count = 2, TotalPrice = 10},
    new Position {Name = "Salad CoolTree  ", Price = 4, Count = 1, TotalPrice = 4},
    new Position {Name = "Fresh Meat Balls", Price = 8, Count = 3, TotalPrice = 24}
};


var builder = new CheckBuilder(position);

var director = new BueyrCheckDirector(builder);

director.Build();

var check = builder.GetCheck();

Console.WriteLine(check);

Console.ReadKey();
