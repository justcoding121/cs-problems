namespace CS.Problems.Miscellaneous
{

    public class SearchAlmostSorted
    {
        public static int Search(int[] input, int element)
        {
            return search(input, 0, input.Length - 1, element);
        }

        private static int search(int[] input, int i, int j, int element)
        {
            while (i <= j)
            {
                var mid = (i + j) / 2;

                if (input[mid] == element)
                {
                    return mid;
                }

                if (mid > i && input[mid - 1] == element)
                {
                    return mid - 1;
                }

                if (mid < j && input[mid + 1] == element)
                {
                    return mid + 1;
                }

                if (input[mid] > element)
                {
                    j = mid - 2;
                }
                else
                {
                    i = mid + 2;
                }
            }

            return -1;
        }
    }
}
