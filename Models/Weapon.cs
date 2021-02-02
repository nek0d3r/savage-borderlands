using savage_borderlands.Constants;

namespace savage_borderlands.Models
{
    public class Weapon : BaseEntity
    {
        public WeaponCategory Category { get; set; }
        public ItemQuality Quality { get; set; }
        public ItemBrand Brand { get; set; }
    }
}