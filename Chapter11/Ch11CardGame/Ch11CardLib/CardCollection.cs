using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ch11CardLib
{
    public class CardCollection : CollectionBase
    {
        public void Add(Card newCard) => List.Add(newCard);

        public void Remove(Card oldCard) => List.Remove(oldCard);

        public Card this[int cardIndex]
        {
            get { return (Card)List[cardIndex]; }
            set { List[cardIndex] = value; }
        }

        ///<summary>
        /// Utility method for copying card instances into another CardCollection
        /// instance—used in Deck.Shuffle(). This implementation assumes that
        /// source and target collections are the same size.
        ///</summary>

        public void CopyTo(CardCollection targetCards)
        {
            for (int i = 0; i < this.Count; i++)
            {
                targetCards[i] = this[i];
            }
        }
        /// <summary>
        /// Check to see if the CardCollection collection contains a particular card.
        /// This calls the Contains() method of the ArrayList for the collection,
        /// which you access through the InnerList property.
        /// </summary>
        public bool Contains(Card card) => InnerList.Contains(card);

    }
}
