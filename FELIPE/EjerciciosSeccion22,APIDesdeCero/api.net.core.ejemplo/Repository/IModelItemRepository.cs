using api.net.core.ejemplo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.net.core.ejemplo.Repository
{
    public interface IModelItemRepository
    {
        Task AddModelItem(ModelItem model);
        void UpdateModelItem(ModelItem model);
        Task<ModelItem> Get(int id);
        ModelItem GetWhere(int id);
        Task Delete(int id);
    }
}
