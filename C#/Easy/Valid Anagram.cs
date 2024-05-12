public class Solution {
    public bool IsAnagram(string s, string t) {
        var map_s = new Dictionary<char, int>();
        var map_t = new Dictionary<char, int>();
        if (s.Length != t.Length) {
            return false;
        }
        foreach(var letter in s) {
        var numQuery =
        from num in s
        where num == letter
        select num;
        if (map_s.ContainsKey(letter) != true) {
            map_s.Add(letter, numQuery.Count());
        }
        }
        foreach(var letter in t) {
        var numQuery =
        from num in t
        where num == letter
        select num;
        if (map_t.ContainsKey(letter) != true) {
            map_t.Add(letter, numQuery.Count());
        }
        }
        
        foreach(var letter in s) {
            if (map_t.ContainsKey(letter) && map_s.ContainsKey(letter)) {
                if (map_t[letter] == map_s[letter]) {
                continue;
            } else {
                return false;
            }
        } else {
            return false;
        }
            
        }
        return true;
    }
}
