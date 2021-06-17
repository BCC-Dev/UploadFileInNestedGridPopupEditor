using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using System;
using System.IO;
using UploadFileInNestedGridPopupEditor.ViewModels;

namespace UploadFileInNestedGridPopupEditor.Controllers
{
    public class FileController : Controller
    {
        private IWebHostEnvironment _env;
        private FileExtensionContentTypeProvider contentTypeProvider = new FileExtensionContentTypeProvider();

        public FileController(IWebHostEnvironment env)
        {
            _env = env;
        }


        [HttpPost]
        public ActionResult Create([DataSourceRequest] DataSourceRequest request, string parentId, FileVM newFile)
        {
            int BidId = 0;
            byte[] fileBytes = null;
            FileInfo fileInfo = null;
            string fileContentType = contentTypeProvider.TryGetContentType(newFile.FileUrl, out var type) ? type : "application/octet-stream";
            try
            {
                fileInfo = new FileInfo(newFile.FileUrl);
                using (FileStream fileStream = fileInfo.OpenRead())
                {
                    BinaryReader br = new BinaryReader(fileStream);
                    fileBytes = br.ReadBytes((Int32)new FileInfo(newFile.FileUrl).Length);
                }
                BidId = int.Parse(parentId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return View("Error");
            }

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
