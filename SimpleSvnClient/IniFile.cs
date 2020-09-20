using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace SimpleSvnClient
{
  public class IniFile
  {
    private readonly string _appName = Assembly.GetExecutingAssembly().GetName().Name;
    private string _path;

    public IniFile(string iniPath = null)
    {
      _path = new FileInfo(iniPath ?? _appName + ".ini").FullName;
    }

    public string Path
    {
      get => _path;
      set => _path = value;
    }

    public string Read(string section, string key, string defaultValue = "")
    {
      var RetVal = new StringBuilder(255);
      GetPrivateProfileString(section, key, defaultValue, RetVal, 255, _path);
      return RetVal.ToString();
    }

    public void Write(string section, string key, string value)
    {
      WritePrivateProfileString(section, key, value, _path);
    }

    public void DeleteKey(string section, string key)
    {
      Write(key, null, section);
    }

    public void DeleteSection(string section)
    {
      Write(null, null, section);
    }

    public bool Exists(string section, string key)
    {
      return Read(key, section).Length > 0;
    }

    [DllImport("kernel32", CharSet = CharSet.Unicode)]
    private static extern long WritePrivateProfileString(string section, string key, string value, string filePath);

    [DllImport("kernel32", CharSet = CharSet.Unicode)]
    private static extern int GetPrivateProfileString(string section, string key, string defaultValue, StringBuilder retVal, int size, string filePath);
  }
}