public class Solution {
    public int[] FindDiagonalOrder(int[][] mat) {
        if (mat.Length == 1)
                return mat[0];
        else if (mat[0].Length == 1)
        {
            List<int> arr = new List<int>();
            //var arr = new int[mat.Length * mat[0].Length];
            for(var i = 0; i < mat.Length; i++)
            {
                for(var j = 0; j < mat[i].Length; j++)
                {
                    arr.Add(mat[i][j]);
                }
            }
            return arr.ToArray();
        }
        else
        {
            var iCur = 0;
            var jCur = 0;

            var iMax = mat.Length - 1;
            var jMax = mat[0].Length - 1;

            var direction = true;

            List<int> arr = new List<int>();

            while (true)
            {
                var i = iCur;
                var j = jCur;

                List<int> tmp = new List<int>();
                // işlem yap
                while (i >= 0 && j <= jMax)
                {
                    if (direction)
                        arr.Add(mat[i][j]);
                    else
                        tmp.Add(mat[i][j]);

                    i--;
                    j++;
                }
                if (!direction)
                {
                    tmp.Reverse();
                    foreach (var num in tmp)
                        arr.Add(num);
                }

                direction = !direction;

                // artırım yap
                if (iCur < iMax)
                    iCur++;
                else if (jCur < jMax)
                    jCur++;
                else if (iCur == iMax && jCur == jMax)
                    break;
            }
            return arr.ToArray();
        }
    }
}