﻿using System;
using System.Collections.Generic;
using GeneralStore2.Data.Entities;

namespace GeneralStore2.WebApi.Models;

public partial class Transaction
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int CustomerId { get; set; }

    public int Quantity { get; set; }

    public DateTime DateOfTransaction { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
