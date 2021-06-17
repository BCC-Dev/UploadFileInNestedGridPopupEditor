using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UploadFileInNestedGridPopupEditor.ViewModels
{
    public class FileVM
    {
        [Key]
        public int Id { get; set; }
        public int BidId { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [StringLength(32)]
        [Display(Name = "Type")]
        public string Mimetype { get; set; }

        [UIHint("FileUpload")]
        [Required]
        public string FileUrl { get; set; }
        [DataType(DataType.Upload)]
        public IFormFile FileUpload { get; set; }
    }
}