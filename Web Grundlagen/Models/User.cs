using System;

namespace Web_Grundlagen.Models
{
    public class User
    {
        private int id;
        public int Id
        {
            get { return this.id; }
            set
            {
                if (value >= 0)
                {
                    this.id = value;
                }
            }
        }
        public string Username { get; set; }
        public string Passsword { get; set; }
        public DateTime Birthdate { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }

        public User()
        {
        }

        public User(int id, string username, string passsword, DateTime birthdate, string email, Gender gender)
        {
            Id = id;
            Username = username;
            Passsword = passsword;
            Birthdate = birthdate;
            Email = email;
            Gender = gender;
        }

        public override string ToString()
        {
            return Id + "\n" + Username + "\n" + Passsword + "\n" + Birthdate.ToLongDateString();
        }
    }
}