public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> dict = new();
        foreach(var s in strs){
            var key = string.Concat(s.OrderBy(c=>c));
            if(dict.ContainsKey(key)) dict[key].Add(s);
            else dict.Add(key,new List<string>{s});
        }
        List<List<string>> res = new();
        foreach(var d in dict){
            res.Add(d.Value);
        }
        return res;
    }
}
