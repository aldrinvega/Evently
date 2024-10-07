using System.Data.Common;

namespace Evently.Modules.Events.Application.Abstraction.Data;

public interface IDbFactoryConnection
{
    ValueTask<DbConnection> OpenConnectionAsync();
}
