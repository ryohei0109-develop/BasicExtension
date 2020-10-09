using System;
using System.Collections.Generic;

namespace BasicExtension
{
    /// <summary>
    /// 数値クラスの拡張メソッドを実装したクラスです。
    /// </summary>
    public static class IntExtension
    {
        /// <summary>
        /// 下限値及び上限値を指定し、対象の数値が範囲内であれば、文字列に変換して取得します。
        /// </summary>
        /// <param name="arg">チェック対象の数値を指定します。</param>
        /// <param name="lowerLimit">下限値を指定します。</param>
        /// <param name="upperLimit">上限値を指定します。</param>
        /// <returns>範囲内であれば文字列を、そうでない場合は空文字を返します。</returns>
        public static string ToStringAndCheck(this int? arg, int lowerLimit, int upperLimit)
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

        /// <summary>
        /// 下限値及び上限値を指定し、対象の数値が範囲内に収まっているかどうかチェックします。
        /// </summary>
        /// <param name="arg">チェック対象の数値を指定します。</param>
        /// <param name="lowLimit">下限値を指定します。</param>
        /// <param name="upperLimit">上限値を指定します。</param>
        /// <returns>範囲内であればtrueを、そうでない場合はfalsを返します。</returns>
        public static bool IsBetween(this int arg, int lowLimit, int upperLimit)
        {
            bool isBetween = false;

            if ((arg >= lowLimit) && (arg <= upperLimit))
            {
                isBetween = true;
            }

            return isBetween;
        }

        /// <summary>
        /// ある値が、境地リストに含まれているかどうかをチェックします。
        /// 含まれている場合はそのままの値を返します。
        /// そうでない場合は、指定されたデフォルト値を返します。
        /// </summary>
        /// <param name="arg">チェック対象の値を指定します。</param>
        /// <param name="checkValues">許容値リストを指定します。</param>
        /// <param name="defaultValue">デフォルト値を指定します。</param>
        /// <returns>
        /// 許容値リストに含まれている場合はそのままの値を返します。
        /// そうでない場合は、デフォルト値を返します。
        /// </returns>
        public static int? ContainsOrDefaultValue(this int? arg, List<int> checkValues, int? defaultValue)
        {
            if ((arg != null) && (checkValues.Contains((int)arg)))
            {
                defaultValue = arg;
            }

            return defaultValue;
        }
    }
}
