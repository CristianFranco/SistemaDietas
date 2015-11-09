using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using agregaUsuario.Model;
using System.Linq.Expressions;
using System.Data.Entity;

namespace agregaUsuario.DataTransfer
{
    public abstract class DataLoader<T> where T : class
    {

        protected Expression<Func<T, bool>> enabledLambda = null;

        protected Action<T> disableLambda = null;

        private Dictionary<Type, string> selectDelegates = new Dictionary<Type, string>();

        internal Func<int, Expression<Func<T, bool>>> selectByIdExpression = null;

        public List<T> GetAll(List<string> relatedObjects = null)
        {
            List<T> list = null;
            sistema_dietaEntities ecdbe = null;
            try
            {
                ecdbe = new sistema_dietaEntities();
                var query = ecdbe.Set<T>().AsQueryable();
                if (relatedObjects != null)
                {
                    foreach (string obj in relatedObjects)
                    {
                        query = query.Include(obj);
                    }
                }

                list = query.ToList<T>();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                ecdbe.Dispose();
            }

            return list;
        }

        public T CreateNew(T element)
        {
            var ecdbe = new sistema_dietaEntities();
            T createdElement = default(T);
            try
            {
                createdElement = (T)ecdbe.Set(typeof(T)).Add(element);
                int lastId = ecdbe.SaveChanges();
            }
            catch (Exception ex)
            {
                createdElement = null;
            }
            finally
            {
                ecdbe.Dispose();
            }

            return createdElement;
        }
        public T GetElementById(int id, List<string> relatedObjects = null)
        {
            return this.GetElementByProperty(this.selectByIdExpression(id), relatedObjects);
        }

        public T GetElementByProperty(Expression<Func<T, bool>> exp, List<string> relatedObjects = null)
        {
            sistema_dietaEntities ecdbe = new sistema_dietaEntities();
            T element = default(T);
            try
            {
                var query = ecdbe.Set<T>().Where(exp);
                if (relatedObjects != null)
                {
                    foreach (string obj in relatedObjects)
                    {
                        query = query.Include(obj);
                    }
                }

                element = query.FirstOrDefault();
            }
            catch (Exception ex)
            {
                element = null;
            }
            finally
            {
                ecdbe.Dispose();
            }

            return element;
        }

        public List<T> GetListByProperty(Expression<Func<T, bool>> exp, List<string> relatedObjects = null)
        {
            sistema_dietaEntities ecdbe = new sistema_dietaEntities();
            List<T> elements = null;
            try
            {
                var query = ecdbe.Set<T>().Where(exp);
                if (relatedObjects != null)
                {
                    foreach (string obj in relatedObjects)
                    {
                        query = query.Include(obj);
                    }
                }

                elements = query.ToList<T>();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                ecdbe.Dispose();
            }

            return elements;
        }

        public List<T> GetCollectionByProperty(Expression<Func<T, bool>> exp, List<string> relatedObjects = null)
        {
            sistema_dietaEntities ecdbe = new sistema_dietaEntities();
            List<T> list = null;
            try
            {
                var query = ecdbe.Set<T>().Where(exp);
                if (relatedObjects != null)
                {
                    foreach (string obj in relatedObjects)
                    {
                        query = query.Include(obj);
                    }
                }
                list = query.ToList();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                ecdbe.Dispose();
            }

            return list;
        }

        public T EditElement(int id, IEnumerable<Action<T>> expressionsChanged)
        {
            sistema_dietaEntities ecdbe = new sistema_dietaEntities();
            T element = default(T);
            try
            {
                element = ecdbe.Set<T>().Where<T>(this.selectByIdExpression(id)).FirstOrDefault();
                if (element == null)
                {
                    return null;
                }

                foreach (var exp in expressionsChanged)
                {
                    exp(element);
                }

                ecdbe.SaveChanges();
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                ecdbe.Dispose();
            }

            return element;
        }

        public bool Disable(int id)
        {
            this.EditElement(id, new List<Action<T>> { this.disableLambda });
            return true;
        }

        private bool removeElement(T element) {
            bool bandReturn = true;
            sistema_dietaEntities entities = new  sistema_dietaEntities();
            try
            {
                var query = entities.Set<T>();
                query.Attach(element);
                var aux = query.Remove(element);
                entities.SaveChanges();
            }
            catch (Exception e)
            {
                bandReturn = false;
            }
            finally {
                entities.Dispose();
            }
            return bandReturn;
        }

        public bool removeElementById(int id)
        {
            bool bandReturn = true;
            sistema_dietaEntities entities = new sistema_dietaEntities();
            try
            {
                T element = default(T);
                element = entities.Set<T>().Where<T>(this.selectByIdExpression(id)).FirstOrDefault();
                var query = entities.Set<T>();
                query.Attach(element);
                query.Remove(element);
                entities.SaveChanges();
            }
            catch (Exception e)
            {
                bandReturn = false;
            }
            finally
            {
                entities.Dispose();
            }
            return bandReturn;
        } 
    }
}
