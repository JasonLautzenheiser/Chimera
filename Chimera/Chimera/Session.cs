using System.IO;
using System.Windows.Forms;
using Chimera.domain;
using Chimera.repositories;
using Newtonsoft.Json;

namespace Chimera
{
  public static class Session
  {
    public static GameDatabase CurrentDatabase { get; set; }
    public static OptionsObject Options { get; set; }


    public static void LoadOptions()
    {
      var optionsPath = $@"{Application.StartupPath}\chimera.json";

      if (File.Exists(optionsPath))
      {
        OptionsObject options = JsonConvert.DeserializeObject<OptionsObject>(File.ReadAllText(optionsPath));
        Options = options;
      }
      else 
        Options = new OptionsObject();
    }

    public static void SaveOptions()
    {
      var optionsPath = $@"{Application.StartupPath}\chimera.json";
      File.WriteAllText(optionsPath, JsonConvert.SerializeObject(Options));
    }

    public static void OpenDatabase(string pDatabase = "")
    {
      if (pDatabase == string.Empty)
        pDatabase = Options.DatabaseFile;

      if (!DatabaseFactory.DatabaseFileExists(pDatabase))
        DatabaseFactory.CreateDatabase(pDatabase);

      var database = new GameDatabase
      {
        Path = pDatabase,
        Name = Path.GetFileName(pDatabase)
      };

      CurrentDatabase = database;
    }

  

  }
}