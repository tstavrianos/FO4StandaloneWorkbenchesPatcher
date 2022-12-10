// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class StandaloneWorkbenches
{
    public static class Furniture
    {
        private static FormLink<IFurnitureGetter> Construct(uint id) => new FormLink<IFurnitureGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IFurnitureGetter> wSW_AmmunitionWorkbench => Construct(0x800);
        public static FormLink<IFurnitureGetter> wSW_ArmorsmithWorkbench => Construct(0x803);
        public static FormLink<IFurnitureGetter> wSW_ClothingWorkbench => Construct(0x806);
        public static FormLink<IFurnitureGetter> wSW_DecalWorkbench => Construct(0x809);
        public static FormLink<IFurnitureGetter> wSW_ElectronicsWorkbench => Construct(0x80c);
        public static FormLink<IFurnitureGetter> wSW_EngineeringWorkbench => Construct(0x80f);
        public static FormLink<IFurnitureGetter> wSW_ExplosivesWorkbench => Construct(0x812);
        public static FormLink<IFurnitureGetter> wSW_PackagingWorkbench => Construct(0x815);
        public static FormLink<IFurnitureGetter> wSW_PaintWorkbench => Construct(0x818);
        public static FormLink<IFurnitureGetter> wSW_UtilityWorkbench => Construct(0x81b);
        public static FormLink<IFurnitureGetter> wSW_WeaponsmithWorkbench => Construct(0x81e);
        public static FormLink<IFurnitureGetter> wSW_ManufacturingWorkbench => Construct(0x821);
        public static FormLink<IFurnitureGetter> wSW_ProduceWorkbench => Construct(0x825);
    }
}
