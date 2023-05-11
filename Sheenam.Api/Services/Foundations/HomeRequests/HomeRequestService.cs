//================================
// Copyright (c) Coalition of Good-Hearted Engineers 
// Free To Use To Find Comfort and Peace
//================================

using System;
using System.Threading.Tasks;
using Sheenam.Api.Brokers.Storages;
using Sheenam.Api.Models.Foundations.HomeRequests;
using Sheenam.Api.Services.Foundations.Guests;

namespace Sheenam.Api.Services.Foundations.HomeRequests
{
    public class HomeRequestService : IHomeRequestService
    {
        private readonly IStorageBroker storageBroker;

        public HomeRequestService(IStorageBroker storageBroker) =>
            this.storageBroker = storageBroker;

        public async ValueTask<HomeRequest> AddHomeRequestAsync(HomeRequest homeRequest) =>
            await this.storageBroker.InsertHomeRequestAsync(homeRequest);
    }
}
