using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp2.DomainClass;

[Table("MYUSER")]
public partial class Myuser
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("USERNAME")]
    [StringLength(50)]
    public string? Username { get; set; }

    [Column("MATKHAU")]
    [StringLength(50)]
    public string? Matkhau { get; set; }
}
