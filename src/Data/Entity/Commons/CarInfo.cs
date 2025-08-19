namespace Data.Entity.Commons
{
    public class CarInfo : EntityBase
    {
        //status 0 đang hoạt động, 1 đang sửa, 2 dừng hoạt động

        public Guid? CarTypeId { get; set; } //loại xe
        public Guid? BrandId { get; set; } //nhãn hiệu
        public int ManufactureYear { get; set; } // năm sản xuất
        public Guid? OilCategoryId { get; set; } // Loại dầu
        public int OilType { get; set; } // loại dầu:  0 --> DO 0,005%S , 1 --> DO 0,025%S (bỏ -> thay bằng OilCategoryId)
        public int? OilSuppliedCard { get; set; } // cấp dầu bằng thẻ : 0 áp dụng 1 không áp dụng
        public decimal? RoadTolls { get; set; } //phí đường bộ
        public double CarWeight { get; set; } //trọng lượng xe

        public double DesignWeight { get; set; } //khối lượng có thể chở thiết kế
        public double AllowWeight { get; set; } //khối lượng cho phép TGGT
    }
}
