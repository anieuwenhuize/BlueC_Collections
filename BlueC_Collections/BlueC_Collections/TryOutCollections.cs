﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlueC_Collections
{
    class TryOutCollections
    {
        /// <summary>
        /// een I?<int> accepteert en deze vult met 200 even getallen;
        /// </summary>
        /// <returns></returns>
        public ICollection<int> AddNumbers(ICollection<int> collectie)
        {
            for (int i = 0; i < 400; i += 2)
            {
                int numberToAdd = i;

                collectie.Add(i);
            }

            return collectie;
        }

        /// <summary>
        /// accepteert en de getallen 6 en 8 verwijderd;
        /// </summary>
        /// <returns></returns>
        public ? Remove6And8(? collectie)
        {

        }

        /// <summary>
        /// accepteert en deze doorloopt en alle overgebleven getallen in de console print.
        /// </summary>
        /// <returns></returns>
        public ? PrintAllNumbers(? collectie)
        {

        }
    }
}
