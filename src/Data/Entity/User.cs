using Data.Entity.Commons;

namespace Data.Entity
{
    public class User : EntityBase
    {
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string FullName { get; set; }

        public string Avatar { get; set; }

        public string Phone { get; set; }

        public string Description { get; set; }

        public bool? IsOnline { get; set; }

        public string DisplayName { get; set; }
    }
}
