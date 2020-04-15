using System;

namespace System.Data.Objects.Core
{
	public class EntityFunctions
    {

        /// <summary>
        /// When used as part of a LINQ to Entities query, this method return the given date with the time portion cleared.
        /// </summary>
        /// <param name="dateValue"></param>
        /// <returns></returns>
        public static System.DateTimeOffset? TruncateTime(System.DateTimeOffset? dateValue)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// When used as part of a LINQ to Entities query, this method return the given date with the time portion cleared.
        /// </summary>
        /// <param name="dateValue"></param>
        /// <returns></returns>
        public static System.DateTime? TruncateTime(System.DateTime? dateValue)
        {
            throw new NotImplementedException();
        }

        public static System.Int32? DiffDays(System.DateTimeOffset? dateValue1, System.DateTimeOffset? dateValue2)
        {
            throw new NotImplementedException();
        }

        public static System.Int32? DiffDays(System.DateTime? dateValue1, System.DateTime? dateValue2)
        {
            throw new NotImplementedException();
        }

    }
}
