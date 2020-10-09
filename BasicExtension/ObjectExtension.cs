using System;
using Newtonsoft.Json;

namespace BasicExtension
{
    /// <summary>
    /// .NETクラス階層のすべてのクラスに対して、拡張メソッドを提供する拡張クラスです。
    /// </summary>
    public static class ObjectExtension
    {
        /// <summary>
        /// オブジェクトをJSONにシリアライズします。
        /// </summary>
        /// <param name="arg">オブジェクトを指定します。</param>
        /// <returns>シリアライズされたJSONを文字列で返します。</returns>
        public static string ToJson(this object arg)
        {
            string json = string.Empty;

            try
            {
                if (arg != null)
                {
                    json = JsonConvert.SerializeObject(arg);
                }
            }
            catch (Exception)
            { }

            return json;
        }

        /// <summary>
        /// オブジェクトをJSONにシリアライズします。 戻り値は、変換が成功したかどうかを示します。
        /// </summary>
        /// <param name="arg">オブジェクトを指定します。</param>
        /// <param name="result">
        /// シリアライズに成功した場合、このメソッドが返されるときにシリアライズされたJSON文字列を格納します。
        /// 変換に失敗した場合にはNULLを返します。
        /// </param>
        /// <returns>シリアライズに成功した場合はtrue、そうでない場合falseを返します。</returns>
        public static bool TryToJson(this object arg, out string result)
        {
            bool isResult = false;
            result = null;

            try
            {
                if (arg != null) throw new Exception();

                result = JsonConvert.SerializeObject(arg);
                isResult = true;
            }
            catch
            { }

            return isResult;
        }
    }
}
