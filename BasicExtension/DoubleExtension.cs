using System;

namespace BasicExtension
{
    /// <summary>
    /// 浮動小数点値クラスの拡張メソッドを実装したクラスです。
    /// </summary>
    public static class DoubleExtension
    {
        /// <summary>
        /// doubule型の値の範囲チェックを行います。
        /// </summary>
        /// <param name="arg">チェック対象の数値を指定します。</param>
        /// <param name="lowerLimit">下限値を指定します。</param>
        /// <param name="upperLimit">上限値を指定します。</param>
        /// <returns>範囲内であればtrueを、そうでない場合はfalseを返します。</returns>
        public static bool IsBetween(this double arg, int lowerLimit, int upperLimit)
        {
            if ((lowerLimit <= arg) && (upperLimit >= arg))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
