﻿namespace Domain.Entities;

public class User : BaseEntity
{
    public Int32 UserID { get; set; }
    public String FirstName { get; set; }
    public String LastName { get; set; }
    public String UserName { get; set; }

    public String Email { get; set; }
    public String Password { get; set; }

    public virtual ICollection<UserRole> UserRoles { get; set; }
}