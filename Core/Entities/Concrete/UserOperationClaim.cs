﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete;

public class UserOperationClaim : IEntity
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int OperationClaimId { get; set; }
    public DateTime CreatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public DateTime? ModifiedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int IsDeleted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}
