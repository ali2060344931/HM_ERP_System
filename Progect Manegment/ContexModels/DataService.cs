using Progect_Manegment;

using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// متد افزودن/ویرایش داده ها
/// </summary>
/// <typeparam name="T"></typeparam>
public class Repository<T> where T : class
{
    private readonly DBcontextModel _context;

    public Repository(DBcontextModel context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    //نحوه استفاده در فرم ها
    //    int LisId = integerInput1.Value;
    //            using (var context = new DBcontextModel())
    //{
    //    var userRepo = new Repository<Unit>(context);
    //    userRepo.SaveOrUpdate(new Unit { Id = LisId, Name = myTextBox1.Text }, LisId);
    //}


    /// <summary>
    /// ذخیره/ویرایش
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="id"></param>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="Exception"></exception>
    public bool SaveOrUpdate(T entity, int id = 0)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity));

        using (var transaction = _context.Database.BeginTransaction())
        {
            try
            {
                if (id == 0)
                {
                    _context.Set<T>().Add(entity);
                }
                else
                {
                    var existingEntity = _context.Set<T>().Find(id);
                    if (existingEntity != null)
                    {
                        _context.Entry(existingEntity).CurrentValues.SetValues(entity);
                    }
                    else
                    {
                        throw new Exception($"رکورد با شناسه {id} یافت نشد.");
                    }
                }

                _context.SaveChanges();
                transaction.Commit();
                return true;
            }
            catch (Exception er)
            {
                transaction.Rollback();
                //PublicClass.ShowErrorMessage("Repository", er);
                return false;

            }

            //catch (Exception ex)
            //{
            //    transaction.Rollback();
            //    //throw new Exception($"خطا در ذخیره یا ویرایش: {ex.Message}", ex);
            //    return true;

            //}
        }
    }
    
    public bool SaveOrUpdateByCommit(T entity, int id = 0)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity));

        //using (var transaction = _context.Database.BeginTransaction())
        {
            try
            {
                if (id == 0)
                {
                    _context.Set<T>().Add(entity);
                }
                else
                {
                    var existingEntity = _context.Set<T>().Find(id);
                    if (existingEntity != null)
                    {
                        _context.Entry(existingEntity).CurrentValues.SetValues(entity);
                    }
                    else
                    {
                        throw new Exception($"رکورد با شناسه {id} یافت نشد.");
                    }
                }

                //_context.SaveChanges();
                //transaction.Commit();
                return true;
            }
            catch (Exception er)
            {
                //transaction.Rollback();
                //PublicClass.ShowErrorMessage("Repository", er);
                return false;

            }

            //catch (Exception ex)
            //{
            //    transaction.Rollback();
            //    //throw new Exception($"خطا در ذخیره یا ویرایش: {ex.Message}", ex);
            //    return true;

            //}
        }
    }


    public int SaveOrUpdateRefId(T entity, int id = 0)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity));

        using (var transaction = _context.Database.BeginTransaction())
        {
            try
            {
                int resultId;

                if (id == 0)
                {
                    // افزودن رکورد جدید
                    _context.Set<T>().Add(entity);
                   _context.SaveChanges();

                    // استخراج Id از entity
                    resultId = (int)typeof(T).GetProperty("Id").GetValue(entity);
                }
                else
                {
                    // ویرایش رکورد موجود
                    var existingEntity = _context.Set<T>().Find(id);
                    if (existingEntity != null)
                    {
                        _context.Entry(existingEntity).CurrentValues.SetValues(entity);
                        _context.SaveChanges();
                        resultId = id; // در حالت ویرایش، همان id ورودی برگردانده می‌شود
                    }
                    else
                    {
                        throw new Exception($"رکورد با شناسه {id} یافت نشد.");
                    }
                }

                transaction.Commit();
                return resultId;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception($"خطا در ذخیره یا ویرایش: {ex.Message}", ex);
            }
        }
    }

    public int SaveOrUpdateRefIdByCommit(T entity, int id = 0)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity));

        //using (var transaction = _context.Database.BeginTransaction())
        {
            try
            {
                int resultId;

                if (id == 0)
                {
                    // افزودن رکورد جدید
                    _context.Set<T>().Add(entity);
                    _context.SaveChanges();

                    // استخراج Id از entity
                    resultId = (int)typeof(T).GetProperty("Id").GetValue(entity);
                }
                else
                {
                    // ویرایش رکورد موجود
                    var existingEntity = _context.Set<T>().Find(id);
                    if (existingEntity != null)
                    {
                        _context.Entry(existingEntity).CurrentValues.SetValues(entity);
                        _context.SaveChanges();
                        resultId = id; // در حالت ویرایش، همان id ورودی برگردانده می‌شود
                    }
                    else
                    {
                        throw new Exception($"رکورد با شناسه {id} یافت نشد.");
                    }
                }

                //transaction.Commit();
                return resultId;
            }
            catch (Exception ex)
            {
                //transaction.Rollback();
                throw new Exception($"خطا در ذخیره یا ویرایش: {ex.Message}", ex);
            }
        }
    }

    public T GetById(int id)
    {
        try
        {
            return _context.Set<T>().Find(id);
        }
        catch (Exception ex)
        {
            throw new Exception($"خطا در بازیابی رکورد با شناسه {id}: {ex.Message}", ex);
        }
    }

    public IEnumerable<T> GetAll()
    {
        try
        {
            return _context.Set<T>().AsNoTracking().ToList();
        }
        catch (Exception ex)
        {
            throw new Exception($"خطا در بازیابی داده‌ها: {ex.Message}", ex);
        }
    }




}