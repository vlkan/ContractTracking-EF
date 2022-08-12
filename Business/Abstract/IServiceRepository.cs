using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract;

public interface IServiceRepository<T>
{
    IDataResult<List<T>> GetAll();
    IResult Add(T entity);
    IResult Update(T entity);
    IResult Delete(T entity);
    IResult SoftDelete(T entity);
}
