using WinFormsApp2.Interfaces;
using Newtonsoft.Json.Linq;

namespace WinFormsApp2.Classes;

public class Cast : ICast
{
    public JObject GetJObject(string json)
    {
        return JObject.Parse(json);
    }
}