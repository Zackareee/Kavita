﻿using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface IUnitOfWork
    {
        ISeriesRepository SeriesRepository { get; }
        IUserRepository UserRepository { get; }
        ILibraryRepository LibraryRepository { get; }
        Task<bool> Complete();
        bool HasChanges();
    }
}