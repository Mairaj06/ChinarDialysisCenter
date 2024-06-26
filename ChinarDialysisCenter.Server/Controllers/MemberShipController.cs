using ChinarDialysisCenter.Business.Interfaces;
using ChinarDialysisCenter.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChinarDialysisCenter.Server.Controllers
{
    [ApiController]
    
    public class MemberShipController : ControllerBase
    {
        private readonly IManageMemberships manageMemberships;
        public MemberShipController(IManageMemberships manageMemberships)
        {
            this.manageMemberships = manageMemberships;
        }
        [Route("GetMembers")]
        [HttpGet]
        // GET: MemberShipController
        public ActionResult GetMembers()
        {
            return Ok();
        }

        //// GET: MemberShipController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return Ok();
        //}

        //// GET: MemberShipController/Create
        //public ActionResult Create()
        //{
        //    return Ok();
        //}

        [Route("AddMember")]
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Post(Membership member)
        {
            bool result = await manageMemberships.AddMemberShip(member);
            if (!result)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something Went Wrong");
            }
            return Ok(result);
        }

        // GET: MemberShipController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return Ok();
        //}

        //// POST: MemberShipController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return Ok();
        //    }
        //}

        //// GET: MemberShipController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return Ok();
        //}

        //// POST: MemberShipController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return Ok();
        //    }
        //}
    }
}
