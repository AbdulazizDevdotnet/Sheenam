//================================
// Copyright (c) Coalition of Good-Hearted Engineers 
// Free To Use To Find Comfort and Peace
//================================

using Microsoft.Data.SqlClient;
using Xeptions;

namespace Sheenam.Api.Models.Foundations.Guests.Exceptions
{
    public class FailedGuestStorageException:Xeption
    {
        private SqlException sqlException;

        public FailedGuestStorageException(Xeption innerException)
            :base(message: "Failed guest storage error occurred, contact support",
                 innerException)
        {}

        public FailedGuestStorageException(SqlException sqlException)
        {
            this.sqlException = sqlException;
        }
    }
}
