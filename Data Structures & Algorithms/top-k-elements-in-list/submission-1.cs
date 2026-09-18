public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> dict = new();
        int[] res = new int[k];
        foreach(var n in nums){
            if(dict.ContainsKey(n)) dict[n]++;
            else dict.Add(n,1);
        }
        int i=0;
        foreach(var d in dict.OrderByDescending(p=>p.Value)){
            res[i++] = d.Key;
            if(i==k) return res;
        }
        return res;
    }
}
