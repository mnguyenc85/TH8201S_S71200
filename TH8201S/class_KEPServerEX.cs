using System;

namespace TH8201S
{
    public static class ClassKEPServerEX
    {
        // Class Khai báo tag
        public static string[] tagread(int tagnumber)
        {
            string tagID_1 = "Channel1.Device1.START";
            string tagID_2 = "Channel1.Device1.CURRENT_POSITION";
            string tagID_3 = "Channel1.Device1.AU_MANUAL";
            string tagID_4 = "Channel1.Device1.CHU_KY_LAP_LAI_HYSTERERSIS";
            string tagID_5 = "Channel1.Device1.ELONG";
            string tagID_6 = "Channel1.Device1.EMPTY_WEIGHT";
            string tagID_7 = "Channel1.Device1.FAST_DOWN";
            string tagID_8 = "Channel1.Device1.FAST_UP";
            string tagID_9 = "Channel1.Device1.FORCE_MAX";
            string tagID_10 = "Channel1.Device1.FORCE_MIN";
            string tagID_11 = "Channel1.Device1.REAL_WEIGHT";
            string tagID_12 = "Channel1.Device1.Report_Trigger";
            string tagID_13 = "Channel1.Device1.RETURN";
            string tagID_14 = "Channel1.Device1.SELECT_MODE";
            string tagID_15 = "Channel1.Device1.SELECT_MODE_HYSTERISER";
            string tagID_16 = "Channel1.Device1.SET_POSITION_HYSTERERSIS";
            string tagID_17 = "Channel1.Device1.SET_POSTITON_STRESS_RELAX";
            string tagID_18 = "Channel1.Device1.SET_SPAN_SCALE";
            string tagID_19 = "Channel1.Device1.SET_ZERO_SCALE";
            string tagID_20 = "Channel1.Device1.SLOW_DOWN";
            string tagID_21 = "Channel1.Device1.SLOW_UP";
            string tagID_22 = "Channel1.Device1.SPAN";
            string tagID_23 = "Channel1.Device1.STOP";
            string tagID_24 = "Channel1.Device1.STRAIN_MAX";
            string tagID_25 = "Channel1.Device1.STRAIN_MIN";
            string tagID_26 = "Channel1.Device1.STRESS";
            string tagID_27 = "Channel1.Device1.VELOCITY_BENDING_INPUT";
            string tagID_28 = "Channel1.Device1.VELOCITY_COMPRESS_INPUT";
            string tagID_29 = "Channel1.Device1.VELOCITY_GO_HOME";
            string tagID_30 = "Channel1.Device1.VELOCITY_HYSTERERSIS_INPUT";
            string tagID_31 = "Channel1.Device1.VELOCITY_STRESS_RELAX_INPUT";
            string tagID_32 = "Channel1.Device1.VELOCITY_TENSILE_INPUT";
            string tagID_33 = "Channel1.Device1.VONG_LAP_HIEN_TAI";
            string tagID_34 = "Channel1.Device1.ZERO";
            string tagID_35 = "Channel1.Device1.WATCH_DOG";
            string tagID_36 = "Channel1.Device1.SET_ZERO";
            string tagID_37 = "Channel1.Device1.SET_FORCE_HYSTERERSIS";
            string tagID_38 = "Channel1.Device1.CHANEL_AI";
            string tagID_39 = "Channel1.Device1.SET_MASS";
            string tagID_40 = "Channel1.Device1.chieu_cao_compress";
            string tagID_41 = "Channel1.Device1.chieu_dai_bending";
            string tagID_42 = "Channel1.Device1.chieu_dai_compress";
            string tagID_43 = "Channel1.Device1.chieu_dai_hysterersis";
            string tagID_44 = "Channel1.Device1.chieu_dai_relax";
            string tagID_45 = "Channel1.Device1.chieu_dai_tensile";
            string tagID_46 = "Channel1.Device1.chieu_day_bending";
            string tagID_47 = "Channel1.Device1.chieu_day_hysterersis";
            string tagID_48 = "Channel1.Device1.chieu_day_relax";
            string tagID_49 = "Channel1.Device1.chieu_day_tensile";
            string tagID_50 = "Channel1.Device1.chieu_rong_bending";
            string tagID_51 = "Channel1.Device1.chieu_rong_hysterersis";
            string tagID_52 = "Channel1.Device1.chieu_rong_relax";
            string tagID_53 = "Channel1.Device1.chieu_rong_tensile";
            string tagID_54 = "Channel1.Device1.select_sharp_compress";
            string tagID_55 = "Channel1.Device1.LENGHT";
            string tagID_56 = "Channel1.Device1.WIDTH";
            string tagID_57 = "Channel1.Device1.HEIGHT";
            string tagID_58 = "Channel1.Device1.RADIUS";
            string tagID_59 = "Channel1.Device1.SET_STRAIN";
            string tagID_60 = "Channel1.Device1.SET_FORCE";
            string tagID_61 = "Channel1.Device1.SET_SPEED";
            string tagID_62 = "Channel1.Device1.SELECT_MODE_SQL";
            string tagID_63 = "Channel1.Device1.SET_CYCLE";
            string tagID_64 = "Channel1.Device1.ID_ORDER";
            string tagID_65 = "Channel1.Device1.SAMPLE_TIME";
            string tagID_66 = "Channel1.Device1.SET_STRAIN_2";
            string tagID_67 = "Channel1.Device1.Trigger_Chart";
            string tagID_68 = "Channel1.Device1.L0";
            string tagID_69 = "Channel1.Device1.CV_BOOL";
            string tagID_70 = "Channel1.Device1.FINISH";
            string tagID_71 = "Channel1.Device1.FORCE_MAX_INPUT";

            string[] tags;
            tags = new string[tagnumber];
            tags.SetValue(tagID_1, 1);
            tags.SetValue(tagID_2, 2);
            tags.SetValue(tagID_3, 3);
            tags.SetValue(tagID_4, 4);
            tags.SetValue(tagID_5, 5);
            tags.SetValue(tagID_6, 6);
            tags.SetValue(tagID_7, 7);
            tags.SetValue(tagID_8, 8);
            tags.SetValue(tagID_9, 9);
            tags.SetValue(tagID_10, 10);
            tags.SetValue(tagID_11, 11);
            tags.SetValue(tagID_12, 12);
            tags.SetValue(tagID_13, 13);
            tags.SetValue(tagID_14, 14);
            tags.SetValue(tagID_15, 15);
            tags.SetValue(tagID_16, 16);
            tags.SetValue(tagID_17, 17);
            tags.SetValue(tagID_18, 18);
            tags.SetValue(tagID_19, 19);
            tags.SetValue(tagID_20, 20);
            tags.SetValue(tagID_21, 21);
            tags.SetValue(tagID_22, 22);
            tags.SetValue(tagID_23, 23);
            tags.SetValue(tagID_24, 24);
            tags.SetValue(tagID_25, 25);
            tags.SetValue(tagID_26, 26);
            tags.SetValue(tagID_27, 27);
            tags.SetValue(tagID_28, 28);
            tags.SetValue(tagID_29, 29);
            tags.SetValue(tagID_30, 30);
            tags.SetValue(tagID_31, 31);
            tags.SetValue(tagID_32, 32);
            tags.SetValue(tagID_33, 33);
            tags.SetValue(tagID_34, 34);
            tags.SetValue(tagID_35, 35);
            tags.SetValue(tagID_36, 36);
            tags.SetValue(tagID_37, 37);
            tags.SetValue(tagID_38, 38);
            tags.SetValue(tagID_39, 39);
            tags.SetValue(tagID_40, 40);
            tags.SetValue(tagID_41, 41);
            tags.SetValue(tagID_42, 42);
            tags.SetValue(tagID_43, 43);
            tags.SetValue(tagID_44, 44);
            tags.SetValue(tagID_45, 45);
            tags.SetValue(tagID_46, 46);
            tags.SetValue(tagID_47, 47);
            tags.SetValue(tagID_48, 48);
            tags.SetValue(tagID_49, 49);
            tags.SetValue(tagID_50, 50);
            tags.SetValue(tagID_51, 51);
            tags.SetValue(tagID_52, 52);
            tags.SetValue(tagID_53, 53);
            tags.SetValue(tagID_54, 54);
            tags.SetValue(tagID_55, 55);
            tags.SetValue(tagID_56, 56);
            tags.SetValue(tagID_57, 57);
            tags.SetValue(tagID_58, 58);
            tags.SetValue(tagID_59, 59);
            tags.SetValue(tagID_60, 60);
            tags.SetValue(tagID_61, 61);
            tags.SetValue(tagID_62, 62);
            tags.SetValue(tagID_63, 63);
            tags.SetValue(tagID_64, 64);
            tags.SetValue(tagID_65, 65);
            tags.SetValue(tagID_66, 66);
            tags.SetValue(tagID_67, 67);
            tags.SetValue(tagID_68, 68);
            tags.SetValue(tagID_69, 69);
            tags.SetValue(tagID_70, 70);
            tags.SetValue(tagID_71, 71);
            return tags;
        }
        // Class tạo array đọc ID tags - mặc định không đổi
        public static Int32[] tagID(int tagnumber)
        {
            Int32[] cltarr;
            cltarr = new Int32[tagnumber];
            for (int i = 1; i < tagnumber; i++)
            {
                cltarr.SetValue(i, i);
            }
            return cltarr;
        }
    }
}