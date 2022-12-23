namespace LeetCodeExercises;
public class TwoSumArray
{
    // O(n)
    public int[] twoSum(int[] numbers, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < numbers.Length; i++)
        {
            //Get number from loop
            int x = numbers[i];
            if (map.ContainsKey(target - x))
            {
                //Take target minus number + 1
                return new int[] { map.GetValueOrDefault(target - x) + 1, i + 1 };
            }
            map.Add(x, i);
        }
        throw new ArgumentException("No two sum solution");
    }

    //OLog(n)
    public int[] twoSumV2(int[] numbers, int target)
    {
        //Assume is already sorted
        for (int i = 0; i < numbers.Length; i++)
        {
            int j = bsearch(numbers, target - numbers[i], i + 1);
        }

        throw new ArgumentException("No two sum solution");
    }

    private int bsearch(int[] A, int key, int start)
    {
        int L = start, R = A.Length - 1;
        while (L < R)
        {
            int M = (L + R) / 2;
            if (A[M] < key)
            {
                L = M + 1;
            }
            else
            {
                R = M;
            }
        }

        return (L == R && A[L] == key) ? L : -1;
    }

    //O(n)
    public int[] twoSumV3(int[] numbers, int target)
    {
        //Assume input is already sorted
        int i = 0, j = numbers.Length - 1;
        while (i < j)
        {
            int sum = numbers[i] + numbers[j];
            if (sum < target)
            {
                //If Sum is less than target incrementing j will make sum smaller so we increment i
                i++;
            }
            else if (sum > target)
            {
                //If sum is greater than target, decrementing i will make the sum larger so we decrement j
                j--;
            }
            else
            {
                return new int[] { i + 1, j + 1 };
            }
        }
        throw new ArgumentException("No two sum solution");
    }

}
