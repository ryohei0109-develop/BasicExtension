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
        /// <param name="theDay">DateTime型のクラスを指定します。</param>
        /// <returns>月の最初の日を返します。</returns>
        public static DateTime GetFirstDayOfMonth(this DateTime theDay)
        {
            return new DateTime(theDay.Year, theDay.Month, 1, 0, 0, 0);
        }

        /// <summary>
        /// 月の最後の日を求める（DateTime版）
        /// </summary>
        /// <param name="theDay">DateTime型のクラスを指定します。</param>
        /// <returns>月の最後の日を返します。</returns>
        public static DateTime GetLastDayOfMonth(this DateTime theDay)
        {
            int days = DateTime.DaysInMonth(theDay.Year, theDay.Month);
            return new DateTime(theDay.Year, theDay.Month, days);
        }

        // 月の最初の日を求める（DateTimeOffset版）
        public static DateTimeOffset GetFirstDayOfMonth(this DateTimeOffset theDay)
        {
            return new DateTimeOffset(theDay.Year, theDay.Month, 1,
                                      0, 0, 0, theDay.Offset);
        }

        // 月の最後の日を求める（DateTimeOffset版）
        public static DateTimeOffset GetLastDayOfMonth(this DateTimeOffset theDay)
        {
            int days = DateTime.DaysInMonth(theDay.Year, theDay.Month);
            return new DateTimeOffset(theDay.Year, theDay.Month, days,
                                      0, 0, 0, theDay.Offset);
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
