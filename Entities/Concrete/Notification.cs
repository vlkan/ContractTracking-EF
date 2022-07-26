﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete;

public class Notification : IEntity
{
    public int Id { get; set; }
    public NotificationType Type { get; set; }
    public string Message { get; set; }
    public EnumIsDeleted? IsDeleted { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? ModifiedAt { get; set; }
}
public enum NotificationType : int
{
    Payment = 1,
    NewCustomer = 2,
    NewProject = 3,
    ProjectExpiration = 4,
}
