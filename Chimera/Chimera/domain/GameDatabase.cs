using Chimera.repositories;

namespace Chimera.domain
{
  public class GameDatabase
  {
    public string Name { get; set; } 
    public string Path { get; set; }

    public string ConnectionString => $"Data Source={Path};Version=3;";
  }
}