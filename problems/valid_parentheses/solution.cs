public class Solution {
    public bool IsValid(string s) {
        List<char> cList = s.ToCharArray().ToList();
        List<char> cOpenList = new List<char>();

        if (cList.Count <= 1)
            return false;

        foreach (char c in cList)
        {
            switch (c)
            {
                case '(':
                    {
                        cOpenList.Add(c);
                        break;
                    }
                case ')':
                    {
                        if(cOpenList.Count == 0)
                            return false;
                        else if (cOpenList[cOpenList.Count - 1] == '(')
                            cOpenList.RemoveAt(cOpenList.Count - 1);
                        else
                            return false;
                        break;
                    }
                case '{':
                    {
                        cOpenList.Add(c);
                        break;
                    }
                case '}':
                    {
                        if(cOpenList.Count == 0)
                            return false;
                        else if (cOpenList[cOpenList.Count - 1] == '{')
                            cOpenList.RemoveAt(cOpenList.Count - 1);
                        else
                            return false;
                        break;
                    }
                case '[':
                    {
                        cOpenList.Add(c);
                        break;
                    }
                case ']':
                    {
                        if(cOpenList.Count == 0)
                            return false;
                        else if (cOpenList[cOpenList.Count - 1] == '[')
                            cOpenList.RemoveAt(cOpenList.Count - 1);
                        else
                            return false;
                        break;
                    }
                default: break;
            }
        }
        if (cOpenList.Count == 0)
            return true;
        else
            return false;
    }
}