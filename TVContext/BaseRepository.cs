﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace TvContext
{
    public sealed class BaseRepository<TEntity> where TEntity : IdentificableEntity
    {
        public TvDbContext ContextDb { get; } = new TvDbContext();

        public BaseRepository()
        {

        }

        public BaseRepository(TvDbContext context)
        {
            ContextDb = context;
        }

        public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {
            return ContextDb.Set<TEntity>().Where(predicate);
        }

        public IQueryable<TEntity> GetAll()
        {
            return ContextDb.Set<TEntity>();
        }

        public async void Remove(TEntity entity)
        {
            try
            {
                ContextDb.Set<TEntity>().Remove(entity);
                await ContextDb.SaveChangesAsync();
            }
            catch (DbEntityValidationException dbEx)
            {
                MessageBox.Show("Что-то пошло не так при операции АПДЕЙТ!");
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation(
                            "Class: {0}, Property: {1}, Error: {2}",
                            validationErrors.Entry.Entity.GetType().FullName,
                            validationError.PropertyName,
                            validationError.ErrorMessage);
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }

        public async void Update(TEntity entity)
        {
            try
            {
                ContextDb.Entry(entity).State = EntityState.Modified;
                await ContextDb.SaveChangesAsync();
            }
            catch (DbEntityValidationException dbEx)
            {
                MessageBox.Show("Что-то пошло не так при операции АПДЕЙТ!");
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation(
                            "Class: {0}, Property: {1}, Error: {2}",
                            validationErrors.Entry.Entity.GetType().FullName,
                            validationError.PropertyName,
                            validationError.ErrorMessage);
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }

        }

        public async void Insert(TEntity entity)
        {
            try
            {
                ContextDb.Entry(entity).State = EntityState.Added;
                await ContextDb.SaveChangesAsync();
            }
            catch (DbEntityValidationException dbEx)
            {
                MessageBox.Show("Что-то пошло не так при операции ИНСЕРТ!");

                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation(
                            "Class: {0}, Property: {1}, Error: {2}",
                            validationErrors.Entry.Entity.GetType().FullName,
                            validationError.PropertyName,
                            validationError.ErrorMessage);
                    }

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }


        //todo needs to Rewrite for any TEntity
        public async void AddRange(IEnumerable<OrderChannel> channels)
        {
            try
            {
                ContextDb.OrderChannels.AddRange(channels);
                await ContextDb.SaveChangesAsync();
            }
            catch (DbEntityValidationException dbEx)
            {
                MessageBox.Show("Что-то пошло не так при операции ИНСЕРТ!");

                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation(
                            "Class: {0}, Property: {1}, Error: {2}",
                            validationErrors.Entry.Entity.GetType().FullName,
                            validationError.PropertyName,
                            validationError.ErrorMessage);
                    }

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
            
        }

        public async void RemoveRange(IEnumerable<OrderChannel> deleteChann)
        {
            ContextDb.OrderChannels.RemoveRange(deleteChann);
            await ContextDb.SaveChangesAsync();
        }

        public async void AddRange(IEnumerable<UserSchedule> userSchedule)
        {
            try
            {
                ContextDb.UserSchedules.AddRange(userSchedule);
                await ContextDb.SaveChangesAsync();
            }
            catch (DbEntityValidationException dbEx)
            {
                MessageBox.Show("Что-то пошло не так при операции ИНСЕРТ!");

                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation(
                            "Class: {0}, Property: {1}, Error: {2}",
                            validationErrors.Entry.Entity.GetType().FullName,
                            validationError.PropertyName,
                            validationError.ErrorMessage);
                    }

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
          
        }

        public async void RemoveRange(IEnumerable<UserSchedule> deleteUserSchedules)
        {
            ContextDb.UserSchedules.RemoveRange(deleteUserSchedules);
            await ContextDb.SaveChangesAsync();
        }

        public async void AddRange(IEnumerable<Channel> channels)
        {
            ContextDb.Channels.AddRange(channels);
            await ContextDb.SaveChangesAsync();
        }

        public async void AddRange(IEnumerable<TvShow> tvShowList)
        {
            ContextDb.TvShows.AddRange(tvShowList);
            await ContextDb.SaveChangesAsync();
        }
    }
}