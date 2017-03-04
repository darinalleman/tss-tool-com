#region Copyright
////////////////////////////////////////////////////////////////////////////////
// The following FIT Protocol software provided may be used with FIT protocol
// devices only and remains the copyrighted property of Dynastream Innovations Inc.
// The software is being provided on an "as-is" basis and as an accommodation,
// and therefore all warranties, representations, or guarantees of any kind
// (whether express, implied or statutory) including, without limitation,
// warranties of merchantability, non-infringement, or fitness for a particular
// purpose, are specifically disclaimed.
//
// Copyright 2017 Dynastream Innovations Inc.
////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 20.24Release
// Tag = production/akw/20.24.01-0-g5fa480b
////////////////////////////////////////////////////////////////////////////////

#endregion

namespace Dynastream.Fit
{
    /// <summary>
    /// Implements the profile GarminProduct type as a class
    /// </summary>
    public static class GarminProduct 
    {
        public const ushort Hrm1 = 1;
        public const ushort Axh01 = 2; // AXH01 HRM chipset
        public const ushort Axb01 = 3;
        public const ushort Axb02 = 4;
        public const ushort Hrm2ss = 5;
        public const ushort DsiAlf02 = 6;
        public const ushort Hrm3ss = 7;
        public const ushort HrmRunSingleByteProductId = 8; // hrm_run model for HRM ANT+ messaging
        public const ushort Bsm = 9; // BSM model for ANT+ messaging
        public const ushort Bcm = 10; // BCM model for ANT+ messaging
        public const ushort Axs01 = 11; // AXS01 HRM Bike Chipset model for ANT+ messaging
        public const ushort HrmTriSingleByteProductId = 12; // hrm_tri model for HRM ANT+ messaging
        public const ushort Fr225SingleByteProductId = 14; // fr225 model for HRM ANT+ messaging
        public const ushort Fr301China = 473;
        public const ushort Fr301Japan = 474;
        public const ushort Fr301Korea = 475;
        public const ushort Fr301Taiwan = 494;
        public const ushort Fr405 = 717; // Forerunner 405
        public const ushort Fr50 = 782; // Forerunner 50
        public const ushort Fr405Japan = 987;
        public const ushort Fr60 = 988; // Forerunner 60
        public const ushort DsiAlf01 = 1011;
        public const ushort Fr310xt = 1018; // Forerunner 310
        public const ushort Edge500 = 1036;
        public const ushort Fr110 = 1124; // Forerunner 110
        public const ushort Edge800 = 1169;
        public const ushort Edge500Taiwan = 1199;
        public const ushort Edge500Japan = 1213;
        public const ushort Chirp = 1253;
        public const ushort Fr110Japan = 1274;
        public const ushort Edge200 = 1325;
        public const ushort Fr910xt = 1328;
        public const ushort Edge800Taiwan = 1333;
        public const ushort Edge800Japan = 1334;
        public const ushort Alf04 = 1341;
        public const ushort Fr610 = 1345;
        public const ushort Fr210Japan = 1360;
        public const ushort VectorSs = 1380;
        public const ushort VectorCp = 1381;
        public const ushort Edge800China = 1386;
        public const ushort Edge500China = 1387;
        public const ushort Fr610Japan = 1410;
        public const ushort Edge500Korea = 1422;
        public const ushort Fr70 = 1436;
        public const ushort Fr310xt4t = 1446;
        public const ushort Amx = 1461;
        public const ushort Fr10 = 1482;
        public const ushort Edge800Korea = 1497;
        public const ushort Swim = 1499;
        public const ushort Fr910xtChina = 1537;
        public const ushort Fenix = 1551;
        public const ushort Edge200Taiwan = 1555;
        public const ushort Edge510 = 1561;
        public const ushort Edge810 = 1567;
        public const ushort Tempe = 1570;
        public const ushort Fr910xtJapan = 1600;
        public const ushort Fr620 = 1623;
        public const ushort Fr220 = 1632;
        public const ushort Fr910xtKorea = 1664;
        public const ushort Fr10Japan = 1688;
        public const ushort Edge810Japan = 1721;
        public const ushort VirbElite = 1735;
        public const ushort EdgeTouring = 1736; // Also Edge Touring Plus
        public const ushort Edge510Japan = 1742;
        public const ushort HrmTri = 1743;
        public const ushort HrmRun = 1752;
        public const ushort Fr920xt = 1765;
        public const ushort Edge510Asia = 1821;
        public const ushort Edge810China = 1822;
        public const ushort Edge810Taiwan = 1823;
        public const ushort Edge1000 = 1836;
        public const ushort VivoFit = 1837;
        public const ushort VirbRemote = 1853;
        public const ushort VivoKi = 1885;
        public const ushort Fr15 = 1903;
        public const ushort VivoActive = 1907;
        public const ushort Edge510Korea = 1918;
        public const ushort Fr620Japan = 1928;
        public const ushort Fr620China = 1929;
        public const ushort Fr220Japan = 1930;
        public const ushort Fr220China = 1931;
        public const ushort ApproachS6 = 1936;
        public const ushort VivoSmart = 1956;
        public const ushort Fenix2 = 1967;
        public const ushort Epix = 1988;
        public const ushort Fenix3 = 2050;
        public const ushort Edge1000Taiwan = 2052;
        public const ushort Edge1000Japan = 2053;
        public const ushort Fr15Japan = 2061;
        public const ushort Edge520 = 2067;
        public const ushort Edge1000China = 2070;
        public const ushort Fr620Russia = 2072;
        public const ushort Fr220Russia = 2073;
        public const ushort VectorS = 2079;
        public const ushort Edge1000Korea = 2100;
        public const ushort Fr920xtTaiwan = 2130;
        public const ushort Fr920xtChina = 2131;
        public const ushort Fr920xtJapan = 2132;
        public const ushort Virbx = 2134;
        public const ushort VivoSmartApac = 2135;
        public const ushort EtrexTouch = 2140;
        public const ushort Edge25 = 2147;
        public const ushort Fr25 = 2148;
        public const ushort VivoFit2 = 2150;
        public const ushort Fr225 = 2153;
        public const ushort Fr630 = 2156;
        public const ushort Fr230 = 2157;
        public const ushort VivoActiveApac = 2160;
        public const ushort Vector2 = 2161;
        public const ushort Vector2s = 2162;
        public const ushort Virbxe = 2172;
        public const ushort Fr620Taiwan = 2173;
        public const ushort Fr220Taiwan = 2174;
        public const ushort Truswing = 2175;
        public const ushort Fenix3China = 2188;
        public const ushort Fenix3Twn = 2189;
        public const ushort VariaHeadlight = 2192;
        public const ushort VariaTaillightOld = 2193;
        public const ushort EdgeExplore1000 = 2204;
        public const ushort Fr225Asia = 2219;
        public const ushort VariaRadarTaillight = 2225;
        public const ushort VariaRadarDisplay = 2226;
        public const ushort Edge20 = 2238;
        public const ushort D2Bravo = 2262;
        public const ushort ApproachS20 = 2266;
        public const ushort VariaRemote = 2276;
        public const ushort Hrm4Run = 2327;
        public const ushort VivoActiveHr = 2337;
        public const ushort VivoSmartGpsHr = 2347;
        public const ushort VivoSmartHr = 2348;
        public const ushort VivoMove = 2368;
        public const ushort VariaVision = 2398;
        public const ushort VivoFit3 = 2406;
        public const ushort Fenix3Hr = 2413;
        public const ushort IndexSmartScale = 2429;
        public const ushort Fr235 = 2431;
        public const ushort Oregon7xx = 2441;
        public const ushort Rino7xx = 2444;
        public const ushort Nautix = 2496;
        public const ushort Edge820 = 2530;
        public const ushort EdgeExplore820 = 2531;
        public const ushort Sdm4 = 10007; // SDM4 footpod
        public const ushort EdgeRemote = 10014;
        public const ushort TrainingCenter = 20119;
        public const ushort ConnectiqSimulator = 65531;
        public const ushort AndroidAntplusPlugin = 65532;
        public const ushort Connect = 65534; // Garmin Connect website
        public const ushort Invalid = (ushort)0xFFFF;


    }
}

