using System.Collections;
using System.Collections.Generic;

namespace P04_Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> stones;

        public Lake(params int[] stoneParams)
        {
            stones = new List<int>(stoneParams);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < stones.Count; i++)
            {
                if (i % 2 == 0)
                {
                    yield return stones[i];
                }
            }

            for (int i = stones.Count -1; i >= 1; i--)
            {
                if (i % 2 != 0)
                {
                    yield return stones[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
