using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi
{
    public class Actor 
    {
        [Column("first_name")]

        public string FirstName { get; set; }

        [Column("last_name")]

        public string LastName { get; set; }

        [Column("actor_id")]

        public int Id { get; set; }
    }
}


// TODO: code first migrations