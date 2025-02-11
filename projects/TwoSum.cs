public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] pos = {0,1};
        bool found = false;
        for (int x = 0; x <= nums.Length-1; x++) {
            for (int y = 0; y <= nums.Length-1; y++) {
                if (x == y) { continue; }
                if ( (nums[x]+nums[y]) == target ) {
                    

                    pos[0] = x;
                    pos[1] = y;
                    found = true;
                    break;
                }

                
            }
            if (found == true) {
                break;
            }
        }
        return pos;
    }

}
