using System;
using System.Collections.Specialized;

namespace BasicExtension
{
    /// <summary>
    /// <see cref="NameValueCollection" /> クラス用の拡張メソッドを実装します。
    /// </summary>
    public static class NameValueCollectionExtension
    {
        /// <summary>
        /// キーを指定して <see cref="Int32" /> 型の値を取得します。
        /// </summary>
        /// <param name="collection">値の取得元であるコレクションを指定します。</param>
        /// <param name="key">キーを指定します。</param>
        /// <returns>取得した値を返します。</returns>
        public static int GetInt32(this NameValueCollection collection, string key)
        {
            int ret = 0;
            try
            {
                string value = collection[key];
                if (value != null)
                {
                    ret = Convert.ToInt32(value);
                }
            }
            catch (Exception)
            {
            }

            return ret;
        }

        /// <summary>
        /// キーを指定して <see cref="Int32" /> 型の値を取得します。
        /// </summary>
        /// <param name="collection">値の取得元であるコレクションを指定します。</param>
        /// <param name="key">キーを指定します。</param>
        /// <param name="defaultValue">既定値を指定します。</param>
        /// <returns>取得した値を返します。</returns>
        public static int GetInt32(this NameValueCollection collection, string key, int defaultValue)
        {
            int ret = defaultValue;
            try
            {
                string value = collection[key];
                if (value != null)
                {
                    ret = Convert.ToInt32(value);
                }
            }
            catch (Exception)
            {
            }

            return ret;
        }

        /// <summary>
        /// キーを指定して <see cref="DateTime" /> 型の値を取得します。
        /// </summary>
        /// <param name="collection">値の取得元であるコレクションを指定します。</param>
        /// <param name="key">キーを指定します。</param>
        /// <returns>取得した値を返します。</returns>
        public static DateTime GetDateTime(this NameValueCollection collection, string key)
        {
            DateTime ret = DateTime.MinValue;
            try
            {
                string value = collection[key];
                if (value != null)
                {
                    ret = DateTime.Parse(value);
                }
            }
            catch (Exception)
            {
            }

            return ret;
        }
    }
}
