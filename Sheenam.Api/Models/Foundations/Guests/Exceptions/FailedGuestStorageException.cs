//================================
// Copyright (c) Coalition of Good-Hearted Engineers 
// Free To Use To Find Comfort and Peace
//================================

using System;
using Microsoft.Data.SqlClient;
using Xeptions;

namespace Sheenam.Api.Models.Foundations.Guests.Exceptions
{
    public class FailedGuestStorageException:Xeption
    {
        private SqlException sqlException;

        public FailedGuestStorageException(Exception innerException)
            :base(message: "Failed guest storage error occurred, contact support",
                 innerException)
        {}  
    }
}
