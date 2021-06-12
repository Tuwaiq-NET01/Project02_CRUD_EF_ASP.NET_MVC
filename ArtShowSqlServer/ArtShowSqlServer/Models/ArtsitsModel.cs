using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtShowSqlServer.Models
{
    public class ArtsitsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberPhone { get; set; }

        //rel
        public List<ArtWorksModel> ArtWorks { get; set; }

    }
}
