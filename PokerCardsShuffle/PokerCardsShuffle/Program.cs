// See https://aka.ms/new-console-template for more information
static string CardIdentifier(int Card)
{
    int findsuit, findvalue;
    string CardInfo = "";
    findvalue = Card % 13;
    if(findvalue == 1)
    {
        CardInfo = "Ace of ";
    }
    else if (findvalue == 2)
    {
        CardInfo = "Two of ";
    }
    else if (findvalue == 3)
    {
        CardInfo = "Three of ";
    }
    else if (findvalue == 4)
    {
        CardInfo = "Four of ";
    }
    else if (findvalue == 5)
    {
        CardInfo = "Five of ";
    }
    else if (findvalue == 6)
    {
        CardInfo = "Six of ";
    }
    else if (findvalue == 7)
    {
        CardInfo = "Seven of ";
    }
    else if (findvalue == 8)
    {
        CardInfo = "Eight of ";
    }
    else if (findvalue == 9)
    {
        CardInfo = "Nine of ";
    }
    else if (findvalue == 10)
    {
        CardInfo = "Ten of ";
    }
    else if (findvalue == 11)
    {
        CardInfo = "Jack of ";
    }
    else if (findvalue == 12)
    {
        CardInfo = "Queen of ";
    }
    else if (findvalue == 0)
    {
        CardInfo = "King of ";
    }
    findsuit = (Card - 1) / 13; 
    if (findsuit == 0)
    {
        CardInfo = CardInfo + "Clubs";
    }
    else if (findsuit == 1)
    {
        CardInfo = CardInfo + "Diamonds";
    }
    else if (findsuit == 2)
    {
        CardInfo = CardInfo + "Hearts";
    }
    else if (findsuit == 3)
    {
        CardInfo = CardInfo + "Spades";
    }
    return CardInfo;
}
int[] Deck = new int[53];
int[] Used = new int[53];
Random generator = new Random();
for (int i = 1; i <= 52; i++)
{
    int testingcard = 0;
    int duplicate = 0;
    do
    {
        duplicate = 0;
        testingcard = generator.Next(1, 53);
        for (int j = 1; j < i; j++)
        {
            if (testingcard == Deck[j])
            {
                duplicate = 1;
                break;
            }
        }
    } while(duplicate == 1);
    Deck[i] = testingcard;
}
for(int i = 1; i <= 52; i++)
{
    Console.WriteLine(CardIdentifier(Deck[i]) + " is in position " + i + ".");
}
Console.ReadLine();