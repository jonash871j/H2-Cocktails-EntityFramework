using System.Collections.Generic;

namespace Cocktails.Controllers
{
    public interface IController<T, PKEY>
    {
        /// <summary>
        /// Used to create object in table
        /// </summary>
        /// <param name="object">object refrence</param>
        public void Create(T @object);
        /// <summary>
        /// Used to update object in table
        /// </summary>
        /// <param name="object">object refrence</param>
        public void Update(T @object);
        /// <summary>
        /// Used to delete specfic object in table
        /// </summary>
        /// <param name="key">Primary key of object</param>
        public void Delete(PKEY key);
        /// <summary>
        /// Used to delete all objects in table
        /// </summary>
        public void DeleteAll();
        /// <summary>
        /// Used to get all objects in table
        /// </summary>
        public List<T> GetAll();
        /// <summary>
        /// Used to get specfic object
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Primary key of object</returns>
        public T Get(PKEY key);
    }
}
