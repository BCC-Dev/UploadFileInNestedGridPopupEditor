using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using UploadFileInNestedGridPopupEditor.ViewModels;

namespace UploadFileInNestedGridPopupEditor.Controllers
{
    public class FileController : Controller
    {
        [HttpPost]
        public ActionResult Create([DataSourceRequest] DataSourceRequest request, string parentId, FileVM newFile)
        {
            return Json(request);
        }

        public ActionResult Read(string parentId, [DataSourceRequest] DataSourceRequest request)
        {
            return Json(request);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Update([DataSourceRequest] DataSourceRequest request, string parentId, FileVM newFileVM)
        {
            return Json(request);
        }

        //[HttpGet]
        //public FileResult DisplayFile(int id)
        //{
        //    byte[] fileData = _fileService.GetFileData(id);
        //    return new FileContentResult(fileData, "application/pdf");
        //}
    }
}
