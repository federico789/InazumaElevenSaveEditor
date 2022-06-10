﻿using System;
using System.Collections.Generic;
using InazumaElevenSaveEditor.Logic;

namespace InazumaElevenSaveEditor.Common.InazumaElevenGo
{
    public static class Equipments
    {
        // Missing Go / Galaxy Equipments

        public static IDictionary<UInt32, Equipment> Go = new Dictionary<UInt32, Equipment>
        {

        };

        public static IDictionary<UInt32, Equipment> Cs = new Dictionary<UInt32, Equipment>
        {
            {0x00000000, new Equipment(" ", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000001, new Equipment(" ", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000002, new Equipment(" ", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0, 0, 0})},
            {0x00000003, new Equipment(" ", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0, 0, 0})},
            {0x03451545, new Equipment("Practice Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0, 0, 0})},
            {0xA21FD033, new Equipment("Raimon Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 1, 0, 0, 0, 1, 0, 0, 0})},
            {0x184ED9AA, new Equipment("Black Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 4, 0, 0, 0, 0, 0, 0, 0})},
            {0x8E7EDEDD, new Equipment("Prodigy Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 4, 0, 0, 0, 4, 0, 0, 0})},
            {0x2DEBBA43, new Equipment("Milky Way Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 9, 0, 0, 0, 9, 0, 0, 0})},
            {0xBBDBBD34, new Equipment("Almighty Faith Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 17, 0, 0, 0, 9, 0, 0, 0})},
            {0x018AB4AD, new Equipment("Royal Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 21, 0, 0, 0, 5, 0, 0, 0})},
            {0x97BAB3DA, new Equipment("Pirates Cove Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 23, 0, 0, 0, 9, 0, 0, 0})},
            {0x06A70C4A, new Equipment("Lunar Sea Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 16, 0, 0, 0, 24, 0, 0, 0})},
            {0x751ECC5D, new Equipment("Alpine Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 11, 0, 0, 0, 35, 0, 0, 0})},
            {0xE32ECB2A, new Equipment("Kirkwood Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 23, 0, 0, 0, 23, 0, 0, 0})},
            {0x597FC2B3, new Equipment("Mirage Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 33, 0, 0, 0, 19, 0, 0, 0})},
            {0x6CDAA15A, new Equipment("Universal Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 19, 0, 0, 0, 33, 0, 0, 0})},
            {0xFAEAA62D, new Equipment("Mount Olympus Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 42, 0, 0, 0, 18, 0, 0, 0})},
            {0x40BBAFB4, new Equipment("Dragon Link Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 30, 0, 0, 0, 30, 0, 0, 0})},
            {0xD68BA8C3, new Equipment("Eternal Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 45, 0, 0, 0, 25, 0, 0, 0})},
            {0x47961753, new Equipment("Ancient Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 25, 0, 0, 0, 45, 0, 0, 0})},
            {0xD1A61024, new Equipment("Zero Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 10, 0, 0, 0, 70, 0, 0, 0})},
            {0xB64DE176, new Equipment("Reserve Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 7, 0, 0, 0, 7, 0, 0, 0})},
            {0x207DE601, new Equipment("Golden Oldies Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 12, 0, 0, 0, 28, 0, 0, 0})},
            {0x9A2CEF98, new Equipment("Ivy Selective Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 8, 0, 0, 0})},
            {0x0C1CE8EF, new Equipment("Kids Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 2, 0, 0, 0, 16, 0, 0, 0})},
            {0xCCCB5430, new Equipment("Sherwind Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 2, 0, 0, 0})},
            {0x769A5DA9, new Equipment("Omega Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 8, 0, 0, 0, 0, 0, 0, 0})},
            {0x433F3E40, new Equipment("White Deer sandals", new EquipmentType("Boots"), new List<int>(){0, 0, 13, 0, 0, 0, 1, 0, 0, 0})},
            {0xD50F3937, new Equipment("Omega Z Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 16, 0, 0, 0, 2, 0, 0, 0})},
            {0xF96E37D9, new Equipment("Zanark Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 24, 0, 0, 0, 16, 0, 0, 0})},
            {0x68738849, new Equipment("Cascade Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 28, 0, 0, 0, 12, 0, 0, 0})},
            {0x1BCA485E, new Equipment("Zan Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 35, 0, 0, 0, 11, 0, 0, 0})},
            {0x8DFA4F29, new Equipment("Gihl Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 26, 0, 0, 0, 26, 0, 0, 0})},
            {0x37AB46B0, new Equipment("Gahl Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 12, 0, 0, 0, 40, 0, 0, 0})},
            {0xA19B41C7, new Equipment("Ragnah Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 50, 0, 0, 0, 10, 0, 0, 0})},
            {0x020E2559, new Equipment("Werewolf Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 55, 0, 0, 0, 15, 0, 0, 0})},
            {0x943E222E, new Equipment("Vampire Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 15, 0, 0, 0, 55, 0, 0, 0})},
            {0x2E6F2BB7, new Equipment("Nocturnal Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 70, 0, 0, 0, 10, 0, 0, 0})},
            {0xB85F2CC0, new Equipment("Champion Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 20, 0, 0, 0, 40, 0, 0, 0})},
            {0x29429350, new Equipment("Despairado Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 40, 0, 0, 0, 12, 0, 0, 0})},
            {0xBF729427, new Equipment("Leggendary Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 35, 0, 0, 0, 35, 0, 0, 0})},
            {0xD8996575, new Equipment("Global Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 40, 0, 0, 0, 40, 0, 0, 0})},
            {0x4EA96202, new Equipment("National Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 40, 0, 0, 0, 20, 0, 0, 0})},
            {0xF4F86B9B, new Equipment("Genesis Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 43, 0, 0, 0, 9, 0, 0, 0})},
            {0x95751232, new Equipment("Thunder Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 9, 0, 0, 0, 23, 0, 0, 0})},
            {0x2F241BAB, new Equipment("Discipline Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 19, 0, 0, 0, 7, 0, 0, 0})},
            {0xB9141CDC, new Equipment("Flurry Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 6, 0, 0, 0, 26, 0, 0, 0})},
            {0x1A817842, new Equipment("Verdant Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 5, 0, 0, 0, 9, 0, 0, 0})},
            {0x8CB17F35, new Equipment("Combustion Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 21, 0, 0, 0, 11, 0, 0, 0})},
            {0x36E076AC, new Equipment("Terra Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 20, 0, 0, 0, 20, 0, 0, 0})},
            {0xA0D071DB, new Equipment("Terror Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 9, 0, 0, 0, 17, 0, 0, 0})},
            {0x31CDCE4B, new Equipment("Sports shoes", new EquipmentType("Boots"), new List<int>(){0, 0, 2, 0, 0, 0, 0, 0, 0, 0})},
            {0xA7FDC93C, new Equipment("Smart Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 2, 0, 0, 0, 2, 0, 0, 0})},
            {0x42740E5C, new Equipment("Stripe Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 12, 0, 0, 0, 6, 0, 0, 0})},
            {0xD444092B, new Equipment("Victory Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 5, 0, 0, 0, 21, 0, 0, 0})},
            {0x6E1500B2, new Equipment("Power Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 32, 0, 0, 0, 14, 0, 0, 0})},
            {0xF82507C5, new Equipment("Harlequin Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 14, 0, 0, 0, 32, 0, 0, 0})},
            {0x5BB0635B, new Equipment("Boat Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 5, 0, 0, 0, 3, 0, 0, 0})},
            {0xCD80642C, new Equipment("Gantleman Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 6, 0, 0, 0, 12, 0, 0, 0})},
            {0x77D16DB5, new Equipment("Devotion Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 2, 0, 0, 0, 6, 0, 0, 0})},
            {0xE1E16AC2, new Equipment("Panther Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 0, 0, 0, 0, 4, 0, 0, 0})},
            {0x70FCD552, new Equipment("Echo Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 9, 0, 0, 0, 5, 0, 0, 0})},
            {0xE6CCD225, new Equipment("Uplifting Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 16, 0, 0, 0, 16, 0, 0, 0})},
            {0x81272377, new Equipment("Vitality Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 15, 0, 0, 0, 11, 0, 0, 0})},
            {0x17172400, new Equipment("Premium Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 18, 0, 0, 0, 42, 0, 0, 0})},
            {0x893F234D, new Equipment("Waterproof Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 8, 0, 0, 0, 32, 0, 0, 0})},
            {0x336E2AD4, new Equipment("Tonghanian Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 6, 0, 0, 0, 2, 0, 0, 0})},
            {0xA55E2DA3, new Equipment("Dashing sandals", new EquipmentType("Boots"), new List<int>(){0, 0, 3, 0, 0, 0, 11, 0, 0, 0})},
            {0x06CB493D, new Equipment("Bright sandals", new EquipmentType("Boots"), new List<int>(){0, 0, 11, 0, 0, 0, 3, 0, 0, 0})},
            {0x90FB4E4A, new Equipment("Bright sandals", new EquipmentType("Boots"), new List<int>(){0, 0, 11, 0, 0, 0, 21, 0, 0, 0})},
            {0x2AAA47D3, new Equipment("Shinsengumi sandals", new EquipmentType("Boots"), new List<int>(){0, 0, 26, 0, 0, 0, 6, 0, 0, 0})},
            {0xBC9A40A4, new Equipment("Noble Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 14, 0, 0, 0, 4, 0, 0, 0})},
            {0x2D87FF34, new Equipment("Peasant Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 4, 0, 0, 0, 14, 0, 0, 0})},
            {0xBBB7F843, new Equipment("Aristocrat Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 29, 0, 0, 0, 17, 0, 0, 0})},
            {0xDC5C0911, new Equipment("Sabaton Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 17, 0, 0, 0, 29, 0, 0, 0})},
            {0x4A6C0E66, new Equipment("Eastern Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 7, 0, 0, 0, 19, 0, 0, 0})},
            {0xF03D07FF, new Equipment("Fortress Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 13, 0, 0, 0, 13, 0, 0, 0})},
            {0x660D0088, new Equipment("Automated Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 36, 0, 0, 0, 16, 0, 0, 0})},
            {0xC5986416, new Equipment("Binary Boots", new EquipmentType("Boots"), new List<int>(){0, 0, 9, 0, 0, 0, 43, 0, 0, 0})},
            {0x2F5F97AB, new Equipment("Raimon Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 1, 0, 0, 0, 1, 0})},
            {0x950E9E32, new Equipment("Black Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0, 4, 0})},
            {0x033E9945, new Equipment("Prodigy Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 4, 0, 0, 0, 4, 0})},
            {0xA0ABFDDB, new Equipment("Milky Way Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 9, 0, 0, 0, 9, 0})},
            {0x369BFAAC, new Equipment("Almighty Faith Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 9, 0, 0, 0, 17, 0})},
            {0x8CCAF335, new Equipment("Royal Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 5, 0, 0, 0, 21, 0})},
            {0x1AFAF442, new Equipment("Pirates Cove Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 9, 0, 0, 0, 23, 0})},
            {0x8BE74BD2, new Equipment("Lunar Sea Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 24, 0, 0, 0, 16, 0})},
            {0xF85E8BC5, new Equipment("Alpine Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 35, 0, 0, 0, 11, 0})},
            {0x6E6E8CB2, new Equipment("Kirkwood Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 23, 0, 0, 0, 23, 0})},
            {0xD43F852B, new Equipment("Mirage Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 19, 0, 0, 0, 33, 0})},
            {0xE19AE6C2, new Equipment("Universal Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 33, 0, 0, 0, 19, 0})},
            {0x77AAE1B5, new Equipment("Mount Olympus Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 18, 0, 0, 0, 42, 0})},
            {0xCDFBE82C, new Equipment("Dragon Link Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 30, 0, 0, 0, 30, 0})},
            {0x5BCBEF5B, new Equipment("Eternal Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 25, 0, 0, 0, 45, 0})},
            {0xCAD650CB, new Equipment("Ancient Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 45, 0, 0, 0, 25, 0})},
            {0x5CE657BC, new Equipment("Zero Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 70, 0, 0, 0, 10, 0})},
            {0x3B0DA6EE, new Equipment("Reserve Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 7, 0, 0, 0, 7, 0})},
            {0xAD3DA199, new Equipment("Golden Oldies Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 28, 0, 0, 0, 12, 0})},
            {0x176CA800, new Equipment("Ivy Selective Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 8, 0, 0, 0, 0, 0})},
            {0x815CAF77, new Equipment("Kids Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 16, 0, 0, 0, 2, 0})},
            {0x418B13A8, new Equipment("Sherwind Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 2, 0, 0, 0, 0, 0})},
            {0xFBDA1A31, new Equipment("Omega Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0,  8, 0})},
            {0xCE7F79D8, new Equipment("White Deer Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 1, 0, 0, 0, 13, 0})},
            {0x584F7EAF, new Equipment("Omega Z Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 2, 0, 0, 0, 16, 0})},
            {0x742E7041, new Equipment("Zanark Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 16, 0, 0, 0, 24, 0})},
            {0xE533CFD1, new Equipment("Cascade Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 12, 0, 0, 0, 28, 0})},
            {0x968A0FC6, new Equipment("Zan Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 11, 0, 0, 0, 35, 0})},
            {0x00BA08B1, new Equipment("Ghil Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 26, 0, 0, 0, 26, 0})},
            {0xBAEB0128, new Equipment("Gahl Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 40, 0, 0, 0, 12, 0})},
            {0x2CDB065F, new Equipment("Ragnah Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 10, 0, 0, 0, 50, 0})},
            {0x8F4E62C1, new Equipment("Werewolf Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 15, 0, 0, 0, 55, 0})},
            {0x197E65B6, new Equipment("Vampire Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 55, 0, 0, 0, 15, 0})},
            {0xA32F6C2F, new Equipment("Nocturnal Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 10, 0, 0, 0, 70, 0})},
            {0x351F6B58, new Equipment("Champion Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 40, 0, 0, 0, 20, 0})},
            {0xA402D4C8, new Equipment("Despairado Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 12, 0, 0, 0, 40, 0})},
            {0x3232D3BF, new Equipment("Leggendary Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 35, 0, 0, 0, 35, 0})},
            {0x55D922ED, new Equipment("Earth Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 40, 0, 0, 0, 40, 0})},
            {0xC3E9259A, new Equipment("National Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 20, 0, 0, 0, 40, 0})},
            {0x79B82C03, new Equipment("Genesis Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 9, 0, 0, 0, 43, 0})},
            {0x183555AA, new Equipment("Thunder Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 23, 0, 0, 0, 9, 0})},
            {0xA2645C33, new Equipment("Discipline Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 7, 0, 0, 0, 19, 0})},
            {0x34545B44, new Equipment("Flurry Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 26, 0, 0, 0, 6, 0})},
            {0x97C13FDA, new Equipment("Verdant Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 9, 0, 0, 0, 5, 0})},
            {0x01F138AD, new Equipment("Combustion Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 11, 0, 0, 0, 21, 0})},
            {0xBBA03134, new Equipment("Terra Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 20, 0, 0, 0, 20, 0})},
            {0x2D903643, new Equipment("Terror Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 17, 0, 0, 0, 9, 0})},
            {0xBC8D89D3, new Equipment("Sports Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0, 2, 0})},
            {0x2ABD8EA4, new Equipment("Smart Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 2, 0, 0, 0, 2, 0})},
            {0xCF3449C4, new Equipment("Stripe Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 6, 0, 0, 0, 12, 0})},
            {0x59044EB3, new Equipment("Victory Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 21, 0, 0, 0, 5, 0})},
            {0xE355472A, new Equipment("Power Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 14, 0, 0, 0, 32, 0})},
            {0x7565405D, new Equipment("Harlequin Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 32, 0, 0, 0, 14, 0})},
            {0xD6F024C3, new Equipment("Sailor Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 3, 0, 0, 0, 5, 0})},
            {0x40C023B4, new Equipment("Gentleman's Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 12, 0, 0, 0, 6, 0})},
            {0xFA912A2D, new Equipment("Devotion Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 6, 0, 0, 0, 2, 0})},
            {0x6CA12D5A, new Equipment("Panther Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 4, 0, 0, 0, 0, 0})},
            {0xFDBC92CA, new Equipment("Echo Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 5, 0, 0, 0, 9, 0})},
            {0x6B8C95BD, new Equipment("Uplifting Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 16, 0, 0, 0, 16, 0})},
            {0x0C6764EF, new Equipment("Vitality Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 11, 0, 0, 0, 15, 0})},
            {0x9A576398, new Equipment("Premium Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 42, 0, 0, 0, 18, 0})},
            {0x047F64D5, new Equipment("waterproof Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 32, 0, 0, 0, 8, 0})},
            {0xBE2E6D4C, new Equipment("Tonghanian Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 2, 0, 0, 0, 6, 0})},
            {0x281E6A3B, new Equipment("Dashing Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 11, 0, 0, 0, 3, 0})},
            {0x8B8B0EA5, new Equipment("Bright Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 3, 0, 0, 0, 11, 0})},
            {0x1DBB09D2, new Equipment("Warrior Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 21, 0, 0, 0, 11, 0})},
            {0xA7EA004B, new Equipment("Shinsengumi Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 6, 0, 0, 0, 26, 0})},
            {0x31DA073C, new Equipment("Noble Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 4, 0, 0, 0, 14, 0})},
            {0xA0C7B8AC, new Equipment("Peasant Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 14, 0, 0, 0, 4, 0})},
            {0x36F7BFDB, new Equipment("Aristocrat Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 17, 0, 0, 0, 29, 0})},
            {0x511C4E89, new Equipment("Gauntlets", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 29, 0, 0, 0, 17, 0})},
            {0xC72C49FE, new Equipment("Eastern Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 19, 0, 0, 0, 7, 0})},
            {0x7D7D4067, new Equipment("Fortress Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 13, 0, 0, 0, 13, 0})},
            {0xEB4D4710, new Equipment("Automated Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 16, 0, 0, 0, 36, 0})},
            {0x48D8238E, new Equipment("Binary Gloves", new EquipmentType("Gloves"), new List<int>(){0, 0, 0, 0, 43, 0, 0, 0, 9, 0})},
            {0x497C0C0A, new Equipment("Red Bracelet", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 1, 0, 3})},
            {0xF32D0593, new Equipment("Leather Bracelet", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 3, 0, 1})},
            {0x651D02E4, new Equipment("Colorful Bracelet", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0, 0, 0})},
            {0xC688667A, new Equipment("Passion Bracelet", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 44, 0, 8})},
            {0x50B8610D, new Equipment("Seed Bracelet", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 10, 0, 4})},
            {0xEAE96894, new Equipment("Friendship Bracelet", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 5, 0, 3})},
            {0x7CD96FE3, new Equipment("Musscle Bracelet", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 35, 0, 11})},
            {0xEDC4D073, new Equipment("Fervour Bracelet", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 25, 0, 7})},
            {0x7BF4D704, new Equipment("Youth Bracelet", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 0, 0, 0})},
            {0x9E7D1064, new Equipment("Stylish Bracelet", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 15, 0, 3})},
            {0x084D1713, new Equipment("Victory Bracelet", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 18, 0, 8})},
            {0xB21C1E8A, new Equipment("Wild Bracelet", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 50, 0, 10})},
            {0x242C19FD, new Equipment("Lucky Bracelet", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 10, 0, 50})},
            {0x87B97D63, new Equipment("Wish Bracelet", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 58, 0, 12})},
            {0x11897A14, new Equipment("Active Bracelet", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 3, 0, 15})},
            {0xABD8738D, new Equipment("Rainbow Bracelet", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 30, 0, 10})},
            {0x3DE874FA, new Equipment("Exotic Bracelet", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 8, 0, 18})},
            {0xACF5CB6A, new Equipment("Cosmos Bracelet", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 8, 0, 44})},
            {0x3AC5CC1D, new Equipment("Courage Bracelet", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 7, 0, 25})},
            {0x5D2E3D4F, new Equipment("Sacred Bracelet", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 11, 0, 35})},
            {0xCB1E3A38, new Equipment("Paradise Bracelet", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 10, 0, 30})},
            {0x714F33A1, new Equipment("Tezcat's Bracelet", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 12, 0, 58})},
            {0xE77F34D6, new Equipment("Dirty Bracelet", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 2, 0, 0})},
            {0x44EA5048, new Equipment("Angelic Bracelet", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 5, 0, 75})},
            {0xD2DA573F, new Equipment("Demonic Bracelet", new EquipmentType("Bracelet"), new List<int>(){0, 0, 0, 0, 0, 0, 0, 75, 0, 5})},
            {0x0C6D44B5, new Equipment("Drop Pendant", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 2, 0, 2, 0, 0, 0, 0})},
            {0xB63C4D2C, new Equipment("Diamond Pendant", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 30, 0, 10, 0, 0, 0, 0})},
            {0x200C4A5B, new Equipment("Heart Pendant", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 15, 0, 3, 0, 0, 0, 0})},
            {0x83992EC5, new Equipment("Cross Pendant", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 44, 0, 8, 0, 0, 0, 0})},
            {0x15A929B2, new Equipment("Lucky Pendant", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 4, 0, 10, 0, 0, 0, 0})},
            {0xAFF8202B, new Equipment("Stylish Pendant", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 3, 0, 15, 0, 0, 0, 0})},
            {0x39C8275C, new Equipment("Silver Pendant", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 35, 0, 11, 0, 0, 0, 0})},
            {0xA8D598CC, new Equipment("Chain Pendant", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 4, 0, 4, 0, 0, 0, 0})},
            {0x3EE59FBB, new Equipment("Gothic Pendant", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 8, 0, 44, 0, 0, 0, 0})},
            {0xDB6C58DB, new Equipment("Inazuma Pendant", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 50, 0, 10, 0, 0, 0, 0})},
            {0x4D5C5FAC, new Equipment("Fervour Pendant", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 25, 0, 7, 0, 0, 0, 0})},
            {0xF70D5635, new Equipment("Youth Pendant", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 10, 0, 4, 0, 0, 0, 0})},
            {0x613D5142, new Equipment("Vow Pendant", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 12, 0, 58, 0, 0, 0, 0})},
            {0xC2A835DC, new Equipment("Victory Pendant", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 18, 0, 8, 0, 0, 0, 0})},
            {0x549832AB, new Equipment("Wish Pendant", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 58, 0, 12, 0, 0, 0, 0})},
            {0xEEC93B32, new Equipment("Promise Pendant", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 8, 0, 18, 0, 0, 0, 0})},
            {0x78F93C45, new Equipment("Courage Pendant", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 7, 0, 25, 0, 0, 0, 0})},
            {0xE9E483D5, new Equipment("Sacred Pendant", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 11, 0, 35, 0, 0, 0, 0})},
            {0x7FD484A2, new Equipment("Paradise Pendant", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 10, 0, 30, 0, 0, 0, 0})},
            {0x183F75F0, new Equipment("Infinity Pendant", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 10, 0, 50, 0, 0, 0, 0})},
            {0x8E0F7287, new Equipment("Rusty Pendant", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 1, 0, 1, 0, 0, 0, 0})},
            {0x345E7B1E, new Equipment("Protection Pendant", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 5, 0, 75, 0, 0, 0, 0})},
            {0xA26E7C69, new Equipment("Destruction Pendant", new EquipmentType("Pendant"), new List<int>(){0, 0, 0, 75, 0, 5, 0, 0, 0, 0})},
        };

        public static IDictionary<UInt32, Equipment> Galaxy = new Dictionary<UInt32, Equipment>
        {

        };
    }
}
