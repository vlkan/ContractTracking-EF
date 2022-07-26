﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class NotificationManager : INotificationService
{
    INotificationDal _notificationDal;

    public NotificationManager(INotificationDal notificationDal)
    {
        _notificationDal = notificationDal;
    }

    public IResult Add(Notification notification)
    {
        _notificationDal.Add(notification);
        return new SuccessResult(Messages.NotificationAdded);
    }

    public IResult Delete(Notification notification)
    {
        _notificationDal.Delete(notification);
        return new SuccessResult(Messages.NotificationDeleted);
    }

    public IResult SoftDelete(int id)
    {
        _notificationDal.SoftDelete(id);
        return new SuccessResult(Messages.NotificationDeleted);
    }

    public IDataResult<List<Notification>> GetAll()
    {
        return new SuccessDataResult<List<Notification>>(_notificationDal.GetAll(), Messages.NotificationListed);
    }

    public IResult Update(Notification notification)
    {
        _notificationDal.Update(notification);
        return new SuccessResult(Messages.NotificationUpdated);
    }
}
