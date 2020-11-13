using System;
using System.Net;
using System.Data;
using System.Linq;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNet.OData.Query;



namespace CaApp.Controllers.ConData
{
  using Models;
  using Data;
  using Models.ConData;

  [ODataRoutePrefix("odata/conData/SchoolClasses")]
  [Route("mvc/odata/conData/SchoolClasses")]
  public partial class SchoolClassesController : ODataController
  {
    private Data.ConDataContext context;

    public SchoolClassesController(Data.ConDataContext context)
    {
      this.context = context;
    }
    // GET /odata/ConData/SchoolClasses
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.ConData.SchoolClass> GetSchoolClasses()
    {
      var items = this.context.SchoolClasses.AsQueryable<Models.ConData.SchoolClass>();
      this.OnSchoolClassesRead(ref items);

      return items;
    }

    partial void OnSchoolClassesRead(ref IQueryable<Models.ConData.SchoolClass> items);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{ID}")]
    public SingleResult<SchoolClass> GetSchoolClass(int key)
    {
        var items = this.context.SchoolClasses.Where(i=>i.ID == key);
        return SingleResult.Create(items);
    }
    partial void OnSchoolClassDeleted(Models.ConData.SchoolClass item);
    partial void OnAfterSchoolClassDeleted(Models.ConData.SchoolClass item);

    [HttpDelete("{ID}")]
    public IActionResult DeleteSchoolClass(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.SchoolClasses
                .Where(i => i.ID == key)
                .Include(i => i.Students)
                .FirstOrDefault();

            if (item == null)
            {
                return BadRequest();
            }

            this.OnSchoolClassDeleted(item);
            this.context.SchoolClasses.Remove(item);
            this.context.SaveChanges();
            this.OnAfterSchoolClassDeleted(item);

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnSchoolClassUpdated(Models.ConData.SchoolClass item);
    partial void OnAfterSchoolClassUpdated(Models.ConData.SchoolClass item);

    [HttpPut("{ID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutSchoolClass(int key, [FromBody]Models.ConData.SchoolClass newItem)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (newItem == null || (newItem.ID != key))
            {
                return BadRequest();
            }

            this.OnSchoolClassUpdated(newItem);
            this.context.SchoolClasses.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.SchoolClasses.Where(i => i.ID == key);
            this.OnAfterSchoolClassUpdated(newItem);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    [HttpPatch("{ID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PatchSchoolClass(int key, [FromBody]Delta<Models.ConData.SchoolClass> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.SchoolClasses.Where(i => i.ID == key).FirstOrDefault();

            if (item == null)
            {
                return BadRequest();
            }

            patch.Patch(item);

            this.OnSchoolClassUpdated(item);
            this.context.SchoolClasses.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.SchoolClasses.Where(i => i.ID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnSchoolClassCreated(Models.ConData.SchoolClass item);
    partial void OnAfterSchoolClassCreated(Models.ConData.SchoolClass item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.ConData.SchoolClass item)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (item == null)
            {
                return BadRequest();
            }

            this.OnSchoolClassCreated(item);
            this.context.SchoolClasses.Add(item);
            this.context.SaveChanges();

            return Created($"odata/ConData/SchoolClasses/{item.ID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
