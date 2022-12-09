using System;

namespace OpenBed.Service
{
    public interface IUserService
    {
        Guid GetUserId();
        bool IsAuthenticated();
    }
}