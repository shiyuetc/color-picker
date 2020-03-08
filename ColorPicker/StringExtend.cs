using System;

namespace ColorPicker
{
    /// <summary>
    /// string型の拡張メソッド
    /// </summary>
    public static class StringExtend
    {
        /// <summary>
        /// 文字列が16進数かどうが調べる
        /// </summary>
        /// <param name="s">調べるもじれつ</param>
        /// <returns>文字列が16進数なら真を返す、それ以外なら偽を返す</returns>
        public static bool IsHexString(this string s)
        {
            if (string.IsNullOrEmpty(s)) { return false; }
            foreach (char c in s)
            {
                if (!Uri.IsHexDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
