string[] names = { "Ali", "Ahmet", "Can" };
int[,] notes = new int[3, 3];
notes[0, 0] = 50;
notes[0, 1] = 60;
notes[0, 2] = 70;
notes[1, 0] = 60;
notes[1, 1] = 80;
notes[1, 2] = 90;
notes[2, 0] = 50;
notes[2, 1] = 70;
notes[2, 2] = 30;

var alinotes = (notes[0, 0] + notes[0, 1] + notes[0, 2]) / 3;
Console.WriteLine("Ali Notes Average: " + alinotes);

var ahmetnotes = (notes[1, 0] + notes[1, 1] + notes[1, 2]) / 3;
Console.WriteLine("Ahmet Notes Average: " + ahmetnotes);

var cannotes = (notes[2, 0] + notes[2, 1] + notes[2, 2]) / 3;
Console.WriteLine("Can Notes Average: " + cannotes);