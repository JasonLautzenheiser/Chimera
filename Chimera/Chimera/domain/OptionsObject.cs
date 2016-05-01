using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace Chimera.domain
{
  public class OptionsObject
  {
    public string DatabaseFile { get; set; } = $@"{Application.StartupPath}\chimera.sqlite";


  }
}