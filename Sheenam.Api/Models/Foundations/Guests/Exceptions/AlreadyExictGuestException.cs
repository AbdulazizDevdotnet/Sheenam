//================================
// Copyright (c) Coalition of Good-Hearted Engineers 
// Free To Use To Find Comfort and Peace
//================================

using System;
using Xeptions;

namespace Sheenam.Api.Models.Foundations.Guests.Exceptions
{
    public class AlreadyExictGuestException : Xeption
    {
        public AlreadyExictGuestException(Exception innerException)
            : base(message: "Guest already exists", innerException)
        { }
    }
}
