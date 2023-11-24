public class Solution {
    public string AddBinary(string a, string b) {
        string sum = "";
        bool carry = false;
        var j = b.Length - 1;
        var i = a.Length - 1;
        
        for (; i >= 0 && j >= 0; i--, j--)
        {
            if (a[i] == '0' && b[j] == '0')
            {
                if (carry)
                {
                    sum = "1" + sum;
                    carry = false;
                }
                else
                {
                    sum = "0" + sum;
                }
            }
            else if ((a[i] == '1' && b[j] == '0') || (a[i] == '0' && b[j] == '1'))
            {
                if (carry)
                {
                    sum = "0" + sum;
                    carry = true;
                }
                else
                {
                    sum = "1" + sum;
                }
            }
            else
            {
                if (carry)
                {
                    sum = "1" + sum;
                }
                else
                {
                    sum = "0" + sum;
                }
                carry = true;
                // 1 - 1
            }
        }

        // eğer carry varsa, sıradakideğerde ne var?

        if(i >= 0 || j >= 0)
        {
            if (i >= 0)
            {
                for (; i >= 0; i--)
                {
                    if (a[i] == '1')
                    {
                        if (carry)
                            sum = "0" + sum;
                        else
                        {
                            sum = "1" + sum;
                        }
                    }
                    else
                    {
                        if (carry)
                        {
                            sum = "1" + sum;
                            carry = false;
                        }
                        else
                        {
                            sum = "0" + sum;
                        }
                    }
                    
                }
            }
            else
            {
                for (; j >= 0; j--)
                {
                    if (b[j] == '1')
                    {
                        if (carry)
                            sum = "0" + sum;
                        else
                        {
                            sum = "1" + sum;
                        }
                    }
                    else
                    {
                        if (carry)
                        {
                            sum = "1" + sum;
                            carry = false;
                        }
                        else
                        {
                            sum = "0" + sum;
                        }
                    }

                }
            }
            if (carry)
                sum = "1" + sum;
        }
        else
        {
            if (carry)
                sum = "1" + sum;
        }
        
        return sum;
    }
}