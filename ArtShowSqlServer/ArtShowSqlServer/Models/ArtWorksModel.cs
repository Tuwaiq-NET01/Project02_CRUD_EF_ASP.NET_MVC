using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArtShowSqlServer.Models
{
    public class ArtWorksModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]

        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }

        //rel

        public int ArtsitId { get; set; }
        public ArtsitsModel Artsit { get; set; }


        public int User_Id { get; set; }
        public UsersModel User { get; set; }
    }
}
