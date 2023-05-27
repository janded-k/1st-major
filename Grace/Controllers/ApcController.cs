using Grace.Data;
using Grace.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Grace.Controllers
{
    public class ApcController : Controller
    {
        private readonly ApplicationDbContext Fuse;

        public ApcController( ApplicationDbContext Work)
        {
            
            Fuse = Work;
        }

        public IActionResult NnamaniChimeToLeadCampaignForTinubuInEnugu()
        {
            return View();
        }

        public IActionResult KebbiBusinessManBuyTinubuForm()
        {
            return View();
        }

        public ActionResult EmirOfDutseEndorsesAmaechi()
        {
            return View();
        }

        public ActionResult DelegatesBribedToVoteAmaechiSays()
        {
            return View();
        }

        public ActionResult CautionYourSupportersTinubu()
        {
            return View();
        }

        public ActionResult BuhariReceivesTinubuAndShettima()
        {
            return View();
        }

        public ActionResult ApcWinsEkitiGuberElection()
        {
            return View();
        }

        public ActionResult ApcUnveilsShettimaAsTinubuRunningMate()
        {
            return View();
        }

        public ActionResult OsibanjoHasNotSteppedDown()
        {
            return View();
        }

        public ActionResult IAmMoreQualifiedThanTinubuOsibanjoSaysAmaechi()
        {
            return View();
        }

        public ActionResult TinubuApcGovnrs()
        {
            return View();
        }

        public ActionResult PresidentiaFormBuyers()
        {
            return View();
        }

        public ActionResult ThreeAspirantsSteppedDownForVc()
        {
            return View();
        }

        public ActionResult TinubuWinsPresidentiaPrimaries()
        {
            return View();
        }

        public ActionResult YouCanLickYourWounds()
        {
            return View();
        }

        public ActionResult TinubuMeetsWithNANSLeaders()
        {
            return View();
        }

        public ActionResult TinubuDeclaredPresident()
        {
            return View();
        }

        // GET: ApcController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ApcController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ApcController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ApcController/Create
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

        // GET: ApcController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ApcController/Edit/5
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

        // GET: ApcController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ApcController/Delete/5
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
