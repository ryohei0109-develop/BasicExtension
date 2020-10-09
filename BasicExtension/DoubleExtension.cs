using System;

namespace BasicExtension
{
    /// <summary>
    /// 浮動小数点値クラスの拡張メソッドを実装したクラスです。
    /// </summary>
    public static class DoubleExtension
    {
        /// <summary>
        /// 下限値及び上限値を指定し、対象の数値が範囲内であれば、文字列に変換して取得します。
        /// </summary>
        /// <param name="arg">チェック対象の数値を指定します。</param>
        /// <param name="lowerLimit">下限値を指定します。</param>
        /// <param name="upperLimit">上限値を指定します。</param>
        /// <returns>範囲内であれば文字列を、そうでない場合は空文字を返します。</returns>
        public static string ToStringAndCheck(this double? arg, int lowerLimit, int upperLimit)
        {
            string ret = string.Empty;

            if (arg != null)
            {
                if ((lowerLimit <= arg) && (upperLimit >= arg))
                {
                    ret = Convert.ToString(arg);
                }
            }

            return ret;
        }
    }
}
