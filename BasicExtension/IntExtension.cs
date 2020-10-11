namespace BasicExtension
{
    /// <summary>
    /// 数値クラスの拡張メソッドを実装したクラスです。
    /// </summary>
    public static class IntExtension
    {
        /// <summary>
        /// 下限値及び上限値を指定し、対象の数値が範囲内に収まっているかどうかチェックします。
        /// </summary>
        /// <param name="arg">チェック対象の数値を指定します。</param>
        /// <param name="lowLimit">下限値を指定します。</param>
        /// <param name="upperLimit">上限値を指定します。</param>
        /// <returns>範囲内であればtrueを、そうでない場合はfalsを返します。</returns>
        public static bool IsBetween(this int arg, int lowLimit, int upperLimit)
        {
            if ((arg >= lowLimit) && (arg <= upperLimit))
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
