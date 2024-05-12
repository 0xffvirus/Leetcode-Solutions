public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var groups = nums.GroupBy(v => v);
            foreach(var group in groups) {
            Console.WriteLine("{0}", group.Key);
            if (group.Count() > 1) {
                return true;
            }
        }

        
        return false;
    }
}
