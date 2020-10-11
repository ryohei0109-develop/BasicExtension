using System;

namespace BasicExtension
{
    /// <summary>
    /// 日付クラスの拡張メソッドを実装したクラスです。
    /// </summary>
    public static class DateTimeExtension
    {
        /// <summary>
        /// 月の最初の日を求める（DateTime版）
        /// </summary>
        /// <param name="dateTime">DateTime型のクラスを指定します。</param>
        /// <returns>月の最初の日を返します。</returns>
        public static DateTime GetFirstDateOfMonth(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, 1, 0, 0, 0);
        }

        /// <summary>
        /// 月の最後の日を求める（DateTime版）
        /// </summary>
        /// <param name="dateTime">DateTime型のクラスを指定します。</param>
        /// <returns>月の最後の日を返します。</returns>
        public static DateTime GetLastDateOfMonth(this DateTime dateTime)
        {
            int days = DateTime.DaysInMonth(dateTime.Year, dateTime.Month);
            return new DateTime(dateTime.Year, dateTime.Month, days);
        }

        // 月の最初の日を求める（DateTimeOffset版）
        public static DateTimeOffset GetFirstDateOfMonth(this DateTimeOffset dateTime)
        {
            return new DateTimeOffset(dateTime.Year, dateTime.Month, 1,
                                      0, 0, 0, dateTime.Offset);
        }

        // 月の最後の日を求める（DateTimeOffset版）
        public static DateTimeOffset GetLastDateOfMonth(this DateTimeOffset dateTime)
        {
            int days = DateTime.DaysInMonth(dateTime.Year, dateTime.Month);
            return new DateTimeOffset(dateTime.Year, dateTime.Month, days,
                                      0, 0, 0, dateTime.Offset);
        }

        /// <summary>
        /// 週初め(日曜日)の日付を計算
        /// </summary>
        /// <param name="dateTime">DateTime型のクラスを指定します。</param>
        /// <returns>週の最初の日(日曜日)を返します。</returns>
        public static DateTime GetFirstDateOfWeek(this DateTime dateTime)
        {
            return dateTime.AddDays(DayOfWeek.Sunday - dateTime.DayOfWeek);
        }

        /// <summary>
        /// NULL許容の日付オブジェクトを指定し、指定したフォーマットに変換します。
        /// </summary>
        /// <param name="arg">変換するNULL許容日付オブジェクトを指定します。</param>
        /// <param name="format">日付フォーマットを指定します。</param>
        /// <returns>日付オブジェクトがNULLの場合は空文字を、そうでない場合は指定したフォーマットの文字列を返します。</returns>
        public static string ToString(this DateTime? arg, string format)
        {
            string ret = string.Empty;

            if (arg != null)
            {
                ret = arg.Value.ToString(format);
            }

            return ret;
        }

        /// <summary>
        /// 開始日から終了日までの日数を計算します。
        /// 戻り値には正常に計算できた場合、期間の日数を返します。そうでない場合は、0を返します。
        /// </summary>
        /// <param name="startDate">開始日を指定します。</param>
        /// <param name="endDate">終了日を計算します。</param>
        /// <param name="includeStartDay">初日を期間に含めるかどうかのフラグを指定します。</param>
        /// <returns>期間の日数を返します。</returns>
        public static int DayCount(this DateTime startDate, DateTime endDate, bool includeStartDay)
        {
            if (startDate.Ticks > endDate.Ticks) return 0;
            TimeSpan span = startDate - endDate;
            int days = Math.Abs(span.Days);

            return (includeStartDay ? days + 1 : days);
        }
    }
}
