using System;

namespace SceneIt.DAL.Interfaces
{
    public interface IDatabaseFactory : IDisposable
    {
        SceneItContext Get();
    }
}
