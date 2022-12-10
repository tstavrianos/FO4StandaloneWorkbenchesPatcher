using Mutagen.Bethesda.WPF.Reflection.Attributes;

namespace FO4StandaloneWorkbenchesPatcher
{
    internal class Settings
    {
        private bool _explosivesToWeaponsmithWorkbemch = false;
        private bool _explosivesToExplosivesWorkbench = true;

        [MaintainOrder] [SettingName("Ignore Vanilla Items")]
        public bool NoVanillaItems = true;

        [MaintainOrder] [SettingName("Only move recipes from Chem Station")]
        public bool FromChemistryStationOnly = true;

        [MaintainOrder] [SettingName("Move Ammo recipes to Ammunition Workbench")]
        public bool AmmunitionToAmmunitionWorkbench = true;

        [MaintainOrder] [SettingName("Move Armour recipes to Armorsmith Workbench")]
        public bool ArmorsToArmorsmithWorkbench = true;

        [MaintainOrder] [SettingName("Move Weapon recipes to Weaponsmith Workbench")]
        public bool WeaponsToWeaponsmithWorkbench = true;

        [MaintainOrder]
        [SettingName("Move Explosive/Throwable recipes to Weaponsmith Workbench")]
        [Tooltip(
            "Includes all sorts of items that can be equipped in the grenade slot: grenades, mines, traps, etc.")]
        public bool ExplosivesToWeaponsmithWorkbemch
        {
            get => _explosivesToWeaponsmithWorkbemch;
            set
            {
                _explosivesToWeaponsmithWorkbemch = value;
                if (_explosivesToWeaponsmithWorkbemch) ExplosivesToExplosivesWorkbench = false;
            }
        }

        [MaintainOrder]
        [SettingName("Move Explosive/Throwable recipes to Explosives Workbench")]
        [Tooltip(
            "Includes all sorts of items that can be equipped in the grenade slot: grenades, mines, traps, etc.")]
        public bool ExplosivesToExplosivesWorkbench
        {
            get => _explosivesToExplosivesWorkbench;
            set
            {
                _explosivesToExplosivesWorkbench = value;
                if (_explosivesToExplosivesWorkbench) ExplosivesToWeaponsmithWorkbemch = false;
            }
        }

        [MaintainOrder]
        [SettingName("Move ALCH (aid,food,...) recipes to Utility Workbench")]
        [Tooltip("Excludes items from the default HEALING, DRUG and SYRINGER AMMO category.")]
        public bool AlchemyToUtilityWorkbench = true;

        [MaintainOrder]
        [SettingName("Move MISC (mods,junk,..) recipes to Manufacturing and Utility Workbench respectively")]
        [Tooltip(
            "The recipes for MISC items with components/materials attached to them are transferred to the Manufacturing Workbench while the rest goes to the Utility Workbench.")]
        public bool MiscToManufacturingAndUtilityWorkbench = true;

        [MaintainOrder] [SettingName("Move NOTE (notes, holotapes,..) recipes to Utility Workbench")]
        public bool NotesToUtilityWorkbench = true;
    }
}