using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class JsonAuthorMapper
    {
        public IEnumerable<Author> MapAuthors(string json)
        {
            var authors = JsonConvert.DeserializeObject<List<Author>>(json);
            return authors;
        }

        public IEnumerable<Novel> MapNovels(string json)
        {
            var novels = JsonConvert.DeserializeObject<IEnumerable<Novel>>(json);
            return novels;
        }
    }
}
