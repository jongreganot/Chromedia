﻿namespace Chromedia.DataAccess.Base
{
    public interface IBaseService<T>
    {
        public Task<string> GetAll();
    }
}