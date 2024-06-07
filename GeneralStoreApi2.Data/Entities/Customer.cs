using System;
using System.Collections.Generic;
using GeneralStore2.WebApi.Models;

namespace GeneralStore2.Data.Entities;

public partial class Customer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
