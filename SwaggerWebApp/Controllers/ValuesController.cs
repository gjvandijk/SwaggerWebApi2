using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SwaggerWebApp.Models;

namespace SwaggerWebApp.Controllers
{
    /// <summary>
    /// Controller for manipulating a string array 
    /// </summary>
    public class ValuesController : ApiController
    {
        private List<ValueObj> lista
        {
            get
            {
                if (System.Web.HttpContext.Current.Application["lista"] == null)
                {
                    System.Web.HttpContext.Current.Application["lista"] =
                    new List<ValueObj>
                    {
                        new ValueObj("value1"),
                        new ValueObj("value2"),
                        new ValueObj("value3"),
                        new ValueObj("value4"),
                        new ValueObj("value5"),
                    };
                }
                return
                    (List<ValueObj>)System.Web.HttpContext.Current.Application["lista"];
            }
        }

        /// <summary>
        /// Retrieves the list of values
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ValueObj> Get()
        {
            return lista;
        }
        /// <summary>
        /// Retrieves one value from the list of values
        /// </summary>
        /// <param name="id">The id of the item to be retrieved</param>
        /// <returns></returns>
        public ValueObj Get(int id)
        {
            return lista[id];
        }
        /// <summary>
        /// Insert a single value in the list
        /// </summary>
        /// <param name="value">New value to be inserted</param>
        public void Post([FromBody] ValueObj value)
        {
            if (value == null)
            {
                value = new ValueObj("AddValue");
            }

            lista.Add(value);

        }
        /// <summary>
        /// Change a single value in the list
        /// </summary>
        /// <param name="id">The id of the value to be changed</param>
        /// <param name="value">The new value</param>
        public void Put(int id, [FromBody]ValueObj value)
        {
            if (value == null)
                value = new ValueObj("PutValue");
            lista[id] = value;
        }
        /// <summary>
        /// Delete an item from the list
        /// </summary>
        /// <param name="id">id of the item to be deleted</param>
        public void Delete(int id)
        {
            lista.RemoveAt(id);
        }
    }
}
