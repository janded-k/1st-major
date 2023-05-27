using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Grace.Controllers
{
    public class PdpController : Controller
    {

        public ActionResult ThoseWhoBoughtPdpPresidentialTicket()
        {
            return View();
        }

        public ActionResult AtikuWinsPdpPrimaries()
        {
            return View();
        }

        public ActionResult AtikuPicksOkowaAsRunningMate()
        {
            return View();
        }

        public ActionResult PdpWinsOsunGuber()
        {
            return View();
        }

        public ActionResult AtikuCampaignSpokeSpersons()
        {
            return View();
        }

        public ActionResult TambuwalStepsDownForAtiku()
        {
            return View();
        }

        public ActionResult PeterObiDecampsFromPdp()
        {
            return View();
        }

        public ActionResult Over1500DelegateAttendSarakiDeclaration()
        {
            return View();
        }

        public ActionResult WikeTakesPresidentialCampaignToBorno()
        {
            return View();
        }

        public ActionResult WikeTellsAnambraDelegateNotToWasteTheirVoteOnPeterObi()
        {
            return View();
        }

        public ActionResult WhyISteppedDownForAtiku()
        {
            return View();
        }

        public ActionResult DontBlameMeIfYouLose2023Election()
        {
            return View();
        }

        public ActionResult SarakiDocument()
        {
            return View();
        }

        public IActionResult AppealCourtDismissesAtikuRequest()
        {
            return View();
        }

        public ActionResult AtikuAndOthersWearBlackToProtestAtInecOffice()
        {
            return View();
        }

        public ActionResult PresidentialCandidateSignPeaceAccord()
        {
            return View();
        }
        // GET: PdpController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PdpController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PdpController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PdpController/Create
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

        // GET: PdpController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PdpController/Edit/5
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

        // GET: PdpController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PdpController/Delete/5
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
