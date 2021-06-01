using System.Collections.Generic;
using System.Linq;

namespace BasicExtension
{
    /// <summary>
    /// IEnumerableクラスの拡張メソッドです。
    /// </summary>
    public static class IEnumerableExtension
    {
        /// <summary>
        /// リスト内の重複チェックを行います。
        /// </summary>
        /// <param name="source">チェック対象のリストを指定します。</param>
        /// <returns>重複した値がある場合はtrueを、そうでない場合はfalseを返します。</returns>
        public static bool ContainsDuplicate(this IEnumerable<string> source)
            => source.GroupBy(i => i).SelectMany(g => g.Skip(1)).Any();

        /// <summary>
        /// リストを指定した文字列で連結します。
        /// </summary>
        /// <typeparam name="T">型を指定します。</typeparam>
        /// <param name="list">変換対象のリストを指定します。</param>
        /// <param name="separator">連結文字列を指定します。</param>
        /// <returns>連結後の文字列を返します。</returns>
        public static string ToStringJoin<T>(this IEnumerable<T> list, string separator)
        {
            if (list != null)
            {
                return string.Join(separator, list);
            }
            else
            {
                return "";
            }
        }
    }
}
