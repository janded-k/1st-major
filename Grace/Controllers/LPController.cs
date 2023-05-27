using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Grace.Controllers
{
    public class LPController : Controller
    {

        public IActionResult PeterObiArrivesOwerriToCommissionAHouse()
        {
            return View();
        }

        public IActionResult MbakaOnWhyPeterObiCantBePresident()
        {
            return View();
        }

        public IActionResult NasarawaMatchForObi()
        {
            return View();
        }

        public IActionResult PeterObiChoosesARunningMate()
        {
            return View();
        }

        public IActionResult PeterObiRepliesKwankwaso()
        {
            return View();
        }

        public ActionResult KwankwasoOnHisRefusalTobeObiRunningMate()
        {
            return View();
        }

        public IActionResult LabourPartyWinsAbiaGuber()
        {
            return View();
        }

        public IActionResult PeterObiDefeatsTinubuInLagos()
        {
            return View();
        }

        public IActionResult ObiHires20SANsToReclaimHisMandate()
        {
            return View();
        }

        public IActionResult PeterObiGoesToChattamHouse()
        {
            return View();
        }

        public IActionResult ObasanjoEndorsesObi()
        {
            return View();
        }

        // GET: LPController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LPController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LPController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LPController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LPController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LPController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LPController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LPController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
