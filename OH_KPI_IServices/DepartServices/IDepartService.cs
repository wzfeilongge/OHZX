using OH_KPI_Application.DepartDTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OH_KPI_IServices.DepartServices
{
   public interface IDepartService
    {
        Task<OutDepart> GetDepartZBList(InDepart model);

        Task<OutDepartD> GetDepartDetail(InDepartD model);
    }
}
