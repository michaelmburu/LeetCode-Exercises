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

 

}
