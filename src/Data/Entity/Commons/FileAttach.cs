using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity.Commons
{
    public class FileAttach : EntityBase
    {
        /// <summary>
        /// Tên File hiển thị
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Tên file lưu trữ (tên file có + id)
        /// </summary>
        public string FileNameInSever { get; set; }

        /// <summary>
        /// Link truy cập
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// Phần mở rộng, đuôi file
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// Dung lượng file
        /// </summary>
        public double? Size { get; set; }

        /// <summary>
        /// Khóa ngoại
        /// </summary>
        public Guid? RefFileAttachId { get; set; }

        /// <summary>
        /// Byte
        /// </summary>
        public byte[] Binary { set; get; }

        /// <summary>
        /// File theo trường dữ liệu trong bảng
        /// </summary>
        public string DataFieldCategory { get; set; }

        /// <summary>
        /// File có được download hay không
        /// </summary>
        public bool IsAllowToDownload { get; set; }

        /// <summary>
        /// Phân loại thư mục lưu trữ
        /// </summary>
        public string FileTypeStorage { get; set; }

    }
}
