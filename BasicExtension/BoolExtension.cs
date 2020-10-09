namespace BasicExtension
{
    /// <summary>
    /// 真偽クラスの拡張メソッドを実装したクラスです。
    /// </summary>
    public static class BoolExtension
    {
        /// <summary>
        /// 真偽値を文字列に変換します。
        /// </summary>
        /// <param name="arg">変換対象の真偽値を指定します。</param>
        /// <param name="trueValue">変換対象がtrueの場合の返り値を指定します。</param>
        /// <param name="falseValue">変換ん対象がfalseの場合の返り値を指定します。</param>
        /// <returns>変換対象をチェックし、引数で指定した文字列を返します。</returns>
        public static string ToString(this bool arg, string trueValue, string falseValue)
        {
            string ret = falseValue;

            if (arg == true)
            {
                ret = trueValue;
            }

            return ret;
        }
    }
}
