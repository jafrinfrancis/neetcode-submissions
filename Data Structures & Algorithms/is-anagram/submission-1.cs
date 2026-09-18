public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        int[] tracker = new int[26];
        for(int i=0;i<s.Length;i++){
            tracker[s[i]-'a']++;
            tracker[t[i]-'a']--;
        }
        for(int i=0;i<26;i++){
            if(tracker[i]!=0) return false;
        }
        return true;
    }
}
