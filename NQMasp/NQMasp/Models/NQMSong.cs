using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NQMasp.Models
{
    public class NQMSong
    {
        public int nqmid { get; set; }
        [DisplayName("tiêu đề ")]
        [Required(ErrorMessage = "NQM: hãy nhập tiêu đề")]
        public string nqmTitle { get; set; }
        [DisplayName("tác giả")]
        [Required(ErrorMessage = "NQM:hãy nhập tác giả ")]
        public string nqmAuthor { get; set; }
        [DisplayName("nghệ sĩ ")]
        [Required(ErrorMessage = "NQM: hãy nhập nghệ sĩ ")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "NQM: độ dài trong khoảng từ [2-50]")]
        public string nqmArtist { get; set; }
        [DisplayName("năm suất bản")]
        [Required(ErrorMessage = "NQM: hãy nhập năm suất bản ")]
        [RegularExpression(@"0-9{}",ErrorMessage ="NQM: năm suất bản phải là 4 ký tự số ")]
        [Range(1900,2020,ErrorMessage ="NQM:năm suất bản khoảng 1900 - 2020 ")]
        public int nqmYaerRelease { get; set; }

    }
}