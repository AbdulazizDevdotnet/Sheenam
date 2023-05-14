﻿//================================
// Copyright (c) Coalition of Good-Hearted Engineers 
// Free To Use To Find Comfort and Peace
//================================

using Sheenam.Api.Models.Foundations.HomeRequests;
using Sheenam.Api.Models.Foundations.HomeRequests.Exceptions;
using Xunit;

namespace Sheenam.Api.Tests.Unit.Services.Foundations.HomeRequests
{
    public partial class HomeRequestServiceTests
    {
        [Fact]
        public async Task ShouldThrowValidationExceptionOnAddIfHomeRequestIsNullAndLogItAsync()
        {
            //given
            HomeRequest nullHomeRequest = null;
            var nullHomeRequestException = new NullHomeRequestException();

            var expectedHomeRequestValidationException =
                new HomeRequestValidationException(nullHomeRequestException);

            //when
            ValueTask<HomeRequest> addHomeRequestTask =
                this.homeRequestService.AddHomeRequestAsync(nullHomeRequest);

            //then
            await Assert.ThrowsAsync<HomeRequestValidationException>(() =>
                addHomeRequestTask.AsTask());


        }
    }
}
