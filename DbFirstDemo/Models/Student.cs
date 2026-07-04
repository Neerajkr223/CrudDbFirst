using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DbFirstDemo.Models;

public partial class Student
{
    [Required]
    [DisplayName("Roll Number")]
    public int Roll { get; set; }
    [Required]
    [DisplayName("Student Name")]
    public string? StuName { get; set; }
    [Required]
    [DisplayName("Student Gender")]
    public string? StuGender { get; set; }
    [Required]
    [DisplayName("Student Date of Birth")]
    public DateOnly? StuDob { get; set; }
    [Required]
    [Length(10,13)]
    [DisplayName("Phone Number")]
    public string? StuPhone { get; set; }
}
