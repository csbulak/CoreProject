﻿namespace Application.Features.Dtos.Role;

public class RoleModel
{
    public string RoleId { get; set; }
    public string UserId { get; set; }
    public string RoleGroupId { get; set; }
    public long BitwiseId { get; set; }
    public string RoleGroupName { get; set; }
    public string RoleName { get; set; }
}