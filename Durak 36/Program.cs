
using Durak_36;

Console.WriteLine("Enter the number of cards to pick: ");
string line = Console.ReadLine();
if (int.TryParse(line, out int numberOfCards))
{
    CardPicker.PickSomeCards(numberOfCards);
    foreach(string card in CardPicker.PickSomeCards(numberOfCards))
    {
        Console.WriteLine(card);
    }
}
else
{
    Console.WriteLine("Enter a valid number");
}