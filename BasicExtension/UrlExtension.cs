using System.Text.RegularExpressions;

namespace BasicExtension
{
    /// <summary>
    /// URLに関する操作を行うユーティリティクラスです。
    /// </summary>
    public static class UrlExtension
    {
        /// <summary>
        /// URLを正しい値に整形します。
        /// </summary>
        /// <param name="url">URLを指定します。</param>
        /// <returns>整形後のURLを返します。</returns>
        public static string Shaping(this string url)
        {
            string ret = string.Empty;

            if (url != null)
            {
                Regex regex = new Regex(@"(?<!\:)(/{2,})");
                ret = regex.Replace(url, t => "/");
            }

            return ret;
        }
    }
}
