using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using GridTest.Models;

namespace GridTest.Pages {
    public class IndexModel : PageModel {
        public void OnGet() {

        }

        public virtual JsonResult OnGetProcedures(DataSourceLoadOptions options)
        {
            var listdto = new List<SecurityGroupProcedureForGridDto>();

            listdto.Add(new SecurityGroupProcedureForGridDto
            {
                Id = Guid.NewGuid(),
                ShortDescription = "ABC",
                SecurityGroupId = null,
                ProcedureId = Guid.NewGuid(),
                TenantId = Guid.NewGuid(),
                Status = null
            });

            listdto.Add(new SecurityGroupProcedureForGridDto
            {
                Id = Guid.NewGuid(),
                ShortDescription = "123",
                SecurityGroupId = null,
                ProcedureId = Guid.NewGuid(),
                TenantId = Guid.NewGuid(),
                Status = null
            });

            listdto.Add(new SecurityGroupProcedureForGridDto
            {
                Id = Guid.NewGuid(),
                ShortDescription = "XYZ",
                SecurityGroupId = null,
                ProcedureId = Guid.NewGuid(),
                TenantId = Guid.NewGuid(),
                Status = null
            });


            return new JsonResult(DataSourceLoader.Load(listdto, options));
        }

        public void OnPost()
        {
            //I want to be able to get the datagrid's collection of object I previously 
            //loaded and interogate each one

            Console.WriteLine("Execution Paused");
        }
    }
}
