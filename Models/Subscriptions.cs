using System;

namespace API_TeamGE.Models
{

    public class Subcriptions
    {
    public int Id { get; set; }
    public int FollowerId { get; set; }
    public int AuthorId { get; set;  }
    public DateTime CreatedOn { get; set; }

    }
}