using Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    public class JsonParser
    {
        public IEnumerable<Author> ParseAuthors(string json)
        {
            List<Author> authors = JsonConvert.DeserializeObject<List<Author>>(json);
            return authors;
        }
    }
}
