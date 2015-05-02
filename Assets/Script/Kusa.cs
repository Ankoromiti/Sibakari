using UnityEngine;
using System.Collections;

public class Kusa : MonoBehaviour {
	
	public static float timer;
	//public static float timer1;
	//public static float timer2;
	//public static float timer3;
	//public static float timer4;
	public static bool flag;
	public static int count;

	void Start()
	{
		timer = 0.0f;
		//timer1 = 0.0f;
		//timer2 = 0.0f;
		//timer3 = 0.0f;
		//timer4 = 0.0f;
		flag = false;
	
		count = 0;
	}

	public static bool DeleteKusaFlag = false;
	public static bool kf0 = false;
	public static bool kf1 = false;
	public static bool kf2 = false;
	public static bool kf3 = false;
	public static bool kf4 = false;
	public static bool kf5 = false;
	public static bool kf6 = false;
	public static bool kf7 = false;
	public static bool kf8 = false;
	public static bool kf9 = false;
	public static bool kf10 = false;
	public static bool kf11 = false;
	public static bool kf12 = false;
	public static bool kf13 = false;
	public static bool kf14 = false;
	public static bool kf15 = false;
	public static bool kf16 = false;
	public static bool kf17 = false;
	public static bool kf18 = false;
	public static bool kf19 = false;
	public static bool kf20 = false;
	public static bool kf21 = false;
	public static bool kf22 = false;
	public static bool kf23 = false;
	public static bool kf24 = false;
	public static bool kf25 = false;
	public static bool kf26 = false;
	public static bool kf27 = false;
	public static bool kf28 = false;
	public static bool kf29 = false;
	public static bool kf30 = false;
	public static bool kf31 = false;
	public static bool kf32 = false;
	public static bool kf33 = false;
	public static bool kf34 = false;
	public static bool kf35 = false;
    public static bool kf36 = false;
    public static bool kf37 = false;
    public static bool kf38 = false;
    public static bool kf39 = false;
    public static bool kf40 = false;
    public static bool kf41 = false;
    public static bool kf42 = false;
    public static bool kf43 = false;
    public static bool kf44 = false;
    public static bool kf45 = false;
    public static bool kf46 = false;
    public static bool kf47 = false;
    public static bool kf48 = false;
    public static bool kf49 = false;

    public static bool kf50 = false;
    public static bool kf51 = false;
    public static bool kf52 = false;
    public static bool kf53 = false;
    public static bool kf54 = false;
    public static bool kf55 = false;
    public static bool kf56 = false;
    public static bool kf57 = false;
    public static bool kf58 = false;
    public static bool kf59 = false;
    public static bool kf60 = false;
    public static bool kf61 = false;
    public static bool kf62 = false;
    public static bool kf63 = false;
    public static bool kf64 = false;
    public static bool kf65 = false;
    public static bool kf66 = false;
    public static bool kf67 = false;
    public static bool kf68 = false;
    public static bool kf69 = false;
    public static bool kf70 = false;
    public static bool kf71 = false;
    public static bool kf72 = false;
    public static bool kf73 = false;
    public static bool kf74 = false;
    public static bool kf75 = false;
    public static bool kf76 = false;
    public static bool kf77 = false;
    public static bool kf78 = false;
    public static bool kf79 = false;
    public static bool kf80 = false;
    public static bool kf81 = false;
    public static bool kf82 = false;
    public static bool kf83 = false;
    public static bool kf84 = false;
    public static bool kf85 = false;
    public static bool kf86 = false;
    public static bool kf87 = false;
    public static bool kf88 = false;
    public static bool kf89 = false;
    public static bool kf90 = false;
    public static bool kf91 = false;
    public static bool kf92 = false;
    public static bool kf93 = false;
    public static bool kf94 = false;
    public static bool kf95 = false;
    public static bool kf96 = false;
    public static bool kf97 = false;
    public static bool kf98 = false;
    public static bool kf99 = false;

	void OnTriggerEnter( Collider other )
	{
		if (other.name == "Player") {
			timer = 0;
			DeleteKusaFlag = true;
			Destroy (gameObject);

			if (other.transform.position.x != 0){
				flag = true;
			}

			if (gameObject.name == "kusa0" || gameObject.name == "kusa0(Clone)") {
				kf0 = true;
			}
			if (gameObject.name == "kusa1" || gameObject.name == "kusa1(Clone)") {
				kf1 = true;
			}
			if (gameObject.name == "kusa2" || gameObject.name == "kusa2(Clone)") {
				kf2 = true;
			}
			if (gameObject.name == "kusa3" || gameObject.name == "kusa3(Clone)") {
				kf3 = true;
			}
			if (gameObject.name == "kusa4" || gameObject.name == "kusa4(Clone)") {
				kf4 = true;
			}
			if (gameObject.name == "kusa5" || gameObject.name == "kusa5(Clone)") {
				kf5 = true;
			}
			if (gameObject.name == "kusa6" || gameObject.name == "kusa6(Clone)") {
				kf6 = true;
			}
			if (gameObject.name == "kusa7" || gameObject.name == "kusa7(Clone)") {
				kf7 = true;
			}
			if (gameObject.name == "kusa8" || gameObject.name == "kusa8(Clone)") {
				kf8 = true;
			}
			if (gameObject.name == "kusa9" || gameObject.name == "kusa9(Clone)") {
				kf9 = true;
			}
			if (gameObject.name == "kusa10" || gameObject.name == "kusa10(Clone)") {
				kf10 = true;
			}
			if (gameObject.name == "kusa11" || gameObject.name == "kusa11(Clone)") {
				kf11 = true;
			}
			if (gameObject.name == "kusa12" || gameObject.name == "kusa12(Clone)") {
				kf12 = true;
			}
			if (gameObject.name == "kusa13" || gameObject.name == "kusa13(Clone)") {
				kf13 = true;
			}
			if (gameObject.name == "kusa14" || gameObject.name == "kusa14(Clone)") {
				kf14 = true;
			}
			if (gameObject.name == "kusa15" || gameObject.name == "kusa15(Clone)") {
				kf15 = true;
			}
			if (gameObject.name == "kusa16" || gameObject.name == "kusa16(Clone)") {
				kf16 = true;
			}
			if (gameObject.name == "kusa17" || gameObject.name == "kusa17(Clone)") {
				kf17 = true;
			}
			if (gameObject.name == "kusa18" || gameObject.name == "kusa18(Clone)") {
				kf18 = true;
			}
			if (gameObject.name == "kusa19" || gameObject.name == "kusa19(Clone)") {
				kf19 = true;
			}
			if (gameObject.name == "kusa20" || gameObject.name == "kusa20(Clone)") {
				kf20 = true;
			}
			if (gameObject.name == "kusa21" || gameObject.name == "kusa21(Clone)") {
				kf21 = true;
			}
			if (gameObject.name == "kusa22" || gameObject.name == "kusa22(Clone)") {
				kf22 = true;
			}
			if (gameObject.name == "kusa23" || gameObject.name == "kusa23(Clone)") {
				kf23 = true;
			}
			if (gameObject.name == "kusa24" || gameObject.name == "kusa24(Clone)") {
				kf24 = true;
			}
			if (gameObject.name == "kusa25" || gameObject.name == "kusa25(Clone)") {
				kf25 = true;
			}
			if (gameObject.name == "kusa26" || gameObject.name == "kusa26(Clone)") {
				kf26 = true;
			}
			if (gameObject.name == "kusa27" || gameObject.name == "kusa27(Clone)") {
				kf27 = true;
			}
			if (gameObject.name == "kusa28" || gameObject.name == "kusa28(Clone)") {
				kf28 = true;
			}
			if (gameObject.name == "kusa29" || gameObject.name == "kusa29(Clone)") {
				kf29 = true;
			}
			if (gameObject.name == "kusa30" || gameObject.name == "kusa30(Clone)") {
				kf30 = true;
			}
			if (gameObject.name == "kusa31" || gameObject.name == "kusa31(Clone)") {
				kf31 = true;
			}
			if (gameObject.name == "kusa32" || gameObject.name == "kusa32(Clone)") {
				kf32 = true;
			}
			if (gameObject.name == "kusa33" || gameObject.name == "kusa33(Clone)") {
				kf33 = true;
			}
			if (gameObject.name == "kusa34" || gameObject.name == "kusa34(Clone)") {
				kf34 = true;
			}
			if (gameObject.name == "kusa35" || gameObject.name == "kusa35(Clone)") {
				kf35 = true;
			}
            if (gameObject.name == "kusa36" || gameObject.name == "kusa36(Clone)")
            {
                kf36 = true;
            }
            if (gameObject.name == "kusa37" || gameObject.name == "kusa37(Clone)")
            {
                kf37 = true;
            }
            if (gameObject.name == "kusa38" || gameObject.name == "kusa38(Clone)")
            {
                kf38 = true;
            }
            if (gameObject.name == "kusa39" || gameObject.name == "kusa39(Clone)")
            {
                kf39 = true;
            }
            if (gameObject.name == "kusa40" || gameObject.name == "kusa40(Clone)")
            {
                kf40 = true;
            }
            if (gameObject.name == "kusa41" || gameObject.name == "kusa41(Clone)")
            {
                kf41 = true;
            }
            if (gameObject.name == "kusa42" || gameObject.name == "kusa42(Clone)")
            {
                kf42 = true;
            }
            if (gameObject.name == "kusa43" || gameObject.name == "kusa43(Clone)")
            {
                kf43 = true;
            }
            if (gameObject.name == "kusa44" || gameObject.name == "kusa44(Clone)")
            {
                kf44 = true;
            }
            if (gameObject.name == "kusa45" || gameObject.name == "kusa45(Clone)")
            {
                kf45 = true;
            }
            if (gameObject.name == "kusa46" || gameObject.name == "kusa46(Clone)")
            {
                kf46 = true;
            }
            if (gameObject.name == "kusa47" || gameObject.name == "kusa47(Clone)")
            {
                kf47 = true;
            }
            if (gameObject.name == "kusa48" || gameObject.name == "kusa48(Clone)")
            {
                kf48 = true;
            }
            if (gameObject.name == "kusa49" || gameObject.name == "kusa49(Clone)")
            {
                kf49 = true;
            }


            if (gameObject.name == "kusa50" || gameObject.name == "kusa50(Clone)")
            {
                kf50 = true;
            }
            if (gameObject.name == "kusa51" || gameObject.name == "kusa51(Clone)")
            {
                kf51 = true;
            }
            if (gameObject.name == "kusa52" || gameObject.name == "kusa52(Clone)")
            {
                kf52 = true;
            }
            if (gameObject.name == "kusa53" || gameObject.name == "kusa53(Clone)")
            {
                kf53 = true;
            }
            if (gameObject.name == "kusa54" || gameObject.name == "kusa54(Clone)")
            {
                kf54 = true;
            }
            if (gameObject.name == "kusa55" || gameObject.name == "kusa55(Clone)")
            {
                kf55 = true;
            }
            if (gameObject.name == "kusa56" || gameObject.name == "kusa56(Clone)")
            {
                kf56 = true;
            }
            if (gameObject.name == "kusa57" || gameObject.name == "kusa57(Clone)")
            {
                kf57 = true;
            }
            if (gameObject.name == "kusa58" || gameObject.name == "kusa58(Clone)")
            {
                kf58 = true;
            }
            if (gameObject.name == "kusa59" || gameObject.name == "kusa59(Clone)")
            {
                kf59 = true;
            }
            if (gameObject.name == "kusa60" || gameObject.name == "kusa60(Clone)")
            {
                kf60 = true;
            }
            if (gameObject.name == "kusa61" || gameObject.name == "kusa61(Clone)")
            {
                kf61 = true;
            }
            if (gameObject.name == "kusa62" || gameObject.name == "kusa62(Clone)")
            {
                kf62 = true;
            }
            if (gameObject.name == "kusa63" || gameObject.name == "kusa63(Clone)")
            {
                kf63 = true;
            }
            if (gameObject.name == "kusa64" || gameObject.name == "kusa64(Clone)")
            {
                kf64 = true;
            }
            if (gameObject.name == "kusa65" || gameObject.name == "kusa65(Clone)")
            {
                kf65 = true;
            }
            if (gameObject.name == "kusa66" || gameObject.name == "kusa66(Clone)")
            {
                kf66 = true;
            }
            if (gameObject.name == "kusa67" || gameObject.name == "kusa67(Clone)")
            {
                kf67 = true;
            }
            if (gameObject.name == "kusa68" || gameObject.name == "kusa68(Clone)")
            {
                kf68 = true;
            }
            if (gameObject.name == "kusa69" || gameObject.name == "kusa69(Clone)")
            {
                kf69 = true;
            }
            if (gameObject.name == "kusa70" || gameObject.name == "kusa70(Clone)")
            {
                kf70 = true;
            }
            if (gameObject.name == "kusa71" || gameObject.name == "kusa71(Clone)")
            {
                kf71 = true;
            }
            if (gameObject.name == "kusa72" || gameObject.name == "kusa72(Clone)")
            {
                kf72 = true;
            }
            if (gameObject.name == "kusa73" || gameObject.name == "kusa73(Clone)")
            {
                kf73 = true;
            }
            if (gameObject.name == "kusa74" || gameObject.name == "kusa74(Clone)")
            {
                kf74 = true;
            }
            if (gameObject.name == "kusa75" || gameObject.name == "kusa75(Clone)")
            {
                kf75 = true;
            }
            if (gameObject.name == "kusa76" || gameObject.name == "kusa76(Clone)")
            {
                kf76 = true;
            }
            if (gameObject.name == "kusa77" || gameObject.name == "kusa77(Clone)")
            {
                kf77 = true;
            }
            if (gameObject.name == "kusa78" || gameObject.name == "kusa78(Clone)")
            {
                kf78 = true;
            }
            if (gameObject.name == "kusa79" || gameObject.name == "kusa79(Clone)")
            {
                kf79 = true;
            }
            if (gameObject.name == "kusa80" || gameObject.name == "kusa80(Clone)")
            {
                kf80 = true;
            }
            if (gameObject.name == "kusa81" || gameObject.name == "kusa81(Clone)")
            {
                kf81 = true;
            }
            if (gameObject.name == "kusa82" || gameObject.name == "kusa82(Clone)")
            {
                kf82 = true;
            }
            if (gameObject.name == "kusa83" || gameObject.name == "kusa83(Clone)")
            {
                kf83 = true;
            }
            if (gameObject.name == "kusa84" || gameObject.name == "kusa84(Clone)")
            {
                kf84 = true;
            }
            if (gameObject.name == "kusa85" || gameObject.name == "kusa85(Clone)")
            {
                kf85 = true;
            }
            if (gameObject.name == "kusa86" || gameObject.name == "kusa86(Clone)")
            {
                kf86 = true;
            }
            if (gameObject.name == "kusa87" || gameObject.name == "kusa87(Clone)")
            {
                kf87 = true;
            }
            if (gameObject.name == "kusa88" || gameObject.name == "kusa88(Clone)")
            {
                kf88 = true;
            }
            if (gameObject.name == "kusa89" || gameObject.name == "kusa89(Clone)")
            {
                kf89 = true;
            }
            if (gameObject.name == "kusa90" || gameObject.name == "kusa90(Clone)")
            {
                kf90 = true;
            }
            if (gameObject.name == "kusa91" || gameObject.name == "kusa91(Clone)")
            {
                kf91 = true;
            }
            if (gameObject.name == "kusa92" || gameObject.name == "kusa92(Clone)")
            {
                kf92 = true;
            }
            if (gameObject.name == "kusa93" || gameObject.name == "kusa93(Clone)")
            {
                kf93 = true;
            }
            if (gameObject.name == "kusa94" || gameObject.name == "kusa94(Clone)")
            {
                kf94 = true;
            }
            if (gameObject.name == "kusa95" || gameObject.name == "kusa95(Clone)")
            {
                kf95 = true;
            }
            if (gameObject.name == "kusa96" || gameObject.name == "kusa96(Clone)")
            {
                kf96 = true;
            }
            if (gameObject.name == "kusa97" || gameObject.name == "kusa97(Clone)")
            {
                kf97 = true;
            }
            if (gameObject.name == "kusa98" || gameObject.name == "kusa98(Clone)")
            {
                kf98 = true;
            }
            if (gameObject.name == "kusa99" || gameObject.name == "kusa99(Clone)")
            {
                kf99 = true;
            }
		}
	
}

}
