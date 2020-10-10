using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace BasicExtension
{
    /// <summary>
    /// 文字列クラスの拡張メソッドを実装したクラスです。
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// 文字列のNULLチェックを行います。
        /// </summary>
        /// <param name="arg">チェック対象の文字列を指定します。</param>
        /// <returns>NULLの場合は空文字を、そうでない場合は引数をそのまま返します。</returns>
        public static string ToStringOrEmpty(this string arg)
        {
            string ret = string.Empty;
            if (arg != null)
            {
                ret = arg;
            }

            return ret;
        }

        public static string[] Split(this string arg, string splitValue)
        {
            return arg.Split(new[] { splitValue }, StringSplitOptions.RemoveEmptyEntries);
        }

        /// <summary>
        /// 文字列が空またはNULLかチェックします。
        /// 空またはNULLの場合は、デフォルト値を返します。
        /// </summary>
        /// <param name="arg">チェックする文字列を指定します。</param>
        /// <param name="defaultValue">デフォルト値を指定します。</param>
        /// <returns>チェック後の文字列を返します。</returns>
        public static string ToStringOrDefaultValue(this string arg, string defaultValue)
        {
            string ret = arg;

            bool isNullOrEmpty = string.IsNullOrEmpty(arg);
            if (isNullOrEmpty == true)
            {
                ret = defaultValue;
            }

            return ret;
        }

        /// <summary>
        /// 文字列を数字にキャストします。
        /// キャストできない場合は、0を返します。
        /// </summary>
        /// <param name="arg">チェック対象の文字列を指定します。</param>
        /// <returns>キャスト不可能な場合は0を、キャスト可能な場合はキャストした数値を返します。</returns>
        public static int ToIntOrZero(this string arg)
        {
            int ret = 0;

            int.TryParse(arg, out ret);

            return ret;
        }

        /// <summary>
        /// 文字列を数字にキャストします。
        /// キャストできない場合は、指定したデフォルト値を返します。
        /// </summary>
        /// <param name="arg">チェック対象の文字列を指定します。</param>
        /// <param name="art">数字に変換できない際の返り値を指定します。</param>
        /// <returns>キャスト不可能な場合は指定したデフォルト値を、キャスト可能な場合はキャストした数値を返します。</returns>
        public static int ToIntOrDefault(this string art, int defaultValue)
        {
            int ret = defaultValue;

            int result = 0;
            bool isInt = int.TryParse(art, out result);
            if (isInt == true)
            {
                ret = result;
            }

            return ret;
        }

        /// <summary>
        /// 文字列を数字にキャストします。
        /// キャストできない場合は、NULLを返します。
        /// </summary>
        /// <param name="arg">チェック対象の文字列を指定します。</param>
        /// <returns>キャスト不可能な場合はNULLを、キャスト可能な場合はキャストした数値を返します。</returns>
        public static int? ToIntOrNull(this string arg)
        {
            int? ret = null;

            int result = 0;
            bool isIint = int.TryParse(arg, out result);
            if (isIint == true)
            {
                ret = result;
            }

            return ret;
        }

        /// <summary>
        /// 文字列を真偽値にキャストします。
        /// キャストできない場合は、指定したデフォルト値を返します。
        /// </summary>
        /// <param name="arg">チェック対象の文字列を指定します。</param>
        /// <param name="arg">数字に変換できない際の返り値を指定します。</param>
        /// <returns>キャスト不可能な場合は指定したデフォルト値を、キャスト可能な場合はキャストした真偽値を返します。</returns>
        public static bool ToBoolOrDefault(this string arg, bool defaultValue)
        {
            bool ret = defaultValue;

            bool result = false;
            bool isInt = bool.TryParse(arg, out result);
            if (isInt == true)
            {
                ret = result;
            }

            return ret;
        }

        /// <summary>
        /// 文字列を真偽値にキャンストします。
        /// </summary>
        /// <param name="arg">チェック対象の文字列を指定します。</param>
        /// <param name="trueValue">trueと判断する文字列を指定します。</param>
        /// <returns>キャスト後の真偽値を返します。</returns>
        public static bool ToBool(this string arg, string trueValue)
        {
            if (arg == trueValue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// NULLチェックを行い、Split()処理を行います。
        /// </summary>
        /// <param name="arg">\分割対象の文字列を指定します。</param>
        /// <param name="separator">区切り文字を指定します。</param>
        /// <returns>分割後の文字列をリストで返します。</returns>
        public static List<string> SplitWithNullCheck(this string arg, char separator)
        {
            List<string> result = new List<string>();

            if (arg != null)
            {
                result = arg.Split(separator).ToList();
            }

            return result;
        }

        /// <summary>
        /// NULLチェックを行い、Trim()処理を行います。
        /// </summary>
        /// <param name="arg">Trim()対象を指定します。</param>
        /// <returns>Trim()後の値を返します。</returns>
        public static string TrimNullCheck(this string arg)
        {
            if (arg != null)
            {
                arg = arg.Trim();
            }

            return arg;
        }

        public static List<string> SplitByString(this string arg, string separator)
        {
            List<string> ret = new List<string>();

            if (arg != null)
            {
                ret = arg.Split(new string[] { separator }, StringSplitOptions.None).ToList();
            }

            return ret;
        }

        public static string ReplaceWithNullCheck(this string arg, string beforeValue, string afterValue)
        {
            if (arg != null)
            {
                arg = arg.Replace(beforeValue, afterValue);
            }

            return arg;
        }

        public static string RegexReplace(this string arg, string pattern, string afterValue)
        {
            if (arg != null)
            {
                Regex regex = new Regex(pattern);
                arg = regex.Replace(arg, afterValue);
            }

            return arg;
        }

        /// <summary>
        /// 文字列を指定し、CSVを壊さない文字列に置換します。
        /// </summary>
        /// <param name="arg">置換対象の文字列を指定します。</param>
        /// <returns>置換後の文字列を返します。</returns>
        public static string ConvertToCsvValue(this string arg)
        {
            if (arg == null)
            {
                arg = "";
            }
            else
            {
                arg = arg.Replace("−", "-");
            }

            return arg;
        }

        /// <summary>
        /// 指定した数だけ文字列の末尾を削除します。
        /// </summary>
        /// <param name="arg">削除対象の文字列を指定します。</param>
        /// <param name="removeLength">末尾から削除する文字数を指定します。</param>
        /// <returns>
        /// 末尾を削除した文字列を返します。
        /// ※指定した文字列より削除文字数の方が長い場合、空文字を返します。
        /// </returns>
        public static string RemoveRight(this string arg, int removeLength)
        {
            int maxLength = arg.Length;

            if (maxLength >= removeLength)
            {
                return arg.Remove(maxLength - removeLength);
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// 指定した文字列を日付情報に変換します。
        /// </summary>
        /// <param name="arg">変換対象の文字列を指定します。</param>
        /// <param name="format">日付のフォーマットを指定します。</param>
        /// <returns>
        /// 変換した日付情報に返します。
        /// 変換できない場合は、nullを返します。
        /// </returns>
        public static DateTime? ToDateTime(this string arg, string format)
        {
            DateTime? ret = null;

            if (string.IsNullOrEmpty(arg) == false)
            {
                DateTime dateTime = new DateTime();
                bool canCastDateTime = DateTime.TryParseExact(
                    arg, format, System.Globalization.DateTimeFormatInfo.InvariantInfo, System.Globalization.DateTimeStyles.None,
                    out dateTime);

                if (canCastDateTime == true)
                {
                    ret = dateTime;
                }
            }

            return ret;
        }

        /// <summary>
        /// JSONを指定し、指定したクラスインスタンスに変換します。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arg">JSONを指定します。</param>
        /// <returns></returns>
        public static T ToObject<T>(this string arg)
        {
            T result = default;

            if (string.IsNullOrEmpty(arg) == false)
            {
                result = JsonConvert.DeserializeObject<T>(arg);
            }

            return result;
        }

        /// <summary>
        /// ニッセンAPIのレスポンスを、C#のクラスにシリアライズできるように置換します。
        /// </summary>
        /// <param name="arg">ニッセンAPIのレスポンスを指定します。</param>
        /// <returns>置換後のニッセンAPIのレスポンスを返します。</returns>
        public static string FormatNissenApiresponse(this string arg)
        {
            if (arg != null)
            {
                string pattern = " xsi:type=.*>";
                Regex regex = new Regex(pattern);
                return regex.Replace(arg, ">");
            }
            else
            {
                return arg;
            }
        }

        /// <summary>
        /// ファイルパスを指定し、ディレクトリが存在しない場合は、作成します。
        /// </summary>
        /// <param name="arg">チェック対象のファイルパスを指定します。</param>
        public static string CreateDirectory(this string arg)
        {
            if (string.IsNullOrEmpty(arg) == false)
            {
                string directoryName = Path.GetDirectoryName(arg);
                if (Directory.Exists(directoryName) == false)
                {
                    Directory.CreateDirectory(directoryName);
                }
            }

            return arg;
        }

        public static int CountOf(this string target, params string[] strArray)
        {
            int count = 0;

            foreach (string str in strArray)
            {
                int index = target.IndexOf(str, 0);
                while (index != -1)
                {
                    count++;
                    index = target.IndexOf(str, index + str.Length);
                }
            }

            return count;
        }

        public static string ParseRegex(this string input, string pattern)
        {
            string ret = "";

            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);
            if (match.Success == true)
            {
                ret = match.Groups[1].Value;
            }

            return ret;
        }

        public static string AddCrValue(this string input, string addValue)
        {
            if (string.IsNullOrEmpty(addValue) == false)
            {
                if (string.IsNullOrEmpty(input) == false)
                {
                    input += "\n\n";
                }

                input += addValue;
            }

            return input;
        }

        public static string SubstringExtension(this string arg, int index, int length)
        {
            string ret = "";

            if (arg != null)
            {
                if (arg.Length >= (index + length))
                {
                    ret = arg.Substring(index, length);
                }
                else if (arg.Length >= index)
                {
                    ret = arg.Substring(index);
                }
            }

            return ret;
        }

        public static int Count(this string arg, string searchWord)
        {
            int count = 0;

            if (arg != null)
            {
                int index = -1; // 検索開始位置

                do
                {
                    index += 1;
                    index = arg.IndexOf(searchWord, index); // 検索文字列を指定
                    count++;
                }
                while (index >= 0);

                count--;
            }

            return count;
        }
    }
}
