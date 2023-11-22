public class Solution {
    public int RomanToInt(string s) {
        var sList = s.ToCharArray();
        var total = 0;
        for (var i = 0; i < sList.Length; i++)
        {
            switch (sList[i])
            {
                case 'I':
                    {
                        if(i < sList.Length - 1  ){
                            if (sList[i+1] == 'V')
                            {
                                total += 4;
                                i++;
                                break;
                            }
                            else if(sList[i + 1] == 'X')
                            {
                                total += 9;
                                i++;
                                break;
                            }
                        }
                        total += 1;
                        break;
                    }
                case 'V': total += 5; break;
                case 'X':
                    {
                        if(i < sList.Length - 1  ){
                            if (sList[i + 1] == 'L')
                            {
                                total += 40;
                                i++;
                                break;
                            }
                            else if (sList[i + 1] == 'C')
                            {
                                total += 90;
                                i++;
                                break;
                            }
                        }
                        total += 10;
                        break;
                    }
                case 'L': total += 50; break;
                case 'C':
                    {
                        if(i < sList.Length - 1  ){
                            if (sList[i + 1] == 'D')
                            {
                                total += 400;
                                i++;
                                break;
                            }
                            else if (sList[i + 1] == 'M')
                            {
                                total += 900;
                                i++;
                                break;
                            }
                        }
                        total += 100;
                        break;
                    }
                case 'D': total += 500; break;
                case 'M': total += 1000; break;
            }
        }
        return total;
    }
}