namespace BigSchool.Models
{
    public class Following
    {
        public ApplicationUser Followee { get; internal set; }
        public ApplicationUser Follower { get; internal set; }
    }
}