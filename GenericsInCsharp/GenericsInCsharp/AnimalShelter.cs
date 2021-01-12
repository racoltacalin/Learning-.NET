using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsInCsharp
{
    public class AnimalShelter<TAnimal>
    {
        private const int DefaultPalcesCount = 20;

        private TAnimal[] animalList;
        private int usedPlaces;

        public AnimalShelter() : this(DefaultPalcesCount)
        {

        }

        public AnimalShelter(int placeCount)
        {
            this.animalList = new TAnimal[placeCount]; // Initialization
            this.usedPlaces = 0;
        }

        public void Shelter(TAnimal newAnimal)
        {
            if (this.usedPlaces >= this.animalList.Length)
            {
                throw new InvalidOperationException("Shelter is full!");
            }
            this.animalList[this.usedPlaces] = newAnimal;
            this.usedPlaces++;
        }

        public TAnimal Release(int index)
        {
            if (index < 0 || index >= this.usedPlaces)
            {
                throw new ArgumentOutOfRangeException("Invalid cell index: " + index);
            }
            
            TAnimal releasedAnimal = this.animalList[index];
            
            for (int i = index; i < this.usedPlaces - 1; i++)
            {
                this.animalList[i] = this.animalList[i + 1];
            }

            // this.animalList[this.usedPlaces - 1] = null;
            this.animalList[this.usedPlaces - 1] = default(TAnimal);
            this.usedPlaces--;

            return releasedAnimal;
        }
    }
}
