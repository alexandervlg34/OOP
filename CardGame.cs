using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
   /* internal class CardGame
    {
        
        static void Main(string[] args)
        {
            bool isEnough = false;
            int tries = 0;
            int maxTries = 5;

            List<Card> cards = new List<Card>();

            List<string> values = new List<string>() { "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            List<string> suits = new List<string>() { "Diamonds", "Hearts", "Spades", "Clubs" };

            foreach (var value in values)
            {
                foreach (var suit in suits)
                {
                    cards.Add(new Card(value, suit));
                }
            }

            Random random = new Random();
            int randomCard = random.Next(0, cards.Count);
            int selectedCard = -1;

            if (isEnough || tries < maxTries)
            {
                Console.WriteLine("Take a card please");
                selectedCard = int.Parse(Console.ReadLine());

                if(selectedCard == randomCard)
                {
                    tries++;
                }

            }
        }
    }*/

    public class CardPlayer
    {

    }

    public class Card
    {
         private string value;
         private string suit;
         public Card(string value, string suit)
         {
             this.value = value;

             this.suit = suit;
         } 


        /* List<string> values = new List<string>() { "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
        List<string> suits = new List<string>() { "Diamonds", "Hearts", "Spades", "Clubs" };
        */
    }

    public class Deck
    {
        
    }

}
