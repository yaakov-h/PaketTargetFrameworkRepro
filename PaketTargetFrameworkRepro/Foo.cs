using System;
using Newtonsoft.Json;

namespace PaketTargetFrameworkRepro
{
    public class Foo
    {
        public string GetSomeCoolValue()
        {
            return JsonConvert.SerializeObject(new { hello = "world " });
        }
    }
}
