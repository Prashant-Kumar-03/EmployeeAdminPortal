﻿namespace EmployeeAdminPortal.Models
{
    public class UpdateEmployeeDto
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? Phone { get; set; } //? means nullable property
        public decimal salary { get; set; }
    }
}

