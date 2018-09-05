using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamRef70483.Obj2_1
{
    public class Card { }
    public class Deck
    {
        public ICollection<Card> Cards { get; private set; }
        public Deck()
        {
            Cards = new List<Card>();
        }
        public Card this[int index]
        {
            get { return Cards.ElementAt(index); }
        }
    }
}
