namespace valid_parentheses
{

    public class Solution
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> pairs = new Dictionary<char, char> {
            {')', '('}, {']', '['}, {'}', '{'}
        };

            foreach (char c in s)
            {
                if (pairs.ContainsKey(c))
                {
                    char top = stack.Count == 0 ? '#' : stack.Pop();
                    if (top != pairs[c]) return false;
                }
                else
                {
                    stack.Push(c);
                }
            }
            return stack.Count == 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string[] testCases = { "()", "()[]{}", "(]", "([)]", "{[]}", "" };

            foreach (string test in testCases)
            {
                bool result = solution.IsValid(test);
                Console.WriteLine($"Is the string \"{test}\" valid? {result}");
            }
        }
    }
}


